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
    public partial class ChooseStaffDepartmentForm : Form
    {
        private SqlConnection connection;
        private FileForm fileForm;
        private AddPersonalFile addPersonalFileForm;
        private bool isAddingMode = false;
        public ChooseStaffDepartmentForm(SqlConnection connection, FileForm fileForm)
        {
            this.connection = connection;
            this.fileForm = fileForm;
            InitializeComponent();
        }

        public ChooseStaffDepartmentForm(SqlConnection connection, AddPersonalFile addPersonalFileForm)
        {
            this.connection = connection;
            this.addPersonalFileForm = addPersonalFileForm;
            isAddingMode = true;
            InitializeComponent();
        }

        private void ChooseStaffDepartmentForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Staff_Department", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            StaffDepartmentDGV.DataSource = ds.Tables[0];
        }

        private void StaffDepartmentDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string phoneNumber = StaffDepartmentDGV.Rows[e.RowIndex].Cells[9].Value.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT id_staff_department FROM Staff_Department WHERE phone_number = '{phoneNumber}'", 
                connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int idStaffDepartment = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (!isAddingMode)
            {
                fileForm.idStaffDepartment = idStaffDepartment;
                fileForm.UpdateSDInfo(idStaffDepartment);
            }
            else
            {
                addPersonalFileForm.idStaffDepartment = idStaffDepartment;
                addPersonalFileForm.UpdateSDInfo(idStaffDepartment);
            }
            this.Close();
        }
    }
}
