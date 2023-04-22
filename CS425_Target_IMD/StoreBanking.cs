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
    public partial class StoreBanking : Form
    {
        public string UserNameGlobal;

        public StoreBanking()
        {
            InitializeComponent();
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Target Store Bank Accounts";
            textBox1.ReadOnly = true;
            HowTo.Text = "Please enter the field to limt, operator and value below in the corresponding box";
            
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            //Fill the table
            var stm = "SELECT bankaccounts.income,bankaccounts.sales,bankaccounts.profit,bankaccounts.expenses FROM employee" +
                "\n INNER JOIN store ON store.SID = employee.SID \n" +
                "INNER JOIN bankaccounts on store.BID = bankaccounts.BID \n" + 
                "WHERE EID = '" + UserNameGlobal + "'";
            var cmd = new MySqlCommand(stm, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;
            FieldText.Text = "Table field";
            OperatorText.Text = "Operator";
            ValueText.Text = "Value";
            FieldText.ReadOnly = true;
            OperatorText.ReadOnly = true;
            ValueText.ReadOnly = true;
        }


        private void QuitButtonBanking_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimitTheData_Click(object sender, EventArgs e)
        {
            String Field = FieldVal.Text.ToString().ToLower();
            String Operator = OperatorVal.Text.ToString();
            Int32 Limit = Int32.Parse(LimitValue.Text.ToString());
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            //Fill the table
            var stm = "SELECT bankaccounts.income,bankaccounts.sales,bankaccounts.profit,bankaccounts.expenses FROM employee" +
                "\n INNER JOIN store ON store.SID = employee.SID \n" +
                "INNER JOIN bankaccounts on store.BID = bankaccounts.BID \n" +
                "WHERE EID = '" + UserNameGlobal + "' AND " + Field + Operator + Limit;
            var cmd = new MySqlCommand(stm, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = table;
        }

        private void BackButtonBanking_Click(object sender, EventArgs e)
        {

            Department F = new Department();
            F.UserNameGlobal = UserNameGlobal;
            Hide();
            F.ShowDialog();
            Close();
        }
    }
}
