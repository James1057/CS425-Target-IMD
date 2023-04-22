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

namespace CS425_Target_IMD
{
    public partial class Department : Form
    {
        public string UserNameGlobal;
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            textBox1.Text = "   Store Details for Managers";
            textBox1.ReadOnly = true;

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            var stm5 = "SELECT fname,lname FROM employee WHERE EID = '" + UserNameGlobal + "'";
            var cmd5 = new MySqlCommand(stm5, conn);
            MySqlDataReader rdr = cmd5.ExecuteReader();
            rdr.Read();
            var name = rdr.GetString(0) + ' ' + rdr.GetString(1);
            conn.Close();
            conn.Open();

            var stm4 = "select department.department_name, category, in_store_locaiton from department inner join store where department.department_name = store.department_name and store_manager = '" + name + "'";
            var cmd4 = new MySqlCommand(stm4, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd4);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoreBanking F = new StoreBanking();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeePage F = new EmployeePage();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDepartment F = new ProductDepartment();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
