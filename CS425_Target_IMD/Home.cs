using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS425_Target_IMD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String UserName = textBox1.Text;
            UserNameText.Text =
            String UserName = UserNameHome.Text;
            String PassWord = PassWordHome.Text;
            MessageBox.Show("User Name: " + UserName + "\nPassword: " +PassWord);
            //EmployeePage F = new EmployeePage();
            //Hide();
            //F.ShowDialog();
            //Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
