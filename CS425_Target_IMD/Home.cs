using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;

namespace CS425_Target_IMD
{
   
        public partial class Home : Form
    {
        public string UserNameGlobal ;//{ get; private set; }
       
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
            //Check Password
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            String valid = "false";
            try
            {
                conn.Open();
                var stm = "SELECT EID,password FROM employee WHERE EID = '" + UserName+ "' AND password = '" + PassWord+"'";
                var cmd = new MySqlCommand(stm, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0}, {1}", rdr.GetString(0),rdr.GetString(1));
                    valid = "true";
                }
            }
            catch
            {
                MessageBox.Show("Bad input");
            }
            //Debugging the connection to db checking for the employee login and password being correct
            //MessageBox.Show(valid);

            //open up the new window
            if (valid == "true")
            {
                EmployeePage F = new EmployeePage();
                F.UserNameGlobal = UserName;
                Hide();
                F.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Bad input");
            }
        }

        private void QuitButtonHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HomeDebugNextPage_Click(object sender, EventArgs e)
        {
            EmployeePage F = new EmployeePage();
            Hide();
            F.ShowDialog();
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

        private void LinkCheck_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            try
            {
                MessageBox.Show("Openning Connection ...");
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                MessageBox.Show("Connection successful!");
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //get the target website          
            System.Diagnostics.Process.Start(TargetLinkHome.Text);
        }
    }
}
