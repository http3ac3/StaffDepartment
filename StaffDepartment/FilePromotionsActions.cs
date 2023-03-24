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
    public partial class FilePromotionsActions : Form
    {
        private string FIO; 
        private SqlConnection connection; 
        private string wb_series; 
        private string wb_number;
        private bool isPromotions;
        public FilePromotionsActions(string FIO, SqlConnection connection, string wb_series, string wb_number, bool isPromotions)
        {
            this.FIO = FIO; this.connection = connection; 
            this.wb_series = wb_series; 
            this.wb_number = wb_number;
            this.isPromotions = isPromotions;
            InitializeComponent();
            if (isPromotions)
            {
                this.Text = "Поощрения: " + FIO;
                label1.Text = "Таблица поощрений сотрудника: " + FIO;
            }
            else
            {
                this.Text = "Выговоры: " + FIO;
                label1.Text = "Таблица выговоров сотрудника: " + FIO;
            }
        }

        private void FilePromotionsActions_Load(object sender, EventArgs e)
        {
            if (isPromotions)
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC FilePromotions '{wb_series}', '{wb_number}'", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ActionsDGV.DataSource = ds.Tables[0];
            }  
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC FileDisciplinaryActions '{wb_series}', '{wb_number}'", connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ActionsDGV.DataSource = ds.Tables[0];
            }
        }
    }
}
