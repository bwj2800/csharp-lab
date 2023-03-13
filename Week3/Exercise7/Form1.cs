using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sec = 0;
        string id = "id";
        string password = "password";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == id && textBox2.Text == password)
            {
                timer1.Enabled = false;
                DialogResult response = MessageBox.Show("Welcome!", "Login Success", MessageBoxButtons.OK);
                if (response == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Wrong code", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec==30)
            {
                timer1.Enabled=false;
                progressBar1.Value = 0;
                DialogResult response = MessageBox.Show("Time is over", "Login Failed", MessageBoxButtons.OK);
                if (response == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                progressBar1.Value -= 100 / 30;
            }
        }
    }
}
