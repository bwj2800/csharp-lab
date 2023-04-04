using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFirst
{
    public partial class Form_Department : Form
    {
        Model1Container context = new Model1Container();
        public Form_Department()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void Display()
        {
            var result = from row in context.DepartmentSet
                         select new
                         {
                             row.DepartmentId,
                             row.DepartmentName,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Department dpt = new Department();

            dpt.DepartmentName = textBox_name.Text;

            context.DepartmentSet.Add(dpt);
            context.SaveChanges();
            MessageBox.Show("New department added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_departmentid.Text);

            // Take the fist row in table with specific Id
            Department dpt = context.DepartmentSet.Where(s => s.DepartmentId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the department with department id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                dpt.DepartmentName = textBox_name.Text;
                context.SaveChanges();
                MessageBox.Show("Department modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_departmentid.Text);

            // Take the fist row in table with specific Id
            Department dpt = context.DepartmentSet.Where(s => s.DepartmentId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the department with department id " + id + "?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                context.DepartmentSet.Remove(dpt);
                context.SaveChanges();
                MessageBox.Show("Department deleted.");
            }

            Display();
        }
    }
}
