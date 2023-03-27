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
    public partial class AllFilesInfoForm : Form
    {
        SqlConnection connection;
        AddDiplomaForm addDiplomaForm;
        public AllFilesInfoForm(SqlConnection connection, AddDiplomaForm addDiplomaForm)
        {
            this.connection = connection;
            this.addDiplomaForm = addDiplomaForm;
            InitializeComponent();
        }

        private void AllFilesInfoForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT 'Фамилия' = last_name, 'Имя' = first_name, 'Отчество' = patronymic, " +
                "'Серия трудовой книги' = wb_series, 'Номер трудовой книги' = wb_number FROM Personal_File", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            PersonalFileDataGrid.DataSource = ds.Tables[0];
        }

        private void PersonalFileDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string lastName = PersonalFileDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string firstName = PersonalFileDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string patronymic = PersonalFileDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string wbSeries = PersonalFileDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string wbNumber = PersonalFileDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            addDiplomaForm.FioTB.Text = lastName + " " + firstName + " " + patronymic;
            addDiplomaForm.WBSeriesTB.Text = wbSeries;
            addDiplomaForm.WBNumberTB.Text = wbNumber;
            this.Close();
        }
    }
}
