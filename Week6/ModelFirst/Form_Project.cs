using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFirst
{
    public partial class Form_Project : Form
    {
        Model1Container context = new Model1Container();
        public Form_Project()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var result = from row in context.ProjectSet
                         select new
                         {
                             row.ProjectId,
                             row.ProjectName,
                             row.StartDate,
                             row.EndDate,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Project pjt = new Project();

            pjt.ProjectName = textBox_name.Text;
            pjt.StartDate = dateTimePicker_start.Value;
            pjt.EndDate = dateTimePicker_end.Value;

            context.ProjectSet.Add(pjt);
            context.SaveChanges();
            MessageBox.Show("New project added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Project pjt = context.ProjectSet.Where(s => s.ProjectId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the project with project id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                pjt.ProjectName = textBox_name.Text;
                pjt.StartDate = dateTimePicker_start.Value;
                pjt.EndDate = dateTimePicker_end.Value;
                context.SaveChanges();
                MessageBox.Show("Project modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Project pjt = context.ProjectSet.Where(s => s.ProjectId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the project with project id " + id + "?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                context.ProjectSet.Remove(pjt);
                context.SaveChanges();
                MessageBox.Show("Project deleted.");
            }

            Display();
        }
    }
}
