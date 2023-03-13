using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value==0)
            {
                timer1.Interval = 1;
            }
            else
            {
                timer1.Interval = trackBar1.Value * 100;
            }
            
            timer1.Enabled=true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BackColor==Color.Red)
            {
                BackColor = Color.Green;
                radioButton2.Checked= true;
            }
            else if (BackColor==Color.Green)
            {
                BackColor= Color.Blue;
                radioButton3.Checked = true;
            }
            else
            {
                BackColor= Color.Red;
                radioButton1.Checked = true;
            }
        }
    }
}
