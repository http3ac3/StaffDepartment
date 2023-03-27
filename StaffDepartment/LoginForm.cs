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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private enum Role
        {
            DIRECTOR,
            VISITOR
        }
        Role role;
        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"DESKTOP-QI4TJ5P",
                InitialCatalog = "Staff_Department_DB", //Database
                IntegratedSecurity = false,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = login,
                Password = password
            };
            return sqlString.ToString();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string connectionString = GetRemoteConnectionString(LoginTextBox.Text, PasswordTextBox.Text);
            //string connectionString = GetRemoteConnectionString("Abramov_Director", "123456");
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                if (Convert.ToInt32(new SqlCommand("SELECT IS_MEMBER('SD_Director')", connection).ExecuteScalar()) == 1)
                {
                    role = Role.DIRECTOR;
                }
                else if (Convert.ToInt32(new SqlCommand("SELECT IS_MEMBER('SD_Visitor')", connection).ExecuteScalar()) == 1)
                {
                    role = Role.VISITOR;
                }
                MessageBox.Show("Подключение установлено!");
            }
            catch
            {
                MessageBox.Show("Введеные логин и/или пароль неверные! Проверьте введенные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            switch (role)
            {
                case Role.DIRECTOR:
                    new DirectorForm(connection, this).Show();
                    this.Hide();
                    break;
                case Role.VISITOR:

                    break;
            }

        }
    }
}
