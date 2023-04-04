using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        Model1 context = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var result = from row in context.Students
                         select new
                         {
                             row.StudentId,
                             row.Name,
                             row.PhoneNumber,
                             row.Birthday,
                             row.RegisteredOn,
                         };

            dataGridView1.DataSource = result.ToList();
            //dataGridView1.DataSource = context.Students.ToList();
            dataGridView2.DataSource = context.Courses.ToList();
        }

        private void button_addStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.PhoneNumber = textBox_phonenum.Text;
            student.Name = textBox_studentname.Text;
            student.Birthday = dateTime_start.Value;
            student.RegisteredOn = Int32.Parse(textBox_registeredon.Text);

            context.Students.Add(student);
            context.SaveChanges();
            MessageBox.Show("New student added.");

            Display();
        }

        private void button_addCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();

            course.description=textBox_desc.Text;
            course.Name = textBox_coursename.Text;
            course.StartDate = dateTime_start.Value; 
            course.EndDate = dateTime_end.Value;
            course.Price = float.Parse(textBox_price.Text);

            context.Courses.Add(course);
            context.SaveChanges();
            MessageBox.Show("New course added.");

            Display();
        }

        private void button_editStudent_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_studentid.Text);

            // Take the fist row in table with specific Id
            Student student = context.Students.Where(s => s.StudentId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the student with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                student.PhoneNumber = textBox_phonenum.Text;
                student.Name = textBox_studentname.Text;
                student.Birthday = dateTime_start.Value;
                student.RegisteredOn = Int32.Parse(textBox_registeredon.Text);
                context.SaveChanges();
                MessageBox.Show("Student modified.");
            }

            Display();
        }

        private void button_editCourse_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_courseid.Text);

            // Take the fist row in table with specific Id
            Course course = context.Courses.Where(s => s.CourseId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the course with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                course.description = textBox_desc.Text;
                course.Name = textBox_coursename.Text;
                course.StartDate = dateTime_start.Value;
                course.EndDate = dateTime_end.Value;
                course.Price = float.Parse(textBox_price.Text);
                context.SaveChanges();
                MessageBox.Show("Course modified.");
            }

            Display();
        }

        private void button_deleteStudent_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_studentid.Text);

            // Take the fist row in table with specific Id
            Student student = context.Students.Where(s => s.StudentId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the student with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                MessageBox.Show("Student deleted.");
            }

            Display();
        }

        private void button_deleteCourse_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_courseid.Text);

            // Take the fist row in table with specific Id
            Course course = context.Courses.Where(s => s.CourseId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the course with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
                MessageBox.Show("Course deleted.");
            }

            Display();
        }
    }
}
