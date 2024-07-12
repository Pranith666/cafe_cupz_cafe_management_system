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
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pp
{
    public partial class Form1 : Form
    {
        
        OracleConnection conn;
        
        public Form1()
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
                
            }

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SetConnection();

            string n = textBox1.Text;
            int t = int.Parse(textBox3.Text);
            int c = int.Parse(textBox2.Text);
            string q= "insert into CUSTOMER(table_no,name,cust_contact) values ('"+t+"','"+n+"','"+c+"')";
            OracleCommand cmd = new OracleCommand(q, conn);
            
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            cmd.Dispose();
            
            conn.Close();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
