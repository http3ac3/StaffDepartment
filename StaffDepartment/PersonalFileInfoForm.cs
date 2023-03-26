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
    public partial class PersonalFileInfoForm : Form
    {
        SqlConnection connection;
        AddPromotionForm addPromotionForm;

        public PersonalFileInfoForm(SqlConnection connection, AddPromotionForm addPromotionForm)
        {
            this.connection = connection;
            this.addPromotionForm = addPromotionForm;
            InitializeComponent();
        }

        private void PersonalFileInfoForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC FileOnPosts", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            PersonalFileDataGrid.DataSource = ds.Tables[0];
;        }

        private void PersonalFileDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string lastName = PersonalFileDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string firstName = PersonalFileDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            string patronymic = PersonalFileDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string wbSeries = PersonalFileDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string wbNumber = PersonalFileDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT id_personal_file FROM Personal_File WHERE wb_series = '{wbSeries}' AND wb_number = '{wbNumber}'"
                , connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            string fileId = ds.Tables[0].Rows[0][0].ToString();

            for (int i = 0; i < addPromotionForm.EmployeesDataGrid.Rows.Count; i++)
            {
                var row = addPromotionForm.EmployeesDataGrid.Rows[i];
                if (row.Cells[1].Value.ToString() == wbSeries && row.Cells[2].Value.ToString() == wbNumber)
                {
                    MessageBox.Show("Этот сотрудник уже был добавлен в список получателей поощрения", "Ошибка добавления сотрудника",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            addPromotionForm.EmployeesDataGrid.Rows.Add(fileId, $"{lastName} {firstName} {patronymic}", wbSeries, wbNumber);
            this.Close();
        }
    }
}
