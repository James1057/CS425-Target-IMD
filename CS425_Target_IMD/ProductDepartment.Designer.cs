namespace CS425_Target_IMD
{
    partial class ProductDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDepartment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuitProduct = new System.Windows.Forms.Button();
            this.BackProduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PID_INPUT = new System.Windows.Forms.TextBox();
            this.textFindStock = new System.Windows.Forms.TextBox();
            this.FindStock = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // QuitProduct
            // 
            this.QuitProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitProduct.Location = new System.Drawing.Point(722, 449);
            this.QuitProduct.Name = "QuitProduct";
            this.QuitProduct.Size = new System.Drawing.Size(100, 100);
            this.QuitProduct.TabIndex = 2;
            this.QuitProduct.Text = "Quit";
            this.QuitProduct.UseVisualStyleBackColor = true;
            this.QuitProduct.Click += new System.EventHandler(this.QuitButtonProduct_Click);
            // 
            // BackProduct
            // 
            this.BackProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackProduct.Location = new System.Drawing.Point(571, 449);
            this.BackProduct.Name = "BackProduct";
            this.BackProduct.Size = new System.Drawing.Size(100, 100);
            this.BackProduct.TabIndex = 3;
            this.BackProduct.Text = "Back";
            this.BackProduct.UseVisualStyleBackColor = true;
            this.BackProduct.Click += new System.EventHandler(this.BackButtonProduct_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 40);
            this.textBox1.TabIndex = 4;
            // 
            // PID_INPUT
            // 
            this.PID_INPUT.Location = new System.Drawing.Point(571, 339);
            this.PID_INPUT.Name = "PID_INPUT";
            this.PID_INPUT.Size = new System.Drawing.Size(100, 20);
            this.PID_INPUT.TabIndex = 5;
            this.PID_INPUT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textFindStock
            // 
            this.textFindStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFindStock.Location = new System.Drawing.Point(571, 284);
            this.textFindStock.Multiline = true;
            this.textFindStock.Name = "textFindStock";
            this.textFindStock.Size = new System.Drawing.Size(100, 39);
            this.textFindStock.TabIndex = 6;
            // 
            // FindStock
            // 
            this.FindStock.Location = new System.Drawing.Point(722, 284);
            this.FindStock.Name = "FindStock";
            this.FindStock.Size = new System.Drawing.Size(100, 75);
            this.FindStock.TabIndex = 7;
            this.FindStock.Text = "Find Stock";
            this.FindStock.UseVisualStyleBackColor = true;
            this.FindStock.Click += new System.EventHandler(this.findStockOfPID);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 449);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(476, 45);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 508);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(476, 45);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // ProductDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.FindStock);
            this.Controls.Add(this.textFindStock);
            this.Controls.Add(this.PID_INPUT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BackProduct);
            this.Controls.Add(this.QuitProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductDepartment";
            this.Text = "Store Products";
            this.Load += new System.EventHandler(this.ProductDepartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button QuitProduct;
        private System.Windows.Forms.Button BackProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PID_INPUT;
        private System.Windows.Forms.TextBox textFindStock;
        private System.Windows.Forms.Button FindStock;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}