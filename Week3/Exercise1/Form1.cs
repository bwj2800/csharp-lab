using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception("Enter the rate.");
                }
                else if (String.IsNullOrEmpty(textBox2.Text))
                {
                    throw new Exception("Enter the amount.");
                }
                double rate = Double.Parse(textBox1.Text);
                double input = Double.Parse(textBox2.Text);

                if (radioButton1.Checked)
                {
                    textBox3.Text = (input/rate).ToString();
                }
                else if(radioButton2.Checked)
                {
                    textBox3.Text = (input * rate).ToString();
                }
                else
                {
                    throw new Exception("Select one operation.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid values.", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (ex.Message=="Enter all values.")
                {
                    MessageBox.Show(ex.Message, "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Operation not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
              

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
