
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
            this.DeletePostButton = new System.Windows.Forms.Button();
            this.AddPostButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PostDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteWDButton = new System.Windows.Forms.Button();
            this.AddWDButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WDDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DeletePromotionButton = new System.Windows.Forms.Button();
            this.AddPromotionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PromotionDataGrid = new System.Windows.Forms.DataGridView();
            this.ControlDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.RegisterUserButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalFileJournalButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.EmployeeGroupsBox.SuspendLayout();
            this.PFDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalFileDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WDDataGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromotionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.PersonalFileDataGrid.AllowUserToAddRows = false;
            this.PersonalFileDataGrid.AllowUserToDeleteRows = false;
            this.PersonalFileDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonalFileDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalFileDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalFileDataGrid.Location = new System.Drawing.Point(0, 37);
            this.PersonalFileDataGrid.Name = "PersonalFileDataGrid";
            this.PersonalFileDataGrid.RowTemplate.Height = 24;
            this.PersonalFileDataGrid.Size = new System.Drawing.Size(640, 436);
            this.PersonalFileDataGrid.TabIndex = 0;
            this.PersonalFileDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonalFileDataGrid_CellClick);
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
            this.tabPage2.Controls.Add(this.DeletePostButton);
            this.tabPage2.Controls.Add(this.AddPostButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.PostDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Должности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeletePostButton
            // 
            this.DeletePostButton.Enabled = false;
            this.DeletePostButton.Location = new System.Drawing.Point(6, 83);
            this.DeletePostButton.Name = "DeletePostButton";
            this.DeletePostButton.Size = new System.Drawing.Size(264, 43);
            this.DeletePostButton.TabIndex = 4;
            this.DeletePostButton.Text = "Удалить запись";
            this.DeletePostButton.UseVisualStyleBackColor = true;
            this.DeletePostButton.Click += new System.EventHandler(this.DeletePostButton_Click);
            // 
            // AddPostButton
            // 
            this.AddPostButton.Location = new System.Drawing.Point(6, 34);
            this.AddPostButton.Name = "AddPostButton";
            this.AddPostButton.Size = new System.Drawing.Size(264, 43);
            this.AddPostButton.TabIndex = 5;
            this.AddPostButton.Text = "Добавить запись";
            this.AddPostButton.UseVisualStyleBackColor = true;
            this.AddPostButton.Click += new System.EventHandler(this.AddPostButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблица должностей";
            // 
            // PostDataGridView
            // 
            this.PostDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostDataGridView.Location = new System.Drawing.Point(276, 34);
            this.PostDataGridView.Name = "PostDataGridView";
            this.PostDataGridView.Size = new System.Drawing.Size(639, 437);
            this.PostDataGridView.TabIndex = 0;
            this.PostDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PostDataGridView_CellClick);
            this.PostDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PostDataGridView_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeleteWDButton);
            this.tabPage3.Controls.Add(this.AddWDButton);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.WDDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(923, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Рабочие отделы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeleteWDButton
            // 
            this.DeleteWDButton.Enabled = false;
            this.DeleteWDButton.Location = new System.Drawing.Point(6, 83);
            this.DeleteWDButton.Name = "DeleteWDButton";
            this.DeleteWDButton.Size = new System.Drawing.Size(264, 43);
            this.DeleteWDButton.TabIndex = 6;
            this.DeleteWDButton.Text = "Удалить запись";
            this.DeleteWDButton.UseVisualStyleBackColor = true;
            this.DeleteWDButton.Click += new System.EventHandler(this.DeleteWDButton_Click);
            // 
            // AddWDButton
            // 
            this.AddWDButton.Location = new System.Drawing.Point(6, 34);
            this.AddWDButton.Name = "AddWDButton";
            this.AddWDButton.Size = new System.Drawing.Size(264, 43);
            this.AddWDButton.TabIndex = 7;
            this.AddWDButton.Text = "Добавить запись";
            this.AddWDButton.UseVisualStyleBackColor = true;
            this.AddWDButton.Click += new System.EventHandler(this.AddWDButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Таблица рабочих отделов";
            // 
            // WDDataGrid
            // 
            this.WDDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WDDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WDDataGrid.Location = new System.Drawing.Point(276, 34);
            this.WDDataGrid.Name = "WDDataGrid";
            this.WDDataGrid.Size = new System.Drawing.Size(639, 437);
            this.WDDataGrid.TabIndex = 2;
            this.WDDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WDDataGrid_CellClick);
            this.WDDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WDDataGrid_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DeletePromotionButton);
            this.tabPage4.Controls.Add(this.AddPromotionButton);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.PromotionDataGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(923, 479);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Поощрения";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(923, 479);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Взыскания";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // DeletePromotionButton
            // 
            this.DeletePromotionButton.Enabled = false;
            this.DeletePromotionButton.Location = new System.Drawing.Point(7, 80);
            this.DeletePromotionButton.Name = "DeletePromotionButton";
            this.DeletePromotionButton.Size = new System.Drawing.Size(264, 43);
            this.DeletePromotionButton.TabIndex = 10;
            this.DeletePromotionButton.Text = "Удалить запись";
            this.DeletePromotionButton.UseVisualStyleBackColor = true;
            this.DeletePromotionButton.Click += new System.EventHandler(this.DeletePromotionButton_Click);
            // 
            // AddPromotionButton
            // 
            this.AddPromotionButton.Location = new System.Drawing.Point(7, 31);
            this.AddPromotionButton.Name = "AddPromotionButton";
            this.AddPromotionButton.Size = new System.Drawing.Size(264, 43);
            this.AddPromotionButton.TabIndex = 11;
            this.AddPromotionButton.Text = "Добавить запись";
            this.AddPromotionButton.UseVisualStyleBackColor = true;
            this.AddPromotionButton.Click += new System.EventHandler(this.AddPromotionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Таблица поощрений сотрудников";
            // 
            // PromotionDataGrid
            // 
            this.PromotionDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PromotionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PromotionDataGrid.Location = new System.Drawing.Point(277, 31);
            this.PromotionDataGrid.Name = "PromotionDataGrid";
            this.PromotionDataGrid.Size = new System.Drawing.Size(639, 437);
            this.PromotionDataGrid.TabIndex = 8;
            this.PromotionDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PromotionDataGrid_CellClick);
            // 
            // ControlDropDownButton
            // 
            this.ControlDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ControlDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterUserButton,
            this.PersonalFileJournalButton});
            this.ControlDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("ControlDropDownButton.Image")));
            this.ControlDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ControlDropDownButton.Name = "ControlDropDownButton";
            this.ControlDropDownButton.Size = new System.Drawing.Size(97, 23);
            this.ControlDropDownButton.Text = "Управление";
            // 
            // RegisterUserButton
            // 
            this.RegisterUserButton.Name = "RegisterUserButton";
            this.RegisterUserButton.Size = new System.Drawing.Size(278, 24);
            this.RegisterUserButton.Text = "Регистрация пользователя";
            // 
            // PersonalFileJournalButton
            // 
            this.PersonalFileJournalButton.Name = "PersonalFileJournalButton";
            this.PersonalFileJournalButton.Size = new System.Drawing.Size(278, 24);
            this.PersonalFileJournalButton.Text = "Журнал изменений личных дел";
            this.PersonalFileJournalButton.Click += new System.EventHandler(this.PersonalFileJournalButton_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WDDataGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PromotionDataGrid)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem RegisterUserButton;
        private System.Windows.Forms.ToolStripMenuItem PersonalFileJournalButton;
        private System.Windows.Forms.Button DeletePostButton;
        private System.Windows.Forms.Button AddPostButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PostDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button DeleteWDButton;
        private System.Windows.Forms.Button AddWDButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView WDDataGrid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button DeletePromotionButton;
        private System.Windows.Forms.Button AddPromotionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView PromotionDataGrid;
    }
}