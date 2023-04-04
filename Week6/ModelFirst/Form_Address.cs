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
    public partial class Form_Address : Form
    {
        Model1Container context = new Model1Container();
        public Form_Address()
        {
            InitializeComponent();
        }

        private void Form_Address_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var result = from row in context.AddressSet
                         select new
                         {
                             row.AddressId,
                             row.Address_,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Address address = new Address();

            address.Address_ = textBox_address.Text;

            context.AddressSet.Add(address);
            context.SaveChanges();
            MessageBox.Show("New address added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Address address = context.AddressSet.Where(s => s.AddressId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the address with address id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                address.Address_ = textBox_address.Text;
                context.SaveChanges();
                MessageBox.Show("Address modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Address address = context.AddressSet.Where(s => s.AddressId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the address with address id " + id + "?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                context.AddressSet.Remove(address);
                context.SaveChanges();
                MessageBox.Show("Address deleted.");
            }

            Display();
        }
    }
}
