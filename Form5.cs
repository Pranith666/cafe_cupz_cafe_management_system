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

namespace pp
{
    
    public partial class Form5 : Form
    {
        OracleConnection conn;

        public Form5()
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
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            SetConnection();

            string a = richTextBox1.Text;
            int t = int.Parse(textBox3.Text);
            int r = int.Parse(textBox1.Text);
            string q = "insert into FEEDBACK(table_no,stars,Feedback) values ('"+t+"','"+r+"','"+a+"')";
            OracleCommand cmd = new OracleCommand(q, conn);

            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            cmd.Dispose();

            conn.Close();
            Form6  f6 = new Form6();
            f6.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
