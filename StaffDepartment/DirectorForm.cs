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
    public partial class DirectorForm : Form
    {
        private SqlConnection connection;
        private LoginForm loginForm;
        private int deleteRowIndex;
        public DirectorForm(SqlConnection connection, LoginForm loginForm)
        {
            this.connection = connection;
            this.loginForm = loginForm;
            InitializeComponent();
            WorkingRadioButton.Checked = true;
        }

        public void RefreshPersonalFileDataGrid()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC FileOnPosts", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            PersonalFileDataGrid.DataSource = dataSet.Tables[0];
            WorkingRadioButton.Checked = true;
        }
        private void DirectorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из системы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loginForm.Close();
                connection.Close();
            }
            else
                e.Cancel = true;
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            // SqlCommand command = new SqlCommand(, connection);
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC FileOnPosts", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            PersonalFileDataGrid.DataSource = dataSet.Tables[0];
        }

        private void WaitingAcceptingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC FileWaitAccept", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            PersonalFileDataGrid.DataSource = dataSet.Tables[0];
        }

        private void WaitingDismissalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC FileWaitDissmissal", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            PersonalFileDataGrid.DataSource = dataSet.Tables[0];
        }

        private void WorkingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC FileOnPosts", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            PersonalFileDataGrid.DataSource = dataSet.Tables[0];
        }

        private void PersonalFileDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string wb_series = PersonalFileDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string wb_number = PersonalFileDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            new FileForm(wb_series, wb_number, connection, this).Show();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            new AddPersonalFile(connection, this).Show();
        }

        private void PersonalFileJournalButton_Click(object sender, EventArgs e)
        {
            new PersonalFileJournal(connection).Show();
        }

        private void PersonalFileDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton.Enabled = true;
            deleteRowIndex = e.RowIndex;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string lastName = PersonalFileDataGrid.Rows[deleteRowIndex].Cells[0].Value.ToString();
            string firstName = PersonalFileDataGrid.Rows[deleteRowIndex].Cells[1].Value.ToString();
            var res = MessageBox.Show($"Вы действительно хотите удалить личное дело об {lastName} {firstName}?", "Удаление данных", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                string wbSeries = PersonalFileDataGrid.Rows[deleteRowIndex].Cells[3].Value.ToString();
                string wbNumber = PersonalFileDataGrid.Rows[deleteRowIndex].Cells[4].Value.ToString();

                new SqlCommand($"DELETE FROM Personal_File WHERE wb_series = '{wbSeries}' AND wb_number = '{wbNumber}'", connection).ExecuteNonQuery();
                MessageBox.Show($"Данные об {lastName} {firstName} были успешно удалены! Удаленная информация находится в журнале изменений личных дел", 
                    "Удаление личного дела", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                RefreshPersonalFileDataGrid();
            }
        }
    }
}
