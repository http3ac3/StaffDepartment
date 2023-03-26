
namespace StaffDepartment
{
    partial class AddPromotionForm
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
            this.PromotionTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PromotionDateTB = new System.Windows.Forms.MaskedTextBox();
            this.ReasonTB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPromotionButton = new System.Windows.Forms.Button();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.AddEmployeeLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип поощрения";
            // 
            // PromotionTypeCB
            // 
            this.PromotionTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PromotionTypeCB.FormattingEnabled = true;
            this.PromotionTypeCB.Items.AddRange(new object[] {
            "премия",
            "благодарность",
            "подарок",
            "почетная грамота"});
            this.PromotionTypeCB.Location = new System.Drawing.Point(147, 10);
            this.PromotionTypeCB.Name = "PromotionTypeCB";
            this.PromotionTypeCB.Size = new System.Drawing.Size(190, 25);
            this.PromotionTypeCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата поощрения";
            // 
            // PromotionDateTB
            // 
            this.PromotionDateTB.Location = new System.Drawing.Point(147, 48);
            this.PromotionDateTB.Mask = "00-00-0000";
            this.PromotionDateTB.Name = "PromotionDateTB";
            this.PromotionDateTB.Size = new System.Drawing.Size(190, 23);
            this.PromotionDateTB.TabIndex = 2;
            // 
            // ReasonTB
            // 
            this.ReasonTB.Location = new System.Drawing.Point(16, 105);
            this.ReasonTB.Name = "ReasonTB";
            this.ReasonTB.Size = new System.Drawing.Size(507, 125);
            this.ReasonTB.TabIndex = 3;
            this.ReasonTB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Опишите причину поощрения";
            // 
            // AddPromotionButton
            // 
            this.AddPromotionButton.Location = new System.Drawing.Point(114, 412);
            this.AddPromotionButton.Name = "AddPromotionButton";
            this.AddPromotionButton.Size = new System.Drawing.Size(316, 28);
            this.AddPromotionButton.TabIndex = 8;
            this.AddPromotionButton.Text = "Добавить поощрение";
            this.AddPromotionButton.UseVisualStyleBackColor = true;
            this.AddPromotionButton.Click += new System.EventHandler(this.AddPromotionButton_Click);
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.AllowUserToAddRows = false;
            this.EmployeesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(16, 256);
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.Size = new System.Drawing.Size(507, 150);
            this.EmployeesDataGrid.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сотрудники, которым будет назначено поощрение";
            // 
            // AddEmployeeLink
            // 
            this.AddEmployeeLink.AutoSize = true;
            this.AddEmployeeLink.LinkColor = System.Drawing.Color.Black;
            this.AddEmployeeLink.Location = new System.Drawing.Point(451, 236);
            this.AddEmployeeLink.Name = "AddEmployeeLink";
            this.AddEmployeeLink.Size = new System.Drawing.Size(72, 17);
            this.AddEmployeeLink.TabIndex = 10;
            this.AddEmployeeLink.TabStop = true;
            this.AddEmployeeLink.Text = "Добавить";
            this.AddEmployeeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddEmployeeLink_LinkClicked);
            // 
            // AddPromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 446);
            this.Controls.Add(this.AddEmployeeLink);
            this.Controls.Add(this.EmployeesDataGrid);
            this.Controls.Add(this.AddPromotionButton);
            this.Controls.Add(this.ReasonTB);
            this.Controls.Add(this.PromotionDateTB);
            this.Controls.Add(this.PromotionTypeCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPromotionForm";
            this.Text = "Добавление поощрения";
            this.Load += new System.EventHandler(this.AddPromotionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PromotionTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PromotionDateTB;
        private System.Windows.Forms.RichTextBox ReasonTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPromotionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel AddEmployeeLink;
        public System.Windows.Forms.DataGridView EmployeesDataGrid;
    }
}