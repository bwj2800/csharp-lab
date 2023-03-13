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

namespace Exercise1
{
    public partial class Form1 : Form
    {
        static string constring = "Data Source=DESKTOP-705CMNO\\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constring);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                MessageBox.Show(conn.State.ToString());
            }
            else
            {
                MessageBox.Show("Already opened");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER", conn);
                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
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
            }
            else
            {
                MessageBox.Show("Open the Connection");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
                MessageBox.Show(conn.State.ToString());
            }
            else
            {
                MessageBox.Show("Already disconnected");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
    }
}
