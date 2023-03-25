using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StaffDepartment
{
    public partial class AddPersonalFile : Form
    {
        DirectorForm directorForm;
        SqlConnection connection;
        public int idStaffDepartment;

        public AddPersonalFile(SqlConnection connection, DirectorForm directorForm)
        {
            this.directorForm = directorForm;
            this.connection = connection;
            InitializeComponent();
            ContractNotAcceptButton.Checked = true;
            
        }
        public int GetIdPost()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT id_post FROM Post WHERE post_name = '{PostCB.Text}'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }

        public int GetIdWorkDepartment()
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT id_work_department FROM Work_Department WHERE " +
                $"work_department_name = '{WorkingDepartmentCB.Text}'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }


        public void InsertFile(string lastName, string firstName, string patronymic, string wbSeries, string wbNumber,
            string phoneNumber, string birthdayDate, int experience, int mcNumber, string personellNumber, string contractStatus,
            string conclusionDate, string employmentDate, string dismissialDate, string country, string region, string locality,
            string street, string homeNumber, string apartmentNumber, int idSD, string idPost, string idWD)
        {
            patronymic = patronymic.Replace(" ", "");
            patronymic = (patronymic == "" ? "NULL" : $"\'{patronymic}\'");

            idWD = (idWD == "Не указано" ? "NULL" : GetIdWorkDepartment().ToString());

            idPost = (idPost == "Не указано" ? "NULL" : GetIdPost().ToString());

            if (apartmentNumber == "") apartmentNumber = "NULL";

            dismissialDate = (dismissialDate == "" ? "NULL" : $"\'{dismissialDate}\'");

            employmentDate = (employmentDate == "" ? "NULL" : $"\'{employmentDate}\'");

            conclusionDate = (conclusionDate == "" ? "NULL" : $"\'{conclusionDate}\'");

            personellNumber = (personellNumber == "ТН-" ? "NULL" : $"\'{personellNumber}\'");

            string insert = $"INSERT INTO Personal_File VALUES ('{lastName}', '{firstName}', {patronymic}, '{wbSeries}', " +
                $"'{wbNumber}', '{phoneNumber}', '{birthdayDate}', {experience}, {mcNumber}, {personellNumber}, '{contractStatus}'," +
                $"{conclusionDate}, {employmentDate}, {dismissialDate}, '{country}', '{region}', '{locality}', '{street}', '{homeNumber}'," +
                $"{apartmentNumber}, {idSD}, {idPost}, {idWD})";

            try
            {
                new SqlCommand(insert, connection).ExecuteNonQuery();
                MessageBox.Show($"Запись о {lastName} {firstName} {patronymic} была успешно добавлена!", "Добавление данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void UpdateSDInfo(int idSD)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT country, region, locality, street, home_number, housing_number, " +
                $"apartment_number FROM Staff_Department WHERE id_staff_department = {idSD}", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataRow row = ds.Tables[0].Rows[0];
            SDCountryTextBox.Text = row[0].ToString();
            SDRegionTextBox.Text = row[1].ToString();
            SDLocalityTextBox.Text = row[2].ToString();
            SDStreetTextBox.Text = row[3].ToString();
            SDHomeNumberTextBox.Text = row[4].ToString();
            SDHousingNumberTextBox.Text = row[5].ToString();
            SDApartmentNumberTextBox.Text = row[6].ToString();
        }

        public void GetPostBox()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT post_name FROM Post", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ds.Tables[0].Rows.Add("Не указано");
            PostCB.DataSource = ds.Tables[0];
            PostCB.DisplayMember = "post_name";
            PostCB.SelectedIndex = PostCB.Items.Count - 1;
        }

        public void GetWorkingDepartmentBox()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT work_department_name FROM Work_Department", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ds.Tables[0].Rows.Add("Не указано");
            WorkingDepartmentCB.DataSource = ds.Tables[0];
            WorkingDepartmentCB.DisplayMember = "work_department_name";
            WorkingDepartmentCB.SelectedIndex = WorkingDepartmentCB.Items.Count - 1;

        }

        private void AddPersonalFile_Load(object sender, EventArgs e)
        {
            GetWorkingDepartmentBox();
            GetPostBox();
        }

        private void ContractAcceptButton_CheckedChanged_1(object sender, EventArgs e)
        {
            PersonellNumberTextBox.ReadOnly = false;
            ConclusionDateTextBox.ReadOnly = false;
            EmploymentDateTextBox.ReadOnly = false;

            WorkingDepartmentCB.Enabled = true;
            PostCB.Enabled = true;

            ContractStatusCB.SelectedIndex = 1;
        }

        private void ContractNotAcceptButton_CheckedChanged(object sender, EventArgs e)
        {
            PostCB.SelectedIndex = PostCB.Items.Count - 1;
            WorkingDepartmentCB.SelectedIndex = WorkingDepartmentCB.Items.Count - 1;
            ContractStatusCB.SelectedIndex = 0;

            PersonellNumberTextBox.Text = "";
            ConclusionDateTextBox.Text = "";
            EmploymentDateTextBox.Text = "";
            
            PersonellNumberTextBox.ReadOnly = true;
            ConclusionDateTextBox.ReadOnly = true;
            EmploymentDateTextBox.ReadOnly = true;

            WorkingDepartmentCB.Enabled = false;
            PostCB.Enabled = false;
            ContractStatusCB.Enabled = false;
        }

        private void ChangeSDButton_Click(object sender, EventArgs e)
        {
            new ChooseStaffDepartmentForm(connection, this).Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            InsertFile(LastNameTextBox.Text, FirstNameTextBox.Text, PatronymicTextBox.Text, WBSeriesCB.Text, WBNumberTextBox.Text, 
                PhoneNumberTextBox.Text, BirthdayDateTB.Text, int.Parse(ExperienceTextBox.Text), int.Parse(MCNumberTextBox.Text),
                PersonellNumberTextBox.Text, ContractStatusCB.Text, ConclusionDateTextBox.Text, EmploymentDateTextBox.Text,
                DismissialDateTextBox.Text, CountryTextBox.Text, RegionTextBox.Text, LocalityTextBox.Text, StreetTextBox.Text, 
                HomeNumberTextBox.Text, ApartmentNumberTextBox.Text, idStaffDepartment, PostCB.Text, WorkingDepartmentCB.Text);
            this.Close();
            directorForm.RefreshPersonalFileDataGrid();
        }
    }
}
