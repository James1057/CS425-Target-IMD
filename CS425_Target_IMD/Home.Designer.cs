namespace CS425_Target_IMD
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameHome = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PassWordHome = new System.Windows.Forms.TextBox();
            this.MainTextBoxHome = new System.Windows.Forms.TextBox();
            this.QuitButtonHome = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.HomeMessage = new System.Windows.Forms.TextBox();
            this.TargetLinkHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "SIGN IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameHome
            // 
            this.UserNameHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameHome.Location = new System.Drawing.Point(201, 161);
            this.UserNameHome.Name = "UserNameHome";
            this.UserNameHome.Size = new System.Drawing.Size(166, 31);
            this.UserNameHome.TabIndex = 2;
            this.UserNameHome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassWordHome
            // 
            this.PassWordHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordHome.Location = new System.Drawing.Point(201, 215);
            this.PassWordHome.Name = "PassWordHome";
            this.PassWordHome.Size = new System.Drawing.Size(166, 31);
            this.PassWordHome.TabIndex = 3;
            this.PassWordHome.TextChanged += new System.EventHandler(this.PassWordHome_TextChanged);
            // 
            // MainTextBoxHome
            // 
            this.MainTextBoxHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextBoxHome.Location = new System.Drawing.Point(29, 21);
            this.MainTextBoxHome.Name = "MainTextBoxHome";
            this.MainTextBoxHome.Size = new System.Drawing.Size(453, 38);
            this.MainTextBoxHome.TabIndex = 4;
            // 
            // QuitButtonHome
            // 
            this.QuitButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButtonHome.Location = new System.Drawing.Point(722, 449);
            this.QuitButtonHome.Name = "QuitButtonHome";
            this.QuitButtonHome.Size = new System.Drawing.Size(100, 100);
            this.QuitButtonHome.TabIndex = 5;
            this.QuitButtonHome.Text = "Quit";
            this.QuitButtonHome.UseVisualStyleBackColor = true;
            this.QuitButtonHome.Click += new System.EventHandler(this.QuitButtonHome_Click);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox.Location = new System.Drawing.Point(29, 161);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(166, 31);
            this.UserNameBox.TabIndex = 6;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(29, 215);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(166, 31);
            this.PasswordBox.TabIndex = 7;
            // 
            // HomeMessage
            // 
            this.HomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeMessage.Location = new System.Drawing.Point(29, 66);
            this.HomeMessage.Name = "HomeMessage";
            this.HomeMessage.Size = new System.Drawing.Size(453, 31);
            this.HomeMessage.TabIndex = 8;
            // 
            // TargetLinkHome
            // 
            this.TargetLinkHome.AutoSize = true;
            this.TargetLinkHome.BackColor = System.Drawing.Color.White;
            this.TargetLinkHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetLinkHome.Location = new System.Drawing.Point(497, 209);
            this.TargetLinkHome.Name = "TargetLinkHome";
            this.TargetLinkHome.Size = new System.Drawing.Size(247, 37);
            this.TargetLinkHome.TabIndex = 9;
            this.TargetLinkHome.TabStop = true;
            this.TargetLinkHome.Text = "www.target.com";
            this.TargetLinkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.TargetLinkHome);
            this.Controls.Add(this.HomeMessage);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.QuitButtonHome);
            this.Controls.Add(this.MainTextBoxHome);
            this.Controls.Add(this.PassWordHome);
            this.Controls.Add(this.UserNameHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserNameHome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox PassWordHome;
        private System.Windows.Forms.TextBox MainTextBoxHome;
        private System.Windows.Forms.Button QuitButtonHome;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox HomeMessage;
        private System.Windows.Forms.LinkLabel TargetLinkHome;
    }
}

