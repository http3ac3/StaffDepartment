
namespace StaffDepartment
{
    partial class PersonalFileInfoForm
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
            this.PersonalFileDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalFileDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalFileDataGrid
            // 
            this.PersonalFileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalFileDataGrid.Location = new System.Drawing.Point(12, 33);
            this.PersonalFileDataGrid.Name = "PersonalFileDataGrid";
            this.PersonalFileDataGrid.Size = new System.Drawing.Size(652, 396);
            this.PersonalFileDataGrid.TabIndex = 0;
            this.PersonalFileDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonalFileDataGrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите сотрудника двойным щелчком мыши";
            // 
            // PersonalFileInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonalFileDataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonalFileInfoForm";
            this.Text = "Таблица личных дел сотрудников";
            this.Load += new System.EventHandler(this.PersonalFileInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalFileDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonalFileDataGrid;
        private System.Windows.Forms.Label label1;
    }
}