﻿namespace CS425_Target_IMD
{
    partial class Hours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hours));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuitHours = new System.Windows.Forms.Button();
            this.BackToEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameHours = new System.Windows.Forms.TextBox();
            this.SalaryHoursBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(49, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 38);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // QuitHours
            // 
            this.QuitHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitHours.Location = new System.Drawing.Point(722, 449);
            this.QuitHours.Name = "QuitHours";
            this.QuitHours.Size = new System.Drawing.Size(100, 100);
            this.QuitHours.TabIndex = 2;
            this.QuitHours.Text = "Quit";
            this.QuitHours.UseVisualStyleBackColor = true;
            this.QuitHours.Click += new System.EventHandler(this.QuitButtonHours_Click);
            // 
            // BackToEmployee
            // 
            this.BackToEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToEmployee.Location = new System.Drawing.Point(563, 449);
            this.BackToEmployee.Name = "BackToEmployee";
            this.BackToEmployee.Size = new System.Drawing.Size(100, 100);
            this.BackToEmployee.TabIndex = 3;
            this.BackToEmployee.Text = "Back";
            this.BackToEmployee.UseVisualStyleBackColor = true;
            this.BackToEmployee.Click += new System.EventHandler(this.BackToEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 250);
            this.dataGridView1.TabIndex = 4;
            // 
            // NameHours
            // 
            this.NameHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHours.Location = new System.Drawing.Point(49, 69);
            this.NameHours.Name = "NameHours";
            this.NameHours.Size = new System.Drawing.Size(311, 31);
            this.NameHours.TabIndex = 5;
            // 
            // SalaryHoursBox
            // 
            this.SalaryHoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryHoursBox.Location = new System.Drawing.Point(49, 127);
            this.SalaryHoursBox.Name = "SalaryHoursBox";
            this.SalaryHoursBox.Size = new System.Drawing.Size(311, 31);
            this.SalaryHoursBox.TabIndex = 6;
            // 
            // Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.SalaryHoursBox);
            this.Controls.Add(this.NameHours);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackToEmployee);
            this.Controls.Add(this.QuitHours);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hours";
            this.Text = "Hours";
            this.Load += new System.EventHandler(this.Hours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button QuitHours;
        private System.Windows.Forms.Button BackToEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameHours;
        private System.Windows.Forms.TextBox SalaryHoursBox;
    }
}