
namespace StaffDepartment
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LoginNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.DirectorRadioButton = new System.Windows.Forms.RadioButton();
            this.VisitorRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя для входа";
            // 
            // LoginNameTB
            // 
            this.LoginNameTB.Location = new System.Drawing.Point(148, 13);
            this.LoginNameTB.Name = "LoginNameTB";
            this.LoginNameTB.Size = new System.Drawing.Size(224, 27);
            this.LoginNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(148, 45);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(224, 27);
            this.PasswordTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Повторите пароль";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(148, 77);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(224, 27);
            this.ConfirmPassword.TabIndex = 1;
            // 
            // DirectorRadioButton
            // 
            this.DirectorRadioButton.AutoSize = true;
            this.DirectorRadioButton.Location = new System.Drawing.Point(16, 147);
            this.DirectorRadioButton.Name = "DirectorRadioButton";
            this.DirectorRadioButton.Size = new System.Drawing.Size(310, 26);
            this.DirectorRadioButton.TabIndex = 2;
            this.DirectorRadioButton.TabStop = true;
            this.DirectorRadioButton.Text = "Директор (полные возможности)";
            this.DirectorRadioButton.UseVisualStyleBackColor = true;
            // 
            // VisitorRadioButton
            // 
            this.VisitorRadioButton.AutoSize = true;
            this.VisitorRadioButton.Location = new System.Drawing.Point(16, 174);
            this.VisitorRadioButton.Name = "VisitorRadioButton";
            this.VisitorRadioButton.Size = new System.Drawing.Size(354, 26);
            this.VisitorRadioButton.TabIndex = 2;
            this.VisitorRadioButton.TabStop = true;
            this.VisitorRadioButton.Text = "Посетитель (только просмотр данных)";
            this.VisitorRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Назначьте роль пользователю";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(74, 217);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(239, 33);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Зарегистрировать";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 257);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.VisitorRadioButton);
            this.Controls.Add(this.DirectorRadioButton);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.RadioButton DirectorRadioButton;
        private System.Windows.Forms.RadioButton VisitorRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegisterButton;
    }
}