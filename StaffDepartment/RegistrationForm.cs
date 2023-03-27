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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"DESKTOP-QI4TJ5P",
                InitialCatalog = "Staff_Department_DB", //Database
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = login,
                Password = password
            };
            return sqlString.ToString();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SqlConnection regConnection = new SqlConnection(GetRemoteConnectionString("", ""));
            regConnection.Open();
            MessageBox.Show(PasswordTB.Text);
            new SqlCommand($"EXEC sp_addlogin '{LoginNameTB.Text}', '{PasswordTB.Text}', 'Staff_Department_DB'", regConnection).ExecuteNonQuery();
            new SqlCommand($"USE Staff_Department_DB", regConnection).ExecuteNonQuery();
            new SqlCommand($"EXEC sp_adduser '{LoginNameTB.Text}', '{LoginNameTB.Text}'", regConnection).ExecuteNonQuery();

            if (DirectorRadioButton.Checked)
                new SqlCommand($"EXEC sp_addrolemember 'SD_Director', '{LoginNameTB.Text}'", regConnection).ExecuteNonQuery();
            else
                new SqlCommand($"EXEC sp_addrolemember 'SD_Visitor', '{LoginNameTB.Text}'", regConnection).ExecuteNonQuery();

            MessageBox.Show($"Новый пользователь {LoginNameTB.Text} успешно добавлен", "Регистрация пользователя", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            regConnection.Close();
            this.Close();
        }
    }
}
