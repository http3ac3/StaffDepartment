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
    public partial class FileForm : Form
    {
        private bool changingMode = false;

        private string wb_series;
        private string wb_number;
        private SqlConnection connection;

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

        public void UpdateInfo(string lastName, string firstName, string patronymic, string wbSeries, string wbNumber,
            string phoneNumber, string birthdayDate, int experience, int mcNumber, string personellNumber, string contractStatus,
            string conclusionDate, string employmentDate, string dismissialDate, string country, string region, string locality,
            string street, string homeNumber, int? apartmentNumber, int idSD, int? idPost, int? idWD)
        {

            MessageBox.Show(GetIdWorkDepartment().ToString());
            string update = $"UPDATE Personal_File SET last_name = '{lastName}', first_name = '{firstName}', " +
                $"patronymic = '{patronymic}', wb_series = '{wbSeries}', wb_number = '{wbNumber}', " +
                $"phone_number = '{phoneNumber}', birthday_date = '{birthdayDate}', " +
                $"experience = {experience}, mc_number = {mcNumber}, " +
                $"personell_number = '{personellNumber}', contract_status = '{contractStatus}', " +
                $"conclusion_date = '{conclusionDate}', employment_date = '{employmentDate}', " +
                $"dismissial_date = '{dismissialDate}', country = '{country}', region = '{region}', " +
                $"locality = '{locality}, street = '{street}', home_number = '{homeNumber}', " +
                $"apartment_number = {apartmentNumber}, id_staff_department = {idSD}, id_post = {idPost}, " +
                $"id_work_department = {idWD}";
            
        }

        public void GetPostBox(object value)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT post_name FROM Post", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ds.Tables[0].Rows.Add("Не указано");
            PostCB.DataSource = ds.Tables[0];
            PostCB.DisplayMember = "post_name";

            if (value.ToString() != "")
                PostCB.Text = PostCB.GetItemText(value);
            else
                PostCB.SelectedIndex = PostCB.Items.Count - 1;
        }

        public void GetWorkingDepartmentBox(object value)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT work_department_name FROM Work_Department", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ds.Tables[0].Rows.Add("Не указано");
            WorkingDepartmentCB.DataSource = ds.Tables[0];
            WorkingDepartmentCB.DisplayMember = "work_department_name";

            if (value.ToString() != "")
                WorkingDepartmentCB.Text = WorkingDepartmentCB.GetItemText(value);
            else
                WorkingDepartmentCB.SelectedIndex = WorkingDepartmentCB.Items.Count - 1;

        }

        public void GetContractStatus(object value) =>     
            ContractStatusCB.SelectedIndex = ContractStatusCB.Items.IndexOf(value);
        
        public void FillSelfInfo(DataSet ds)
        {
            DataRow row = ds.Tables[0].Rows[0];
            LastNameTextBox.Text = row[0].ToString();
            FirstNameTextBox.Text = row[1].ToString();
            PatronymicTextBox.Text = row[2].ToString();
            PhoneNumberTextBox.Text = row[3].ToString();
            BirthdayDateTextBox.Text = row[4].ToString();
            ExperienceTextBox.Text = row[5].ToString();
            MCNumberTextBox.Text = row[6].ToString();
            CountryTextBox.Text = row[7].ToString();
            RegionTextBox.Text = row[8].ToString();
            LocalityTextBox.Text = row[9].ToString();
            StreetTextBox.Text = row[10].ToString();
            HomeNumberTextBox.Text = row[11].ToString();
            ApartmentNumberTextBox.Text = row[12].ToString();
            WBNumberTextBox.Text = wb_number;
            WBSeriesCB.SelectedIndex = WBSeriesCB.Items.IndexOf(wb_series);
        }

        public void FillWorkInfo(DataSet ds)
        {
            DataRow row = ds.Tables[0].Rows[0];
            PersonellNumberTextBox.Text = row[0].ToString();

            GetPostBox(row[1].ToString());
            GetWorkingDepartmentBox(row[13].ToString());
            GetContractStatus(row[2].ToString());

            ConclusionDateTextBox.Text = row[3].ToString();
            EmploymentDateTextBox.Text = row[4].ToString();
            DismissialDateTextBox.Text = row[5].ToString();
            SDCountryTextBox.Text = row[6].ToString();
            SDRegionTextBox.Text = row[7].ToString();
            SDLocalityTextBox.Text = row[8].ToString();
            SDStreetTextBox.Text = row[9].ToString();
            SDHomeNumberTextBox.Text = row[10].ToString();
            SDHousingNumberTextBox.Text = row[11].ToString();
            SDApartmentNumberTextBox.Text = row[12].ToString();
        }

        public FileForm(string wb_series, string wb_number, SqlConnection connection)
        {
            this.connection = connection;
            this.wb_number = wb_number;
            this.wb_series = wb_series;
            InitializeComponent();
            
        }

        private void FileForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"EXEC FileSelfInfo '{wb_series}', '{wb_number}'", connection);
            DataSet selfInfoDataSet = new DataSet();
            adapter.Fill(selfInfoDataSet);
            FillSelfInfo(selfInfoDataSet);

            DataSet workInfoDataSet = new DataSet();
            adapter = new SqlDataAdapter($"EXEC FileWorkInfo '{wb_series}', '{wb_number}'", connection);
            adapter.Fill(workInfoDataSet);
            FillWorkInfo(workInfoDataSet);
        }

        private void PromotionsButton_Click(object sender, EventArgs e) =>
            new FilePromotionsActions(LastNameTextBox.Text, connection, wb_series, wb_number, true).Show();
        

        private void DiscActionsButton_Click(object sender, EventArgs e) =>
            new FilePromotionsActions(LastNameTextBox.Text, connection, wb_series, wb_number, false).Show();
        

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            changingMode = true;

            PhoneNumberTextBox.ReadOnly = false;
            foreach (var tabPage in tabControl1.Controls.OfType<TabPage>())
            {
                foreach (var cb in tabPage.Controls.OfType<ComboBox>()) cb.Enabled = true;
                foreach (var tb in tabPage.Controls.OfType<TextBox>()) tb.ReadOnly = false;
                foreach (var gb in tabPage.Controls.OfType<GroupBox>())
                {
                    foreach (var tb in gb.Controls.OfType<TextBox>()) tb.ReadOnly = false;
                    foreach (var cb in gb.Controls.OfType<ComboBox>()) cb.Enabled = true;
                }
            }
        }

        private void FileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changingMode)
            {
                var res = MessageBox.Show($"Данные об {LastNameTextBox.Text} {FirstNameTextBox.Text} {PatronymicTextBox.Text} были изменены! " +
                    $"Сохранить изменения?", "Изменение данных о сотруднике", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (res == DialogResult.No)
                {
                    MessageBox.Show($"Данные об {LastNameTextBox.Text} изменены не были", "Изменение данных о сотруднике",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Cancel = false;
                }
                else if (res == DialogResult.Yes)
                {
                    
                }
            }
        }
    }
}
