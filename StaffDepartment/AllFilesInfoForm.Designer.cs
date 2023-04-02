
namespace StaffDepartment
{
    partial class AllFilesInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllFilesInfoForm));
            this.PersonalFileDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalFileDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalFileDataGrid
            // 
            this.PersonalFileDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonalFileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalFileDataGrid.Location = new System.Drawing.Point(12, 12);
            this.PersonalFileDataGrid.Name = "PersonalFileDataGrid";
            this.PersonalFileDataGrid.RowHeadersWidth = 51;
            this.PersonalFileDataGrid.Size = new System.Drawing.Size(695, 408);
            this.PersonalFileDataGrid.TabIndex = 0;
            this.PersonalFileDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonalFileDataGrid_CellDoubleClick);
            // 
            // AllFilesInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 430);
            this.Controls.Add(this.PersonalFileDataGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "AllFilesInfoForm";
            this.Text = "Выбор личного дела";
            this.Load += new System.EventHandler(this.AllFilesInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalFileDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonalFileDataGrid;
    }
}