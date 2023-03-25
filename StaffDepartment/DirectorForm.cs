﻿using System;
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
        public DataSet GetFilledDataSet(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public void RefreshPersonalFileDataGrid()
        {
            PersonalFileDataGrid.DataSource = GetFilledDataSet("EXEC FileOnPosts").Tables[0];
            WorkingRadioButton.Checked = true;
        }
        public void RefreshPostDataGrid() =>
            PostDataGridView.DataSource = GetFilledDataSet("SELECT 'Должность' = post_name, 'З/п, руб.' = salary, 'Надбавка' = rise FROM Post").Tables[0];

        public void RefreshWDDataGrid() =>
            WDDataGrid.DataSource = GetFilledDataSet("SELECT 'Рабочий отдел' = work_department_name FROM Work_Department").Tables[0];
        
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
            RefreshPersonalFileDataGrid();
            RefreshPostDataGrid();
            RefreshWDDataGrid();
        }

        private void WaitingAcceptingRadioButton_CheckedChanged(object sender, EventArgs e) =>
            PersonalFileDataGrid.DataSource = GetFilledDataSet("EXEC FileWaitAccept").Tables[0];
        
        private void WaitingDismissalRadioButton_CheckedChanged(object sender, EventArgs e) =>
            PersonalFileDataGrid.DataSource = GetFilledDataSet("EXEC FileWaitDissmissal").Tables[0];
        
        private void WorkingRadioButton_CheckedChanged(object sender, EventArgs e) =>
            PersonalFileDataGrid.DataSource = GetFilledDataSet("EXEC FileOnPosts").Tables[0];
        
        private void PersonalFileDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string wb_series = PersonalFileDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            string wb_number = PersonalFileDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            new FileForm(wb_series, wb_number, connection, this).Show();
        }

        private void InsertButton_Click(object sender, EventArgs e) => new AddPersonalFile(connection, this).Show();
        
        private void PersonalFileJournalButton_Click(object sender, EventArgs e) => new PersonalFileJournal(connection).Show();

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
                DeleteButton.Enabled = false;
            }
        }

        private void AddPostButton_Click(object sender, EventArgs e) => new AddPostForm(connection, this, false).Show();

        private void PostDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeletePostButton.Enabled = true;
            deleteRowIndex = e.RowIndex;
        }

        private void DeletePostButton_Click(object sender, EventArgs e)
        {
            string postName = PostDataGridView.Rows[deleteRowIndex].Cells[0].Value.ToString();
            var res = MessageBox.Show($"Вы действительно хотите удалить должность {postName}?", "Удаление должности",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                try
                {
                    new SqlCommand($"DELETE FROM Post WHERE post_name = '{postName}'", connection).ExecuteNonQuery();
                    MessageBox.Show($"Должность {postName} была успешно удалена!", "Удаление должности",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RefreshPostDataGrid();
                }
                catch
                {
                    MessageBox.Show("На данную должность уже назначен сотрудник/и! Прежде чем удалять ее, назначьте всем ее владельцам новую должность",
                        "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DeletePostButton.Enabled = false;
            }
        }

        private void PostDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) =>
            new AddPostForm(connection, this, true, 
                PostDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                Convert.ToDecimal(PostDataGridView.Rows[e.RowIndex].Cells[1].Value),
                Convert.ToDecimal(PostDataGridView.Rows[e.RowIndex].Cells[2].Value) * 100 % 100)
            .Show();

        private void AddWDButton_Click(object sender, EventArgs e) => new AddWDForm(connection, this, false, "").Show();

        private void WDDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) =>
            new AddWDForm(connection, this, true,
                WDDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();

        private void WDDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteRowIndex = e.RowIndex;
            DeleteWDButton.Enabled = true;
        }

        private void DeleteWDButton_Click(object sender, EventArgs e)
        {
            string wdName = WDDataGrid.Rows[deleteRowIndex].Cells[0].Value.ToString();
            var res = MessageBox.Show($"Вы действительно хотите удалить рабочий отдел {wdName}?", "Удаление данных",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                try
                {
                    new SqlCommand($"DELETE FROM Work_Department WHERE work_department_name = '{wdName}'", connection).ExecuteNonQuery();
                    MessageBox.Show($"Рабочий отдел {wdName} был успешно удален!", "Удаление рабочего отдела",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RefreshWDDataGrid();
                    
                }
                catch
                {
                    MessageBox.Show("В данном отделе уже работают сотрудники! Прежде чем удалять его, назначьте всем тем, кто там работает," +
                        " новые отделы", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DeleteWDButton.Enabled = false;
        }
    }
}
