namespace CS425_Target_IMD
{
    partial class StoreBanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreBanking));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BackBanking = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HowTo = new System.Windows.Forms.TextBox();
            this.FieldVal = new System.Windows.Forms.TextBox();
            this.OperatorVal = new System.Windows.Forms.TextBox();
            this.LimitValue = new System.Windows.Forms.TextBox();
            this.LimitData = new System.Windows.Forms.Button();
            this.FieldText = new System.Windows.Forms.TextBox();
            this.OperatorText = new System.Windows.Forms.TextBox();
            this.ValueText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(722, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QuitButtonBanking_Click);
            // 
            // BackBanking
            // 
            this.BackBanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBanking.Location = new System.Drawing.Point(504, 449);
            this.BackBanking.Name = "BackBanking";
            this.BackBanking.Size = new System.Drawing.Size(100, 100);
            this.BackBanking.TabIndex = 2;
            this.BackBanking.Text = "Back";
            this.BackBanking.UseVisualStyleBackColor = true;
            this.BackBanking.Click += new System.EventHandler(this.BackButtonBanking_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 38);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 391);
            this.dataGridView1.TabIndex = 4;
            // 
            // HowTo
            // 
            this.HowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowTo.Location = new System.Drawing.Point(504, 166);
            this.HowTo.Multiline = true;
            this.HowTo.Name = "HowTo";
            this.HowTo.Size = new System.Drawing.Size(318, 79);
            this.HowTo.TabIndex = 5;
            // 
            // FieldVal
            // 
            this.FieldVal.Location = new System.Drawing.Point(504, 384);
            this.FieldVal.Name = "FieldVal";
            this.FieldVal.Size = new System.Drawing.Size(100, 20);
            this.FieldVal.TabIndex = 6;
            // 
            // OperatorVal
            // 
            this.OperatorVal.Location = new System.Drawing.Point(616, 384);
            this.OperatorVal.Name = "OperatorVal";
            this.OperatorVal.Size = new System.Drawing.Size(100, 20);
            this.OperatorVal.TabIndex = 7;
            // 
            // LimitValue
            // 
            this.LimitValue.Location = new System.Drawing.Point(722, 384);
            this.LimitValue.Name = "LimitValue";
            this.LimitValue.Size = new System.Drawing.Size(100, 20);
            this.LimitValue.TabIndex = 8;
            // 
            // LimitData
            // 
            this.LimitData.Location = new System.Drawing.Point(616, 431);
            this.LimitData.Name = "LimitData";
            this.LimitData.Size = new System.Drawing.Size(100, 23);
            this.LimitData.TabIndex = 9;
            this.LimitData.Text = "Run";
            this.LimitData.UseVisualStyleBackColor = true;
            this.LimitData.Click += new System.EventHandler(this.LimitTheData_Click);
            // 
            // FieldText
            // 
            this.FieldText.Location = new System.Drawing.Point(504, 358);
            this.FieldText.Name = "FieldText";
            this.FieldText.Size = new System.Drawing.Size(100, 20);
            this.FieldText.TabIndex = 10;
            // 
            // OperatorText
            // 
            this.OperatorText.Location = new System.Drawing.Point(616, 358);
            this.OperatorText.Name = "OperatorText";
            this.OperatorText.Size = new System.Drawing.Size(100, 20);
            this.OperatorText.TabIndex = 11;
            // 
            // ValueText
            // 
            this.ValueText.Location = new System.Drawing.Point(723, 358);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(100, 20);
            this.ValueText.TabIndex = 12;
            // 
            // StoreBanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.OperatorText);
            this.Controls.Add(this.FieldText);
            this.Controls.Add(this.LimitData);
            this.Controls.Add(this.LimitValue);
            this.Controls.Add(this.OperatorVal);
            this.Controls.Add(this.FieldVal);
            this.Controls.Add(this.HowTo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackBanking);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StoreBanking";
            this.Text = "Store Bank Accounts";
            this.Load += new System.EventHandler(this.Bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackBanking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox HowTo;
        private System.Windows.Forms.TextBox FieldVal;
        private System.Windows.Forms.TextBox OperatorVal;
        private System.Windows.Forms.TextBox LimitValue;
        private System.Windows.Forms.Button LimitData;
        private System.Windows.Forms.TextBox FieldText;
        private System.Windows.Forms.TextBox OperatorText;
        private System.Windows.Forms.TextBox ValueText;
    }
}