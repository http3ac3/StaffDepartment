
namespace StaffDepartment
{
    partial class DirectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EmployeeGroupsBox = new System.Windows.Forms.GroupBox();
            this.WaitingDismissalRadioButton = new System.Windows.Forms.RadioButton();
            this.WaitingAcceptingRadioButton = new System.Windows.Forms.RadioButton();
            this.WorkingRadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.PFDataGridPanel = new System.Windows.Forms.Panel();
            this.PersonalFileDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ControlDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.регистрацияПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.EmployeeGroupsBox.SuspendLayout();
            this.PFDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalFileDataGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 509);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EmployeeGroupsBox);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.InsertButton);
            this.tabPage1.Controls.Add(this.PFDataGridPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(923, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личные дела";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EmployeeGroupsBox
            // 
            this.EmployeeGroupsBox.Controls.Add(this.WaitingDismissalRadioButton);
            this.EmployeeGroupsBox.Controls.Add(this.WaitingAcceptingRadioButton);
            this.EmployeeGroupsBox.Controls.Add(this.WorkingRadioButton);
            this.EmployeeGroupsBox.Location = new System.Drawing.Point(8, 136);
            this.EmployeeGroupsBox.Name = "EmployeeGroupsBox";
            this.EmployeeGroupsBox.Size = new System.Drawing.Size(261, 105);
            this.EmployeeGroupsBox.TabIndex = 4;
            this.EmployeeGroupsBox.TabStop = false;
            this.EmployeeGroupsBox.Text = "Группы сотрудников";
            // 
            // WaitingDismissalRadioButton
            // 
            this.WaitingDismissalRadioButton.AutoSize = true;
            this.WaitingDismissalRadioButton.Location = new System.Drawing.Point(7, 78);
            this.WaitingDismissalRadioButton.Name = "WaitingDismissalRadioButton";
            this.WaitingDismissalRadioButton.Size = new System.Drawing.Size(188, 21);
            this.WaitingDismissalRadioButton.TabIndex = 0;
            this.WaitingDismissalRadioButton.TabStop = true;
            this.WaitingDismissalRadioButton.Text = "Ожидающие увольнения";
            this.WaitingDismissalRadioButton.UseVisualStyleBackColor = true;
            this.WaitingDismissalRadioButton.CheckedChanged += new System.EventHandler(this.WaitingDismissalRadioButton_CheckedChanged);
            // 
            // WaitingAcceptingRadioButton
            // 
            this.WaitingAcceptingRadioButton.AutoSize = true;
            this.WaitingAcceptingRadioButton.Location = new System.Drawing.Point(7, 51);
            this.WaitingAcceptingRadioButton.Name = "WaitingAcceptingRadioButton";
            this.WaitingAcceptingRadioButton.Size = new System.Drawing.Size(244, 21);
            this.WaitingAcceptingRadioButton.TabIndex = 0;
            this.WaitingAcceptingRadioButton.TabStop = true;
            this.WaitingAcceptingRadioButton.Text = "Ожидающие принятия на работу";
            this.WaitingAcceptingRadioButton.UseVisualStyleBackColor = true;
            this.WaitingAcceptingRadioButton.CheckedChanged += new System.EventHandler(this.WaitingAcceptingRadioButton_CheckedChanged);
            // 
            // WorkingRadioButton
            // 
            this.WorkingRadioButton.AutoSize = true;
            this.WorkingRadioButton.Location = new System.Drawing.Point(7, 24);
            this.WorkingRadioButton.Name = "WorkingRadioButton";
            this.WorkingRadioButton.Size = new System.Drawing.Size(111, 21);
            this.WorkingRadioButton.TabIndex = 0;
            this.WorkingRadioButton.TabStop = true;
            this.WorkingRadioButton.Text = "Работающие";
            this.WorkingRadioButton.UseVisualStyleBackColor = true;
            this.WorkingRadioButton.CheckedChanged += new System.EventHandler(this.WorkingRadioButton_CheckedChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(5, 86);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(264, 43);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(5, 37);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(264, 43);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Добавить запись";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // PFDataGridPanel
            // 
            this.PFDataGridPanel.Controls.Add(this.PersonalFileDataGrid);
            this.PFDataGridPanel.Controls.Add(this.label1);
            this.PFDataGridPanel.Location = new System.Drawing.Point(275, 0);
            this.PFDataGridPanel.Name = "PFDataGridPanel";
            this.PFDataGridPanel.Size = new System.Drawing.Size(640, 473);
            this.PFDataGridPanel.TabIndex = 2;
            // 
            // PersonalFileDataGrid
            // 
            this.PersonalFileDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonalFileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalFileDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalFileDataGrid.Location = new System.Drawing.Point(0, 37);
            this.PersonalFileDataGrid.Name = "PersonalFileDataGrid";
            this.PersonalFileDataGrid.RowTemplate.Height = 24;
            this.PersonalFileDataGrid.Size = new System.Drawing.Size(640, 436);
            this.PersonalFileDataGrid.TabIndex = 0;
            this.PersonalFileDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PersonalFileDataGrid_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица личных дел сотрудников";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Должности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(931, 26);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ControlDropDownButton
            // 
            this.ControlDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ControlDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияПользователяToolStripMenuItem});
            this.ControlDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ControlDropDownButton.Image")));
            this.ControlDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ControlDropDownButton.Name = "ControlDropDownButton";
            this.ControlDropDownButton.Size = new System.Drawing.Size(97, 23);
            this.ControlDropDownButton.Text = "Управление";
            // 
            // регистрацияПользователяToolStripMenuItem
            // 
            this.регистрацияПользователяToolStripMenuItem.Name = "регистрацияПользователяToolStripMenuItem";
            this.регистрацияПользователяToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.регистрацияПользователяToolStripMenuItem.Text = "Регистрация пользователя";
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 535);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DirectorForm";
            this.Text = "Отдел кадров: Директор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorForm_FormClosing);
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.EmployeeGroupsBox.ResumeLayout(false);
            this.EmployeeGroupsBox.PerformLayout();
            this.PFDataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalFileDataGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox EmployeeGroupsBox;
        private System.Windows.Forms.RadioButton WaitingDismissalRadioButton;
        private System.Windows.Forms.RadioButton WaitingAcceptingRadioButton;
        private System.Windows.Forms.RadioButton WorkingRadioButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Panel PFDataGridPanel;
        private System.Windows.Forms.DataGridView PersonalFileDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ControlDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem регистрацияПользователяToolStripMenuItem;
    }
}