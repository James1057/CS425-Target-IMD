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
            //Getting the user name and password
            String UserName = UserNameHome.Text;
            String PassWord = PassWordHome.Text;
            //MessageBox.Show("User Name: " + UserName + "\nPassword: " +PassWord);
            //open up the new window
            EmployeePage F = new EmployeePage();
            Hide();
            F.ShowDialog();
            Close();
        }

        private void QuitButtonHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Loading elements on the home page
            MainTextBoxHome.Text = "Welcome to Target Employee Portal";
            MainTextBoxHome.ReadOnly = true;
            UserNameBox.Text = "Username";
            PasswordBox.Text = "Password";
            UserNameBox.ReadOnly = true;
            PasswordBox.ReadOnly = true;
            HomeMessage.Text = "Please Enter Login Name & Password";
            HomeMessage.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassWordHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(TargetLinkHome.Text);
            //linkLabel1.Text = "www.target.com";
        }
    }
}
