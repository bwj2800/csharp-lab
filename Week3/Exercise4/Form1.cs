using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Fields should not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (monthCalendar1.SelectionStart > DateTime.Today || monthCalendar1.SelectionEnd.ToString("yyyy/MM/dd") != monthCalendar1.SelectionStart.ToString("yyyy/MM/dd"))
            {
                MessageBox.Show("The registration date must be less than or equal to the current date.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (maskedTextBox1.Text.Replace(" ", "").Length != 10)
            {
                MessageBox.Show("The phone number must be valid (10 digits).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure to add the customer to the list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    listBox1.Items.Add(listBox1.Items.Count / 5 + 1);
                    listBox1.Items.Add("");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("");
                    string value = "Name and Family: " + textBox1.Text
                        + "Registering Date: " + monthCalendar1.SelectionStart.ToString().Substring(0, 10).Replace("-", "/")
                        + "Address: " + textBox2.Text
                        + "Tel: " + maskedTextBox1.Text
                        + "----------------------";
                    listBox2.Items.Add("Name and Family: " + textBox1.Text);
                    listBox2.Items.Add("Registering Date: " + monthCalendar1.SelectionStart.ToString().Substring(0, 10).Replace("-", "/"));
                    listBox2.Items.Add("Address: " + textBox2.Text);
                    listBox2.Items.Add("Tel: " + maskedTextBox1.Text);
                    listBox2.Items.Add("----------------------");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text= "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult response=MessageBox.Show("Are you sure to clear the list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response==DialogResult.Yes)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }
    }
}
