using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pp
{
    public partial class Form4 : Form
    {
        OracleConnection conn;
        public Form4()
        {
            InitializeComponent();
        }
        private void SetConnection()
        {
            conn = new OracleConnection("DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True;USER ID=PRANITH;PASSWORD=Sairam69");
            try
            {
                conn.Open();




            }
            catch (Exception ex)
            {
                MessageBox.Show("NO  CONNECTION");
            }

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            SetConnection();
            OracleCommand cmd2 = new OracleCommand("SELECT * FROM MANAGER", conn);

            // Create the data adapter and fill the data table
            OracleDataAdapter da = new OracleDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the data source for the data grid view
            dataGridView2.DataSource = dt;

            // Clean up
            cmd2.Dispose();
            da.Dispose();
            conn.Close();
            SetConnection();

            OracleCommand cmd1 = conn.CreateCommand();
            
            cmd1.CommandText = "SELECT SUM(order_total) as total_spending FROM (    SELECT SUM(price) as order_total     FROM ORDERS     NATURAL JOIN ITEM    GROUP BY table_no)";
            
            OracleDataReader dr = cmd1.ExecuteReader();
            dr.Read();
            textBox1.Text = dr.GetString(0);
            cmd1.Dispose();
            conn.Close();
            SetConnection();
            OracleCommand cmd = new OracleCommand("SELECT table_no, SUM(price) AS total_price FROM ORDERS NATURAL JOIN ITEM GROUP BY table_no", conn);
            
            // Create the data adapter and fill the data table
            OracleDataAdapter da1 = new OracleDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            // Set the data source for the data grid view
            dataGridView1.DataSource = dt1;

            // Clean up
            cmd.Dispose();
            da.Dispose();
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
