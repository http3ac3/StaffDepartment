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
    public partial class AddDiplomaForm : Form
    {
        SqlConnection connection;
        DirectorForm directorForm;
        bool isEditing;
        string diplomaSeries;
        string diplomaNumber;
        public AddDiplomaForm(SqlConnection connection, DirectorForm directorForm, bool isEditing, string diplomaSeries, string diplomaNumber)
        {
            this.diplomaSeries = diplomaSeries;
            this.diplomaNumber = diplomaNumber;

            this.directorForm = directorForm;
            this.connection = connection;
            this.isEditing = isEditing;
            InitializeComponent();
        }

        public string GetFileIdByWB(string wbSeries, string wbNumber)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT id_personal_file FROM Personal_File" +
                $" WHERE wb_series = '{wbSeries}' AND wb_number = '{wbNumber}'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0].Rows[0][0].ToString();
        }

        private void SetPersonalFileButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            new AllFilesInfoForm(connection, this).Show();

        private void AddDiplomaButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                string fileId = GetFileIdByWB(WBSeriesTB.Text, WBNumberTB.Text);

                string eduDegree = (EduDegreeCB.Text == "не указано" ? "NULL" : $"\'{EduDegreeCB.Text}\'");
                string speciality = (SpecialityTB.Text == "" ? "NULL" : $"\'{SpecialityTB.Text}\'");
                
                string insert = $"INSERT INTO Education_Diploma VALUES ('{EduOrganizationNameTB.Text}', '{EduLevelCB.Text}', " +
                    $"{eduDegree}, {speciality}, '{DiplomaSeriesTB.Text}', '{DiplomaNumberTB.Text}', '{IssueDateTB.Text}', {fileId})";
                new SqlCommand(insert, connection).ExecuteNonQuery();
                MessageBox.Show("Новый диплом добавлен в базу данных", "Добавление диплома", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                directorForm.RefreshDiplomaDataGrid();
            }
            else
            {
                string fileId = GetFileIdByWB(WBSeriesTB.Text, WBNumberTB.Text);

                string eduDegree = (EduDegreeCB.Text == "" ? "NULL" : $"\'{EduDegreeCB.Text}\'");
                string speciality = (SpecialityTB.Text == "" ? "NULL" : $"\'{SpecialityTB.Text}\'");

                string update = $"UPDATE Education_Diploma SET organization_name = '{EduOrganizationNameTB.Text}', " +
                    $"education_level = '{EduLevelCB.Text}', education_degree = {eduDegree}, speciality = {speciality}," +
                    $"diploma_series = '{DiplomaSeriesTB.Text}', diploma_number = '{DiplomaNumberTB.Text}', issue_date = '{IssueDateTB.Text}', " +
                    $"id_personal_file = {fileId} WHERE diploma_series = '{diplomaSeries}' AND diploma_number = '{diplomaNumber}'";
                new SqlCommand(update, connection).ExecuteNonQuery();
                MessageBox.Show("Изменение диплома выполнено успешно", "Изменение диплома", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                directorForm.RefreshDiplomaDataGrid();
            }
        }

        private void AddDiplomaForm_Load(object sender, EventArgs e)
        {
            EduDegreeCB.SelectedIndex = 4;
            if (isEditing)
            {
                this.Text = "Изменение данных диплома";
                AddDiplomaButton.Text = "Изменить диплом";
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Education_Diploma WHERE diploma_series = '{diplomaSeries}' AND " +
                    $"diploma_number = '{diplomaNumber}'", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                EduOrganizationNameTB.Text = ds.Tables[0].Rows[0][1].ToString();
                EduLevelCB.SelectedItem = ds.Tables[0].Rows[0][2].ToString();
                EduDegreeCB.SelectedItem = ds.Tables[0].Rows[0][3].ToString();
                SpecialityTB.Text = ds.Tables[0].Rows[0][4].ToString();
                DiplomaSeriesTB.Text = ds.Tables[0].Rows[0][5].ToString();
                DiplomaNumberTB.Text = ds.Tables[0].Rows[0][6].ToString();
                IssueDateTB.Text = ds.Tables[0].Rows[0][7].ToString();

                adapter = new SqlDataAdapter($"SELECT last_name + ' ' + first_name + ' ' + patronymic, wb_series, wb_number FROM Personal_File " +
                    $"WHERE id_personal_file = {ds.Tables[0].Rows[0][8]}", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                FioTB.Text = ds.Tables[0].Rows[0][0].ToString();
                WBSeriesTB.Text = ds.Tables[0].Rows[0][1].ToString();
                WBNumberTB.Text = ds.Tables[0].Rows[0][2].ToString();
            }
        }
    }
}
