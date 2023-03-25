
namespace StaffDepartment
{
    partial class PersonalFileJournal
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
            this.JPersonalFileDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearJournalLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.JPersonalFileDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // JPersonalFileDGV
            // 
            this.JPersonalFileDGV.AllowUserToAddRows = false;
            this.JPersonalFileDGV.AllowUserToDeleteRows = false;
            this.JPersonalFileDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JPersonalFileDGV.Location = new System.Drawing.Point(12, 38);
            this.JPersonalFileDGV.Name = "JPersonalFileDGV";
            this.JPersonalFileDGV.Size = new System.Drawing.Size(786, 358);
            this.JPersonalFileDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Журнал изменений данных личных дел";
            // 
            // ClearJournalLink
            // 
            this.ClearJournalLink.AutoSize = true;
            this.ClearJournalLink.LinkColor = System.Drawing.Color.Black;
            this.ClearJournalLink.Location = new System.Drawing.Point(675, 9);
            this.ClearJournalLink.Name = "ClearJournalLink";
            this.ClearJournalLink.Size = new System.Drawing.Size(123, 17);
            this.ClearJournalLink.TabIndex = 2;
            this.ClearJournalLink.TabStop = true;
            this.ClearJournalLink.Text = "Очистить журнал";
            this.ClearJournalLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearJournalLink_LinkClicked);
            // 
            // PersonalFileJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 408);
            this.Controls.Add(this.ClearJournalLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JPersonalFileDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonalFileJournal";
            this.Text = "Журнал изменений";
            this.Load += new System.EventHandler(this.PersonalFileJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JPersonalFileDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JPersonalFileDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ClearJournalLink;
    }
}