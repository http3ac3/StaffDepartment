
namespace StaffDepartment
{
    partial class AddPostForm
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
            this.PostNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalaryTB = new System.Windows.Forms.NumericUpDown();
            this.RiseTB = new System.Windows.Forms.NumericUpDown();
            this.AddPostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiseTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название должности";
            // 
            // PostNameTB
            // 
            this.PostNameTB.Location = new System.Drawing.Point(192, 10);
            this.PostNameTB.Name = "PostNameTB";
            this.PostNameTB.Size = new System.Drawing.Size(244, 23);
            this.PostNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Заработная плата, руб.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Надбавка, %";
            // 
            // SalaryTB
            // 
            this.SalaryTB.DecimalPlaces = 2;
            this.SalaryTB.Location = new System.Drawing.Point(192, 40);
            this.SalaryTB.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(144, 23);
            this.SalaryTB.TabIndex = 2;
            // 
            // RiseTB
            // 
            this.RiseTB.Location = new System.Drawing.Point(192, 69);
            this.RiseTB.Name = "RiseTB";
            this.RiseTB.Size = new System.Drawing.Size(144, 23);
            this.RiseTB.TabIndex = 2;
            this.RiseTB.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AddPostButton
            // 
            this.AddPostButton.Location = new System.Drawing.Point(119, 100);
            this.AddPostButton.Name = "AddPostButton";
            this.AddPostButton.Size = new System.Drawing.Size(217, 26);
            this.AddPostButton.TabIndex = 3;
            this.AddPostButton.Text = "Добавить должность";
            this.AddPostButton.UseVisualStyleBackColor = true;
            this.AddPostButton.Click += new System.EventHandler(this.AddPostButton_Click);
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 138);
            this.Controls.Add(this.AddPostButton);
            this.Controls.Add(this.RiseTB);
            this.Controls.Add(this.SalaryTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PostNameTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddPostForm";
            this.Text = "Добавление должности";
            this.Load += new System.EventHandler(this.AddPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiseTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SalaryTB;
        private System.Windows.Forms.NumericUpDown RiseTB;
        private System.Windows.Forms.Button AddPostButton;
    }
}