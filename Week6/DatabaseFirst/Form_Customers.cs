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

namespace DatabaseFirst
{
    public partial class Form_Customers : Form
    {
        SalesEntities3 context = new SalesEntities3();
        public Form_Customers()
        {
            InitializeComponent();
        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var response = context.Customers.ToList();
            dataGridView1.DataSource = response;


            var result = from row in context.Customers
                         select new
                         {
                             row.CustomerId,
                             row.CreditCardNumber,
                             row.Email,
                             row.Name,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();

            customer.CustomerId = Convert.ToInt32(textBox_id.Text);
            customer.CreditCardNumber = maskedTextBox1.Text;
            customer.Email = textBox_email.Text;
            customer.Name = textBox_name.Text;

            context.Customers.Add(customer);
            context.SaveChanges();
            MessageBox.Show("New customer added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Customers customer = context.Customers.Where(s => s.CustomerId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the customer with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                customer.CreditCardNumber = maskedTextBox1.Text;
                customer.Email = textBox_email.Text;
                customer.Name = textBox_name.Text;
                context.SaveChanges();
                MessageBox.Show("Customer modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Customers customer = context.Customers.Where(s => s.CustomerId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the customer with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
                MessageBox.Show("Customer deleted.");
            }

            Display();
        }
    }
}
