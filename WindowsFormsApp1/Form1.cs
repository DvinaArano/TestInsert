using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            string Connect = "server=127.0.0.1;user id=root;database=testschema";
            MySqlConnection connect = new MySqlConnection(Connect);
            connect.Open();
            string sql = "Select * from testschema.testcolumn";
            MySqlCommand command = new MySqlCommand(sql, connect);
            DataTable dt = new DataTable("Show");
            MySqlDataAdapter adt = new MySqlDataAdapter(command);
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
