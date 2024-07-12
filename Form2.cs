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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pp
{
    
    public partial class Form2 : Form
    {

        Form1 f1;
        OracleConnection conn;
        public string stdName { get; set; }
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            //bindata();
            // TODO: This line of code loads data into the 'dataSet3.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter1.Fill(this.dataSet3.CUSTOMER);
            // TODO: This line of code loads data into the 'dataSet2.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.dataSet2.CUSTOMER);
            //textBox9.Text = stdName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CATEGORIES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        /*private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetConnection();
                OracleCommand cmd = new OracleCommand("insert into ORDERS values(:table_no,:item_name)", conn);

                cmd.Parameters.Add(":table_no", int.Parse(textBox9.Text));
                cmd.Parameters.Add(":item_name", checkBox1.Text);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }
            catch 
            {
                MessageBox.Show("not added");

            }
        }*/
        


        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bindata()
        {
            
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            SetConnection();
            OracleCommand cmd = conn.CreateCommand();
            int a = int.Parse(textBox10.Text);
            cmd.CommandText = "select sum(price) as order_total from ORDERS natural join ITEM where table_no=:table_no";
            cmd.Parameters.Add(":table_no", OracleDbType.Int32).Value = a;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox11.Text = dr.GetString(0);
            cmd.Dispose();
            conn.Close();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SetConnection();

            string n = (string)comboBox1.SelectedItem;
            int t = int.Parse(textBox10.Text);
            
            string q = "insert into ORDERS(table_no,item_name) values ('" + t + "','" + n + "')";
            OracleCommand cmd = new OracleCommand(q, conn);

            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            cmd.Dispose();

            conn.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetConnection();

            // Create the select command
            OracleCommand cmd = new OracleCommand("select * from CUSTOMER", conn);

            // Create the data adapter and fill the data table
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the data source for the data grid view
            dataGridView2.DataSource = dt;

            // Clean up
            cmd.Dispose();
            da.Dispose();
            conn.Close() ;
            




        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand("select item_name,price from ORDERS natural join ITEM where table_no=:table_no", conn);
            cmd.Parameters.Add(":table_no", textBox10.Text);
            // Create the data adapter and fill the data table
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the data source for the data grid view
            dataGridView1.DataSource = dt;

            // Clean up
            cmd.Dispose();
            da.Dispose();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.stdName1 = textBox10.Text;
            f3.stdName2 = textBox11.Text;
            f3.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
