
namespace StaffDepartment
{
    partial class AddDiplomaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiplomaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.EduOrganizationNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EduLevelCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EduDegreeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiplomaSeriesTB = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DiplomaNumberTB = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IssueDateTB = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpecialityTB = new System.Windows.Forms.TextBox();
            this.SetPersonalFileButton = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.FioTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WBSeriesTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.WBNumberTB = new System.Windows.Forms.TextBox();
            this.AddDiplomaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название учебной организации";
            // 
            // EduOrganizationNameTB
            // 
            this.EduOrganizationNameTB.Location = new System.Drawing.Point(238, 10);
            this.EduOrganizationNameTB.Name = "EduOrganizationNameTB";
            this.EduOrganizationNameTB.Size = new System.Drawing.Size(292, 27);
            this.EduOrganizationNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Уровень образования";
            // 
            // EduLevelCB
            // 
            this.EduLevelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EduLevelCB.FormattingEnabled = true;
            this.EduLevelCB.Items.AddRange(new object[] {
            "основное общее образование",
            "среднее общее образование",
            "среднее профессиональное образование",
            "высшее образование"});
            this.EduLevelCB.Location = new System.Drawing.Point(175, 41);
            this.EduLevelCB.Name = "EduLevelCB";
            this.EduLevelCB.Size = new System.Drawing.Size(355, 28);
            this.EduLevelCB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Степень образования";
            // 
            // EduDegreeCB
            // 
            this.EduDegreeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EduDegreeCB.FormattingEnabled = true;
            this.EduDegreeCB.Items.AddRange(new object[] {
            "бакалавр",
            "аспирант",
            "магистр",
            "специалист",
            "не указано"});
            this.EduDegreeCB.Location = new System.Drawing.Point(175, 72);
            this.EduDegreeCB.Name = "EduDegreeCB";
            this.EduDegreeCB.Size = new System.Drawing.Size(355, 28);
            this.EduDegreeCB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Серия диплома";
            // 
            // DiplomaSeriesTB
            // 
            this.DiplomaSeriesTB.Location = new System.Drawing.Point(126, 132);
            this.DiplomaSeriesTB.Mask = "000000";
            this.DiplomaSeriesTB.Name = "DiplomaSeriesTB";
            this.DiplomaSeriesTB.Size = new System.Drawing.Size(125, 27);
            this.DiplomaSeriesTB.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Номер диплома";
            // 
            // DiplomaNumberTB
            // 
            this.DiplomaNumberTB.Location = new System.Drawing.Point(389, 132);
            this.DiplomaNumberTB.Mask = "0000000";
            this.DiplomaNumberTB.Name = "DiplomaNumberTB";
            this.DiplomaNumberTB.Size = new System.Drawing.Size(141, 27);
            this.DiplomaNumberTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Дата выдачи";
            // 
            // IssueDateTB
            // 
            this.IssueDateTB.Location = new System.Drawing.Point(126, 161);
            this.IssueDateTB.Mask = "00-00-0000";
            this.IssueDateTB.Name = "IssueDateTB";
            this.IssueDateTB.Size = new System.Drawing.Size(125, 27);
            this.IssueDateTB.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Полученная специальность";
            // 
            // SpecialityTB
            // 
            this.SpecialityTB.Location = new System.Drawing.Point(238, 103);
            this.SpecialityTB.Name = "SpecialityTB";
            this.SpecialityTB.Size = new System.Drawing.Size(292, 27);
            this.SpecialityTB.TabIndex = 1;
            // 
            // SetPersonalFileButton
            // 
            this.SetPersonalFileButton.AutoSize = true;
            this.SetPersonalFileButton.LinkColor = System.Drawing.Color.Black;
            this.SetPersonalFileButton.Location = new System.Drawing.Point(316, 201);
            this.SetPersonalFileButton.Name = "SetPersonalFileButton";
            this.SetPersonalFileButton.Size = new System.Drawing.Size(274, 22);
            this.SetPersonalFileButton.TabIndex = 5;
            this.SetPersonalFileButton.TabStop = true;
            this.SetPersonalFileButton.Text = "Назначить владельца диплома";
            this.SetPersonalFileButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetPersonalFileButton_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "ФИО владельца диплома";
            // 
            // FioTB
            // 
            this.FioTB.Location = new System.Drawing.Point(193, 231);
            this.FioTB.Name = "FioTB";
            this.FioTB.ReadOnly = true;
            this.FioTB.Size = new System.Drawing.Size(337, 27);
            this.FioTB.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Серия трудовой книги";
            // 
            // WBSeriesTB
            // 
            this.WBSeriesTB.Location = new System.Drawing.Point(193, 260);
            this.WBSeriesTB.Name = "WBSeriesTB";
            this.WBSeriesTB.ReadOnly = true;
            this.WBSeriesTB.Size = new System.Drawing.Size(129, 27);
            this.WBSeriesTB.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Номер трудовой книги";
            // 
            // WBNumberTB
            // 
            this.WBNumberTB.Location = new System.Drawing.Point(193, 289);
            this.WBNumberTB.Name = "WBNumberTB";
            this.WBNumberTB.ReadOnly = true;
            this.WBNumberTB.Size = new System.Drawing.Size(129, 27);
            this.WBNumberTB.TabIndex = 1;
            // 
            // AddDiplomaButton
            // 
            this.AddDiplomaButton.Location = new System.Drawing.Point(343, 288);
            this.AddDiplomaButton.Name = "AddDiplomaButton";
            this.AddDiplomaButton.Size = new System.Drawing.Size(187, 24);
            this.AddDiplomaButton.TabIndex = 6;
            this.AddDiplomaButton.Text = "Добавить диплом";
            this.AddDiplomaButton.UseVisualStyleBackColor = true;
            this.AddDiplomaButton.Click += new System.EventHandler(this.AddDiplomaButton_Click);
            // 
            // AddDiplomaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 325);
            this.Controls.Add(this.AddDiplomaButton);
            this.Controls.Add(this.SetPersonalFileButton);
            this.Controls.Add(this.DiplomaNumberTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IssueDateTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiplomaSeriesTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EduDegreeCB);
            this.Controls.Add(this.EduLevelCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecialityTB);
            this.Controls.Add(this.WBNumberTB);
            this.Controls.Add(this.WBSeriesTB);
            this.Controls.Add(this.FioTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EduOrganizationNameTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddDiplomaForm";
            this.Text = "Добавление диплома";
            this.Load += new System.EventHandler(this.AddDiplomaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EduOrganizationNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EduLevelCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EduDegreeCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox DiplomaSeriesTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox DiplomaNumberTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox IssueDateTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SpecialityTB;
        private System.Windows.Forms.LinkLabel SetPersonalFileButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddDiplomaButton;
        public System.Windows.Forms.TextBox FioTB;
        public System.Windows.Forms.TextBox WBSeriesTB;
        public System.Windows.Forms.TextBox WBNumberTB;
    }
}