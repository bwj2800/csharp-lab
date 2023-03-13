using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double total_price = 0;

                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception("Enter the base price.");
                }

                total_price += Double.Parse(textBox1.Text);

                if (listBox1.SelectedItem=="First Class")
                {
                    total_price += total_price * 0.2;
                }
                else if (listBox1.SelectedItem == "Second Class")
                {
                }
                else
                {
                    throw new Exception("Select the type of ticket.");
                }

                if(comboBox1.SelectedItem=="youth card")
                {
                    total_price = total_price * 0.6;
                }
                else if (comboBox1.SelectedItem == "adult card")
                {
                    total_price = total_price * 0.7;
                }
                else if (comboBox1.SelectedItem == "family card")
                {
                    total_price = total_price * 0.5;
                }

                textBox2.Text = total_price.ToString();
                textBox3.Text = (total_price*0.2).ToString();
                textBox4.Text = (total_price * 1.2).ToString(); ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid values.", "Invalid field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
