
namespace StaffDepartment
{
    partial class FileEducationDiplomasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEducationDiplomasForm));
            this.EducationDiplomaDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EducationDiplomaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EducationDiplomaDataGrid
            // 
            this.EducationDiplomaDataGrid.AllowUserToAddRows = false;
            this.EducationDiplomaDataGrid.AllowUserToDeleteRows = false;
            this.EducationDiplomaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EducationDiplomaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EducationDiplomaDataGrid.Location = new System.Drawing.Point(12, 12);
            this.EducationDiplomaDataGrid.Name = "EducationDiplomaDataGrid";
            this.EducationDiplomaDataGrid.RowHeadersWidth = 51;
            this.EducationDiplomaDataGrid.Size = new System.Drawing.Size(847, 217);
            this.EducationDiplomaDataGrid.TabIndex = 0;
            // 
            // FileEducationDiplomasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 243);
            this.Controls.Add(this.EducationDiplomaDataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FileEducationDiplomasForm";
            this.Text = "Дипломы сотрудника : ";
            this.Load += new System.EventHandler(this.FileEducationDiplomasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EducationDiplomaDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EducationDiplomaDataGrid;
    }
}