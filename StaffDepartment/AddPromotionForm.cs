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
    public partial class AddPromotionForm : Form
    {
        SqlConnection connection;
        DirectorForm directorForm;
        bool isEditing;
        int idPromotion;
        bool isDiscAction;
        public AddPromotionForm(SqlConnection connection, DirectorForm directorForm, bool isEditing, int idPromotion, bool isDiscAction)
        {
            this.isDiscAction = isDiscAction;
            this.connection = connection;
            this.directorForm = directorForm;
            this.isEditing = isEditing;
            this.idPromotion = idPromotion;
            InitializeComponent();
        }

        public string GetFileIdByWB(string wbSeries, string wbNumber)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT id_personal_file FROM Personal_File WHERE wb_series = '{wbSeries}' AND " +
                $"wb_number = '{wbNumber}'", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0].Rows[0][0].ToString();
        }

        private void AddEmployeeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PersonalFileInfoForm(connection, this).Show();
        }

        private void AddPromotionForm_Load(object sender, EventArgs e)
        {
            if (isDiscAction)
            {
                PromotionTypeCB.Items.Clear();
                string[] items = { "замечание", "выговор", "увольнение по соответствующим основаниям" };
                PromotionTypeCB.Items.AddRange(items);
                label1.Text = "Тип взыскания";
                label2.Text = "Дата вынесения";
                label3.Text = "Опишите причину взыскания";
                label4.Text = "Сотрудники, которым будет вынесено взыскание";
                this.Text = "Добавление взыскания";
                AddPromotionButton.Text = "Добавить взыскание";
            }
            PromotionTypeCB.SelectedIndex = 0;
            PromotionDateTB.Text = DateTime.Now.ToString("d");
            EmployeesDataGrid.Columns.AddRange(
                new DataGridViewTextBoxColumn() { HeaderText = "Код сотрудника", Name = "Код сотрудника" },
                new DataGridViewTextBoxColumn() { HeaderText = "ФИО", Name = "ФИО"},
                new DataGridViewTextBoxColumn() { HeaderText = "Серия трудовой книги", Name = "Серия трудовой книги" },
                new DataGridViewTextBoxColumn() { HeaderText = "Номер трудовой книги", Name = "Номер трудовой книги" });
        }

        private void AddPromotionButton_Click(object sender, EventArgs e)
        {
            if (!isDiscAction)
            {
                new SqlCommand($"INSERT INTO Promotion VALUES ('{PromotionTypeCB.Text}', '{ReasonTB.Text}', '{PromotionDateTB.Text}')", connection)
                .ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 id_promotion FROM Promotion ORDER BY id_promotion DESC", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                string idPromotion = ds.Tables[0].Rows[0][0].ToString();
                for (int i = 0; i < EmployeesDataGrid.Rows.Count; i++)
                {
                    string wbSeries = EmployeesDataGrid.Rows[i].Cells[2].Value.ToString();
                    string wbNumber = EmployeesDataGrid.Rows[i].Cells[3].Value.ToString();
                    new SqlCommand($"INSERT INTO Personal_File_Promotion VALUES ({idPromotion}, {GetFileIdByWB(wbSeries, wbNumber)})", connection)
                        .ExecuteNonQuery();
                }
                directorForm.RefreshPromotionDataGrid();
            }
            else
            {
                new SqlCommand($"INSERT INTO Disciplinary_Action VALUES " +
                    $"('{PromotionTypeCB.Text}', '{ReasonTB.Text}', '{PromotionDateTB.Text}')", connection)
                .ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 id_action FROM Disciplinary_Action ORDER BY id_action DESC", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                string idAction = ds.Tables[0].Rows[0][0].ToString();
                for (int i = 0; i < EmployeesDataGrid.Rows.Count; i++)
                {
                    string wbSeries = EmployeesDataGrid.Rows[i].Cells[2].Value.ToString();
                    string wbNumber = EmployeesDataGrid.Rows[i].Cells[3].Value.ToString();
                    new SqlCommand($"INSERT INTO Personal_File_Disciplinary_Action VALUES ({idAction}, {GetFileIdByWB(wbSeries, wbNumber)})", connection)
                        .ExecuteNonQuery();
                }
                directorForm.RefreshDiscActionsDataGrid();
            }

            Close();
        }
    }
}
