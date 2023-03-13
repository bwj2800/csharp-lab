using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        static string constring = "Data Source=desktop-705cmno\\sqlexpress;Initial Catalog=Customers;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constring);
        DataTable table = new DataTable();
        int cur_idx = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count>0)
            {
                cur_idx = 0;
                textBox1.Text = table.Rows[cur_idx]["CIN"].ToString();
                textBox2.Text = table.Rows[cur_idx]["NAME"].ToString();
                textBox3.Text = table.Rows[cur_idx]["Family"].ToString();
                textBox4.Text = table.Rows[cur_idx]["CITY"].ToString();
                textBox5.Text = table.Rows[cur_idx]["TEL"].ToString();
                label6.Text = (cur_idx+1).ToString();
            }
            else
            {
                MessageBox.Show("No data");
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER", conn);
                SqlDataReader reader = command.ExecuteReader();
                
                table.Columns.Add("CIN", typeof(string));
                table.Columns.Add("NAME", typeof(string));
                table.Columns.Add("Family", typeof(string));
                table.Columns.Add("CITY", typeof(string));
                table.Columns.Add("TEL", typeof(string));
                do
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader["CIN"], reader["NAME"], reader["Family"], reader["CITY"], reader["TEL"]);
                    }
                }
                while (reader.NextResult());
                dataGridView1.DataSource = table;
                reader.Close();
                conn.Close();

                label6.Text = (cur_idx + 1).ToString();
                label8.Text = table.Rows.Count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cur_idx>0)
            {
                cur_idx--;
                textBox1.Text = table.Rows[cur_idx]["CIN"].ToString();
                textBox2.Text = table.Rows[cur_idx]["NAME"].ToString();
                textBox3.Text = table.Rows[cur_idx]["Family"].ToString();
                textBox4.Text = table.Rows[cur_idx]["CITY"].ToString();
                textBox5.Text = table.Rows[cur_idx]["TEL"].ToString();
                label6.Text = (cur_idx + 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0)
            {
                cur_idx=table.Rows.Count-1;
                textBox1.Text = table.Rows[cur_idx]["CIN"].ToString();
                textBox2.Text = table.Rows[cur_idx]["NAME"].ToString();
                textBox3.Text = table.Rows[cur_idx]["Family"].ToString();
                textBox4.Text = table.Rows[cur_idx]["CITY"].ToString();
                textBox5.Text = table.Rows[cur_idx]["TEL"].ToString();
                label6.Text = (cur_idx + 1).ToString();
            }
            else
            {
                MessageBox.Show("No data");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cur_idx >= 0 && cur_idx<table.Rows.Count-1)
            {
                cur_idx++;
                textBox1.Text = table.Rows[cur_idx]["CIN"].ToString();
                textBox2.Text = table.Rows[cur_idx]["NAME"].ToString();
                textBox3.Text = table.Rows[cur_idx]["Family"].ToString();
                textBox4.Text = table.Rows[cur_idx]["CITY"].ToString();
                textBox5.Text = table.Rows[cur_idx]["TEL"].ToString();
                label6.Text = (cur_idx + 1).ToString();
            }
        }
    }
}
