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
    public partial class Form_Manager : Form
    {
        Model1Container context = new Model1Container();
        public Form_Manager()
        {
            InitializeComponent();
        }

        private void Form_Manager_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void Display()
        {
            var result = from row in context.ManagerSet
                         select new
                         {
                             row.Id,
                             row.Name,
                             row.DepartmentId,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Manager mng = new Manager();

            mng.Name = textBox_name.Text;
            mng.DepartmentId = Convert.ToInt32(textBox_departmentid.Text);

            context.ManagerSet.Add(mng);
            context.SaveChanges();
            MessageBox.Show("New manager added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Manager mng = context.ManagerSet.Where(s => s.Id == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the manager with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                mng.Name = textBox_name.Text;
                mng.DepartmentId = Convert.ToInt32(textBox_departmentid.Text);
                context.SaveChanges();
                MessageBox.Show("Manager modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Manager mng = context.ManagerSet.Where(s => s.Id == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the manager with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                context.ManagerSet.Remove(mng);
                context.SaveChanges();
                MessageBox.Show("Manager deleted.");
            }

            Display();
        }
    }
}
