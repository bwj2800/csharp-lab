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
    public partial class Form_Employee : Form
    {
        Model1Container context = new Model1Container();
        public Form_Employee()
        {
            InitializeComponent();
        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var result = from row in context.ManagerSet.OfType<Employee>()
                         select new
                         {
                             row.Id,
                             row.Name,
                             row.DepartmentId,
                             row.Job,
                             row.ManagerId,
                             row.HireDate,
                             row.Salary,
                             row.AddressId,
                             row.ProjectId,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            emp.DepartmentId = Convert.ToInt32(textBox_departmentid.Text);
            emp.ManagerId = Convert.ToInt32(textBox_managerid.Text);
            emp.AddressId = Convert.ToInt32(textBox_addressid.Text);
            emp.ProjectId = Convert.ToInt32(textBox_projectid.Text);
            emp.HireDate = dateTimePicker1.Value;
            emp.Salary = Convert.ToInt32(textBox_salary.Text);
            emp.Job = textBox_job.Text;
            emp.Name = textBox_name.Text;

            context.ManagerSet.Add(emp);
            context.SaveChanges();
            MessageBox.Show("New employee added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Employee emp = context.ManagerSet.OfType<Employee>().Where(s => s.Id == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the employee with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                emp.DepartmentId = Convert.ToInt32(textBox_departmentid.Text);
                emp.ManagerId = Convert.ToInt32(textBox_managerid.Text);
                emp.AddressId = Convert.ToInt32(textBox_addressid.Text);
                emp.ProjectId = Convert.ToInt32(textBox_projectid.Text);
                emp.HireDate = dateTimePicker1.Value;
                emp.Salary = Convert.ToInt32(textBox_salary.Text);
                emp.Job = textBox_job.Text;
                emp.Name = textBox_name.Text;
                context.SaveChanges();
                MessageBox.Show("Employee modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Employee emp = context.ManagerSet.OfType<Employee>().Where(s => s.Id == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the employee with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                context.ManagerSet.Remove(emp);
                context.SaveChanges();
                MessageBox.Show("Employee deleted.");
            }

            Display();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Manager form = new Form_Manager();
            form.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Department form = new Form_Department();
            form.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Project form = new Form_Project();
            form.Show();
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Address form = new Form_Address();
            form.Show();
        }
    }
}
