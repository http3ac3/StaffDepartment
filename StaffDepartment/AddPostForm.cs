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
    public partial class AddPostForm : Form
    {
        bool isEditing;

        string postName; 
        decimal salary; 
        decimal rise;

        SqlConnection connection;
        DirectorForm directorForm;
        public AddPostForm(SqlConnection connection, DirectorForm directorForm, bool isEditing)
        {
            this.isEditing = isEditing;
            this.connection = connection;
            this.directorForm = directorForm;
            InitializeComponent();
        }
        public AddPostForm(SqlConnection connection, DirectorForm directorForm, bool isEditing, string postName, decimal salary, decimal rise)
        {
            this.postName = postName;
            this.salary = salary;
            this.rise = rise;

            this.isEditing = isEditing;
            this.connection = connection;
            this.directorForm = directorForm;
            InitializeComponent();
        }
        private void AddPostButton_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (PostNameTB.Text == "")
                {
                    MessageBox.Show("Поле \'Должность\' не заполнено", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    new SqlCommand($"INSERT INTO Post VALUES ('{PostNameTB.Text.Trim()}', {SalaryTB.Value.ToString().Replace(',', '.')}, " +
                        $"{((RiseTB.Value / (decimal)100.0) + 1).ToString().Replace(',', '.')})", connection).ExecuteNonQuery();
                    MessageBox.Show($"Должность {PostNameTB.Text} успешно добавлена", "Добавление должности",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    directorForm.RefreshPostDataGrid();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (PostNameTB.Text == "")
                {
                    MessageBox.Show("Поле \'Должность\' не заполнено", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    new SqlCommand($"UPDATE Post SET post_name = '{PostNameTB.Text.Trim()}', salary = {SalaryTB.Value.ToString().Replace(',', '.')}, " +
                        $"rise = {((RiseTB.Value / (decimal)100.0) + 1).ToString().Replace(',', '.')} WHERE post_name = '{postName}'", 
                        connection).ExecuteNonQuery();
                    MessageBox.Show($"Должность {PostNameTB.Text} успешно изменена", "Изменение должности",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    directorForm.RefreshPostDataGrid();
                    directorForm.RefreshPersonalFileDataGrid();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void AddPostForm_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                AddPostButton.Text = "Изменить данные";
                this.Text = "Изменение должности";
                PostNameTB.Text = postName;
                SalaryTB.Value = salary;
                RiseTB.Value = rise;

            }
        }
    }
}
