using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CS425_Target_IMD
{
    public partial class Hours : Form
    {
        public string UserNameGlobal;
        public Hours()
        {
            InitializeComponent();
        }
        private void Hours_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Welcome to the Hours Section of Target";
            textBox1.ReadOnly = true;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            //Fill the table
            var stm = "SELECT * FROM hours WHERE EID = '" + UserNameGlobal + "'";
            var cmd = new MySqlCommand(stm, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;
            //Get the employee Name
            conn.Open();
            var stm2 = "SELECT fname,lname FROM employee WHERE EID = '" + UserNameGlobal + "'";
            var cmd2 = new MySqlCommand(stm2, conn);
            MySqlDataReader rdr = cmd2.ExecuteReader();
            rdr.Read();
            NameHours.Text = "Hello " + rdr.GetString(0) + " " + rdr.GetString(1) + "!";
            NameHours.ReadOnly = true;
            conn.Close();
            conn.Open();

            //Salary Catch
            var stm3= "SELECT SUM( wage * number_of_hours ) AS SalaryPaid FROM hours WHERE EID = '" + UserNameGlobal + "'";
            var cmd3 = new MySqlCommand(stm3, conn);
            MySqlDataReader rdr3 = cmd3.ExecuteReader();
            rdr3.Read();
            SalaryHoursBox.Text = "Current Paid Salary is $" + rdr3.GetString(0);
            SalaryHoursBox.ReadOnly = true;

            conn.Close();

            EnterHours.Text = "Enter Hours";
            EnterWage.Text = "Enter Wage";
            EnterHours.ReadOnly = true;
            EnterWage.ReadOnly = true;
        }
        

        private void QuitButtonHours_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackToEmployee_Click(object sender, EventArgs e)
        {
            EmployeePage F = new EmployeePage();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
        }

        private void AddHoursButton_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            var stm = "Select max(entryID) as m from hours";
            var cmd = new MySqlCommand(stm, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            String var = rdr.GetString(0);
            Int16 maxEntryID = (short)(Int16.Parse(var.Substring(2)) + 1);
            String EntryIDString = "EH" + maxEntryID.ToString();
            conn.Close();
            conn.Open();
            Int16 NumberHours = Int16.Parse(NumberOfHours.Text);
            Int16 WageIn = Int16.Parse(WageInput.Text);
            var stm2 = "INSERT INTO hours (entryID,number_of_hours,wage,EID) VALUES (@entryID,@NumberHours,@WageIn,@UserNameGlobal); ";
            MySqlCommand cmd2 = new MySqlCommand(stm2, conn);
            cmd2.Parameters.AddWithValue("@entryID", EntryIDString);
            cmd2.Parameters.AddWithValue("@NumberHours", NumberHours);
            cmd2.Parameters.AddWithValue("@WageIn", WageIn);
            cmd2.Parameters.AddWithValue("@UserNameGlobal", UserNameGlobal);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Hours have been entered");
            Hours F = new Hours();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
            Close();
        }
    }  
}
