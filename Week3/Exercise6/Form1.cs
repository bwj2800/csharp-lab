using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ms=0, sec=0, min=0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tour "+(listBox1.Items.Count+1)+":"+min.ToString("D2") + ":"+sec.ToString("D2") + ":"+ms.ToString("D2"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ms=0;
            sec=0; 
            min=0;
            label1.Text = min.ToString("D2");
            label2.Text = sec.ToString("D2");
            label3.Text = ms.ToString("D2");
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms++;
            if (ms == 100)
            {
                ms = 0;
                sec++;
            }
            if (sec == 60)
            {
                sec = 0;
                min++;
            }
            if (min == 100)
            {
                timer1.Enabled = false;
                ms = 0; sec = 0; min = 0;
            }
            label1.Text =min.ToString("D2");
            label2.Text= sec.ToString("D2");
            label3.Text = ms.ToString("D2");
        }
    }
}
