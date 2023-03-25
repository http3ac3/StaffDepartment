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
    public partial class AddWDForm : Form
    {
        SqlConnection connection;
        DirectorForm directorForm;
        bool isEditing;
        string wdName;
        public AddWDForm(SqlConnection connection, DirectorForm directorForm, bool isEditing, string wdName)
        {
            this.connection = connection;
            this.directorForm = directorForm;
            this.isEditing = isEditing;
            this.wdName = wdName;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (WDNameTB.Text == "")
                {
                    MessageBox.Show("Поле \'Название не заполнено\'", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    new SqlCommand($"INSERT INTO Work_Department VALUES ('{WDNameTB.Text.Trim()}')", connection).ExecuteNonQuery();
                    MessageBox.Show($"Рабочий отдел {WDNameTB.Text.Trim()} был успешно добавлен", "Добавление", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    directorForm.RefreshWDDataGrid();
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                if (WDNameTB.Text == "")
                {
                    MessageBox.Show("Поле \'Название не заполнено\'", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    new SqlCommand($"UPDATE Work_Department SET work_department_name = '{WDNameTB.Text.Trim()}' WHERE work_department_name = '{wdName}'", 
                        connection)
                        .ExecuteNonQuery();
                    MessageBox.Show($"Рабочий отдел {wdName} был успешно изменен", "Изменение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    directorForm.RefreshWDDataGrid();
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        }

        private void AddWDForm_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                this.Text = "Изменение рабочего отдела";
                AddButton.Text = "Изменить";
                WDNameTB.Text = wdName;
            }
            
        }
    }
}
