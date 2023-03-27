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

        public void RefreshPromotionDataGrid() =>
            PromotionDataGrid.DataSource = GetFilledDataSet("EXEC PromotionsInfo").Tables[0];

        public void RefreshDiscActionsDataGrid() =>
            DiscActionsDataGrid.DataSource = GetFilledDataSet("EXEC DiscActionsInfo").Tables[0];

        public void RefreshStaffDepartmentDataGrid() =>
            StaffDepartmentDataGrid.DataSource = GetFilledDataSet("EXEC StaffDepartmentsInfo").Tables[0];

        public void RefreshDiplomaDataGrid() =>
            DiplomaDataGrid.DataSource = GetFilledDataSet("EXEC EducationDiplomasInfo").Tables[0];
        
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
            RefreshPromotionDataGrid();
            RefreshDiscActionsDataGrid();
            RefreshStaffDepartmentDataGrid();
            RefreshDiplomaDataGrid();
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
            }
            DeleteButton.Enabled = false;
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

        private void AddPromotionButton_Click(object sender, EventArgs e) =>
            new AddPromotionForm(connection, this, false, 0, false).Show();
        

        private void PromotionDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeletePromotionButton.Enabled = true;
            deleteRowIndex = e.RowIndex;
        }

        private void DeletePromotionButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите удалить запись о поощрении? У сотрудников, кому оно назначено, она также исчезнет", 
                "Удаление поощрения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            string idPromotion = PromotionDataGrid.Rows[deleteRowIndex].Cells[0].Value.ToString();

            string[] filesId = new string[int.Parse(PromotionDataGrid.Rows[deleteRowIndex].Cells[3].Value.ToString())];
            DataSet filesIdDataSet = GetFilledDataSet($"GetFileByPromotion {idPromotion}");

            for (int i = 0; i < filesIdDataSet.Tables[0].Rows.Count; i++)
                filesId[i] = filesIdDataSet.Tables[0].Rows[i][0].ToString();
            
            if (res == DialogResult.Yes)
            {
                new SqlCommand($"DELETE FROM Personal_File_Promotion WHERE id_promotion = {idPromotion}", connection).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Promotion WHERE id_promotion = {idPromotion}", connection).ExecuteNonQuery();
                MessageBox.Show("Данные об поощрении были успешно удалены", "Удаление поощрения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPromotionDataGrid();
            }
        }

        private void AddDiscActionButton_Click(object sender, EventArgs e) =>
            new AddPromotionForm(connection, this, false, 0, true).Show();

        private void DiscActionsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteDiscActionButton.Enabled = true;
            deleteRowIndex = e.RowIndex;
        }

        private void DeleteDiscActionButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите удалить запись о взыскании? У сотрудников, кому оно назначено, оно также исчезнет",
                "Удаление взыскания", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            string idDiscAction = DiscActionsDataGrid.Rows[deleteRowIndex].Cells[0].Value.ToString();
            if (res == DialogResult.Yes)
            {
                new SqlCommand($"DELETE FROM Personal_File_Disciplinary_Action WHERE id_action = {idDiscAction}", connection).ExecuteNonQuery();
                new SqlCommand($"DELETE FROM Disciplinary_Action WHERE id_action = {idDiscAction}", connection).ExecuteNonQuery();
                MessageBox.Show("Данные о взыскании были успешно удалены", "Удаление взыскания", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDiscActionsDataGrid();
            }
            DeleteDiscActionButton.Enabled = false;
        }

        private void AddSDButton_Click(object sender, EventArgs e) =>
            new AddStaffDepartmentForm(connection, this, false, 0).Show();
        private void StaffDepartmentDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteRowIndex = e.RowIndex;
            DeleteSDButton.Enabled = true;
        }

        private void DeleteSDButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = StaffDepartmentDataGrid.Rows[deleteRowIndex].Cells[8].Value.ToString();
            var res = MessageBox.Show("Вы действительно хотите удалить выбранный отдел кадров?", "Удаление отдела кадров", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                try
                {
                    new SqlCommand($"DELETE FROM Staff_Department WHERE phone_number = '{phoneNumber}'", connection).ExecuteNonQuery();
                    MessageBox.Show("Запись была успешно удалена", "Удаление отдела кадров", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshStaffDepartmentDataGrid();
                }
                catch
                {
                    MessageBox.Show("Прежде чем удалить выбранный отдел кадров, назначьте привязанных к нему сотрудников в новый", 
                        "Ошибка удаления отдела кадров", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DeleteSDButton.Enabled = false;
        }

        private void StaffDepartmentDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) =>
            new AddStaffDepartmentForm(connection, this, true, e.RowIndex).Show();

        private void AddDiplomaButton_Click(object sender, EventArgs e) =>
            new AddDiplomaForm(connection, this, false, "", "").Show();

        private void DiplomaDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteDiplomaButton.Enabled = true;
            deleteRowIndex = e.RowIndex;
        }

        private void DeleteDiplomaButton_Click(object sender, EventArgs e)
        {
            string diplomaSeries = DiplomaDataGrid.Rows[deleteRowIndex].Cells[2].Value.ToString();
            string diplomaNumber = DiplomaDataGrid.Rows[deleteRowIndex].Cells[3].Value.ToString();

            var res = MessageBox.Show("Вы действительно хотите удалить выбранный диплом? У сотрудника, который его подал, он также будет удален",
                "Удаление диплома", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                try
                {
                    new SqlCommand($"DELETE FROM Education_Diploma WHERE diploma_series = '{diplomaSeries}' AND diploma_number = '{diplomaNumber}'",
                        connection).ExecuteNonQuery();
                    MessageBox.Show("Запись была успешно удалена", "Удаление дпилома", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDiplomaDataGrid();
                }
                catch
                { }
            }
            DeleteSDButton.Enabled = false;
        }

        private void DiplomaDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) =>
            new AddDiplomaForm(connection, this, true,
                DiplomaDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString(),
                DiplomaDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString()).Show();
    }
}
