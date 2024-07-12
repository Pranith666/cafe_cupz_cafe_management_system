using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pp
{
    public partial class Form3 : Form
    {
        OracleConnection conn;
        Form2 f1;
        public string stdName1{get; set;}
        public string stdName2 { get; set; }
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = stdName1;
            label2.Text = stdName2;
            SetConnection();
            OracleCommand cmd = new OracleCommand("select item_name,price from ORDERS natural join ITEM where table_no=:table_no", conn);
            cmd.Parameters.Add(":table_no", label1.Text);
            // Create the data adapter and fill the data table
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the data source for the data grid view
            dataGridView1.DataSource = dt;

            // Clean up
            cmd.Dispose();
            da.Dispose();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            
        }
    }
}
