using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from left list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from right list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SetSelected(i, true);
                listBox1.Items.Add(listBox2.SelectedItem);
            }
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from left list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listBox1.SelectedIndex > 0)
                {
                    var temp = listBox1.Items[listBox1.SelectedIndex - 1];
                    listBox1.Items[listBox1.SelectedIndex-1]= listBox1.SelectedItem;
                    listBox1.Items[listBox1.SelectedIndex] = temp;

                    listBox1.SelectedIndex -= 1;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from left list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listBox1.SelectedIndex < listBox1.Items.Count-1)
                {
                    var temp = listBox1.Items[listBox1.SelectedIndex + 1];
                    listBox1.Items[listBox1.SelectedIndex + 1] = listBox1.SelectedItem;
                    listBox1.Items[listBox1.SelectedIndex] = temp;

                    listBox1.SelectedIndex += 1;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from right list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listBox2.SelectedIndex > 0)
                {
                    var temp = listBox2.Items[listBox2.SelectedIndex - 1];
                    listBox2.Items[listBox2.SelectedIndex - 1] = listBox2.SelectedItem;
                    listBox2.Items[listBox2.SelectedIndex] = temp;

                    listBox2.SelectedIndex -= 1;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from right list", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listBox2.SelectedIndex < listBox2.Items.Count - 1)
                {
                    var temp = listBox2.Items[listBox2.SelectedIndex + 1];
                    listBox2.Items[listBox2.SelectedIndex + 1] = listBox2.SelectedItem;
                    listBox2.Items[listBox2.SelectedIndex] = temp;

                    listBox2.SelectedIndex += 1;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ArrayList sort = new ArrayList();
            foreach (object item in listBox1.Items) sort.Add(item);
            sort.Sort();
            listBox1.Items.Clear();
            foreach (object sortList in sort) listBox1.Items.Add(sortList);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ArrayList sort = new ArrayList();
            foreach (object item in listBox2.Items) sort.Add(item);
            sort.Sort();
            listBox2.Items.Clear();
            foreach (object sortList in sort) listBox2.Items.Add(sortList);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ArrayList sort = new ArrayList();
            foreach (object item in listBox1.Items) sort.Add(item);
            sort.Sort();
            sort.Reverse();
            listBox1.Items.Clear();
            foreach (object sortList in sort) listBox1.Items.Add(sortList);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ArrayList sort = new ArrayList();
            foreach (object item in listBox2.Items) sort.Add(item);
            sort.Sort();
            sort.Reverse();
            listBox2.Items.Clear();
            foreach (object sortList in sort) listBox2.Items.Add(sortList);
        }
    }
}
