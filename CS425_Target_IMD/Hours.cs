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
    public partial class Hours : Form
    {
        public string UserNameGlobal;
        public Hours()
        {
            InitializeComponent();
        }
        private void Hours_Load(object sender, EventArgs e)
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = DBUtils.GetDBConnection();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            var stm = "SELECT * FROM employee";
            var cmd = new MySqlCommand(stm, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //dataGridView1.DataSource = table;
        }
    }

          
}
