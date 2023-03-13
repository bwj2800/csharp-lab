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
        int mode = 0;
        //0:none
        //1:add
        //2:edit
        //3:delete
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var dbStudentsQuery =
                from s in db.Students
                select s;

            DataTable table = new DataTable();
            
            if (textBox1.Text != "" && comboBox1.SelectedItem.ToString().Equals("StudentId"))
            {
                dbStudentsQuery =
                from s in db.Students
                where s.ID == Int32.Parse(textBox1.Text)
                select s;
            }
            else if (textBox1.Text != "" && comboBox1.SelectedItem.ToString().Equals("Grade"))
            {
                dbStudentsQuery =
                from s in db.Students
                where s.Grade == Double.Parse(textBox1.Text)
                select s;
            }
            else if (textBox1.Text != "" && comboBox1.SelectedItem.ToString().Equals("Name"))
            {
                dbStudentsQuery =
                from s in db.Students
                where s.Name.Contains(textBox1.Text)
                select s;
            }
            else if (textBox1.Text != "" && comboBox1.SelectedItem.ToString().Equals("Family"))
            {
                dbStudentsQuery =
                from s in db.Students
                where s.Family.Contains(textBox1.Text)
                select s;
            }

            if (checkBox1.Checked)
            {
                if (textBox2.Text != "" && comboBox2.SelectedItem.ToString().Equals("StudentId"))
                {
                    dbStudentsQuery =
                    (from s in db.Students
                    where s.ID == Int32.Parse(textBox2.Text)
                    select s).Intersect(dbStudentsQuery);
                }
                else if (textBox2.Text != "" && comboBox2.SelectedItem.ToString().Equals("Grade"))
                {
                    dbStudentsQuery =
                    (from s in db.Students
                    where s.Grade == Double.Parse(textBox2.Text)
                    select s).Intersect(dbStudentsQuery);
                }
                else if (textBox2.Text != "" && comboBox2.SelectedItem.ToString().Equals("Name"))
                {
                    dbStudentsQuery =
                    (from s in db.Students
                    where s.Name.Contains(textBox2.Text)
                    select s).Intersect(dbStudentsQuery);
                }
                else if (textBox2.Text != "" && comboBox2.SelectedItem.ToString().Equals("Family"))
                {
                    dbStudentsQuery =
                    (from s in db.Students
                    where s.Family.Contains(textBox2.Text)
                    select s).Intersect(dbStudentsQuery);
                }
            }

            table.Columns.Add("StudentId", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Family", typeof(string));
            table.Columns.Add("Grade", typeof(string));

            foreach (var s in dbStudentsQuery)
            {
                table.Rows.Add(s.ID, s.Name, s.Family, s.Grade);
            }
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox3.Enabled = false;
            mode = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            if (textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                if (mode == 1)
                {
                    Students student = new Students();
                    student.Grade = Double.Parse(textBox4.Text);
                    student.Family = textBox5.Text;
                    student.Name = textBox6.Text;
                    db.Students.InsertOnSubmit(student);
                    db.SubmitChanges();
                }
                else if (mode == 2)
                {
                    Students student = db.Students.First(s => s.ID.Equals(Int32.Parse(textBox3.Text)));
                    student.Grade = Double.Parse(textBox4.Text);
                    student.Family = textBox5.Text;
                    student.Name = textBox6.Text;
                    db.SubmitChanges();
                }
                else if (mode == 3)
                {
                    Students student = db.Students.First(s => s.ID.Equals(Int32.Parse(textBox3.Text)));
                    db.Students.DeleteOnSubmit(student);
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Select the mode.");
                }
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                mode = 0;
                textBox3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fill the text box or select the row.");
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            mode = 0;
            textBox3.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Enabled = false;
        }
    }
}
