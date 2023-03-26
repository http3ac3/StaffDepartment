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
    public partial class AddStaffDepartmentForm : Form
    {
        SqlConnection connection;
        DirectorForm directorForm;
        bool isEditing;
        int choosenRow;

        string phoneNumber;
        public AddStaffDepartmentForm(SqlConnection connection, DirectorForm directorForm, bool isEditing, int choosenRow)
        {
            this.choosenRow = choosenRow;
            this.connection = connection;
            this.directorForm = directorForm;
            this.isEditing = isEditing;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string housingNumber = (HousingNumberTB.Text == "" ? "NULL" : $"\'{HousingNumberTB.Text}\'");
            string apartmentNumber = (ApartmentNumberTB.Text == "" ? "NULL" : $"\'{ApartmentNumberTB.Text}\'");
            if (!isEditing)
            {
                try
                {
                    new SqlCommand($"INSERT INTO Staff_Department VALUES ('{CountryTB.Text}', '{RegionTB.Text}', '{LocalityTB.Text}', '{StreetTB.Text}', " +
                    $"'{HomeNumberTB.Text}', {housingNumber}, {apartmentNumber}, '{IndexTB.Text}','{PhoneNumberTB.Text}')", connection).ExecuteNonQuery();
                    MessageBox.Show("Запись об отделе кадров успешно добавлена", "Добавление отдела кадров", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    directorForm.RefreshStaffDepartmentDataGrid();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    new SqlCommand($"UPDATE Staff_Department SET country = '{CountryTB.Text}', region = '{RegionTB.Text}', " +
                        $"locality = '{LocalityTB.Text}', street = '{StreetTB.Text}', home_number = '{HomeNumberTB.Text}', " +
                        $"housing_number = {housingNumber}, apartment_number = {apartmentNumber}, sd_index = '{IndexTB.Text}', " +
                        $"phone_number = '{PhoneNumberTB.Text}' WHERE phone_number = '{phoneNumber}'", connection).ExecuteNonQuery();
                    MessageBox.Show("Информация успешно обновлена", "Обновление информации об отделе кадров", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    
                    directorForm.RefreshStaffDepartmentDataGrid();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddStaffDepartmentForm_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                this.Text = "Изменение отдела кадров";
                AddButton.Text = "Изменить отдел кадров";
                CountryTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[0].Value.ToString();
                RegionTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[1].Value.ToString();
                LocalityTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[2].Value.ToString();
                StreetTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[3].Value.ToString();
                HousingNumberTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[4].Value.ToString();
                HomeNumberTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[5].Value.ToString();
                ApartmentNumberTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[6].Value.ToString();
                IndexTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[7].Value.ToString();
                PhoneNumberTB.Text = directorForm.StaffDepartmentDataGrid.Rows[choosenRow].Cells[8].Value.ToString();

                phoneNumber = PhoneNumberTB.Text;
            }

        }
    }
}
