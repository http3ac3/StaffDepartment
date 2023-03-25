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
    public partial class PersonalFileJournal : Form
    {
        SqlConnection connection;
        public PersonalFileJournal(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
        }

        private void PersonalFileJournal_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC JPersonalFileInfo", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            JPersonalFileDGV.DataSource = ds.Tables[0];
        }

        private void ClearJournalLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var res = MessageBox.Show("Вы уверены, что хотите полностью очистить журнал изменений?", "Очищение журнала", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                new SqlCommand("DELETE FROM JPersonal_File", connection).ExecuteNonQuery();
                MessageBox.Show("Журнал был успешно очищен!", "Очищение журнала", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
