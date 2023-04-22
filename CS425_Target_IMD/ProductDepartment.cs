using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class ProductDepartment : Form
    {
        public string UserNameGlobal;
        public ProductDepartment()
        {
            InitializeComponent();
        }

        private void ProductDepartments_Load(object sender, EventArgs e)
        {
            textBox1.Text = "All Products in your store";
            textBox1.ReadOnly = true;
            textFindStock.Text = "Enter PID to find stock";
            textFindStock.ReadOnly = true;
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            //Fill the table
            var stm = "select PID, product_name, on_sale,sale_price,normal_price,sale_percentage,department_name from product_store natural join employee where employee.SID = product_store.SID and " +
                " EID = '" + UserNameGlobal + "' order by department_name asc;";
            var cmd = new MySqlCommand(stm, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;
            this.dataGridView1.AllowUserToAddRows = false;
        }

            private void QuitButtonProduct_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackButtonProduct_Click(object sender, EventArgs e)
        {
            Department F = new Department();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void findStockOfPID(object sender, EventArgs e)
        {
            String PID_Var = PID_INPUT.Text.Trim();
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            //Fill the table with Stock
            var stm2 = "select product_SID, number_instock, stock_ordered, stock_ordered_amount, stock_ordered_cost, invoice_number, tracking_number from product_stock " +
                "WHERE PID = '" + PID_Var + "'";
            var cmd2 = new MySqlCommand(stm2, conn);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = table2;
            //Fill the table with seller info
            var stm3 = "select seller_id, seller_name, phone_number, email, representative_name from seller " +
                "WHERE PID = '" + PID_Var + "'";
            var cmd3 = new MySqlCommand(stm3, conn);
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(cmd3);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = table3;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToAddRows = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
