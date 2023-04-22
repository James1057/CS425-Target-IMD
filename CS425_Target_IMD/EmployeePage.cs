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
    public partial class EmployeePage : Form
    {
        public string UserNameGlobal;
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            //Loading elements on the home page
            //MessageBox.Show(UserNameGlobal);
            textBox1.Text = "Thank You for Signing In";
            textBox1.ReadOnly = true;
            textBox2.Text = "Please make a selection:";
            textBox2.ReadOnly = true;
            textBox3.Text = "Your Store Info";
            textBox3.ReadOnly = true;


            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            var stm = "select store_hours, location, store_manager, department_name from store inner join employee where employee.SID = Store.SID and EID = '" + UserNameGlobal + "'";
            var cmd = new MySqlCommand(stm, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;
            conn.Close();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void QuitButtonEmployee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackToEmployee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hours F = new Hours();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;

            conn.Open();

            var stm3 = "select role from employee where EID = '" + UserNameGlobal + "'";
            var cmd3 = new MySqlCommand(stm3, conn);
            MySqlDataReader rdr = cmd3.ExecuteReader();
            rdr.Read();

            var erole = rdr.GetString(0);

            if (erole == "Manager") {
                MessageBox.Show("Access Granted");
            } else {
                MessageBox.Show("Access Denied");
            };
            
            conn.Close();

        }
    }
}
