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
    public partial class FileEducationDiplomasForm : Form
    {
        SqlConnection connection;
        FileForm fileForm;
        string wbSeries;
        string wbNumber;
        public FileEducationDiplomasForm(SqlConnection connection, FileForm fileForm, string wbSeries, string wbNumber)
        {
            this.wbSeries = wbSeries;
            this.wbNumber = wbNumber;
            this.connection = connection;
            this.fileForm = fileForm;
            InitializeComponent();
        }

        private void FileEducationDiplomasForm_Load(object sender, EventArgs e)
        {
            this.Text += fileForm.LastNameTextBox.Text + " " + fileForm.FirstNameTextBox.Text + " " + fileForm.PatronymicTextBox.Text;
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT id_personal_file FROM Personal_File WHERE wb_series = '{wbSeries}' " +
                $"AND wb_number = '{wbNumber}'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string idFile = ds.Tables[0].Rows[0][0].ToString();

            adapter = new SqlDataAdapter($"SELECT 'Название организации' = organization_name, 'Уровень' = education_level, " +
                $"'Степень' = education_degree, 'Специальность' = speciality, 'Серия диплома' = diploma_series, " +
                $"'Номер диплома' = diploma_number, 'Дата выдачи' = issue_date FROM Education_Diploma WHERE id_personal_file = {idFile}", connection);
            ds = new DataSet();
            adapter.Fill(ds);
            EducationDiplomaDataGrid.DataSource = ds.Tables[0];
        }
    }
}
