
namespace StaffDepartment
{
    partial class ChooseStaffDepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.StaffDepartmentDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDepartmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите отдел кадров ";
            // 
            // StaffDepartmentDGV
            // 
            this.StaffDepartmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDepartmentDGV.Location = new System.Drawing.Point(12, 33);
            this.StaffDepartmentDGV.Name = "StaffDepartmentDGV";
            this.StaffDepartmentDGV.Size = new System.Drawing.Size(762, 472);
            this.StaffDepartmentDGV.TabIndex = 1;
            this.StaffDepartmentDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDepartmentDGV_CellDoubleClick);
            // 
            // ChooseStaffDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 517);
            this.Controls.Add(this.StaffDepartmentDGV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ChooseStaffDepartmentForm";
            this.Text = "Изменение привязанного отдела кадров";
            this.Load += new System.EventHandler(this.ChooseStaffDepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDepartmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StaffDepartmentDGV;
    }
}