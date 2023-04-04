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
    public partial class Form_Products : Form
    {
        SalesEntities3 context = new SalesEntities3();
        public Form_Products()
        {
            InitializeComponent();
        }

        private void Form_Products_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var response = context.Products.ToList();
            dataGridView1.DataSource = response;


            var result = from row in context.Products
                         select new
                         {
                             row.ProductId,
                             row.Name,
                             row.Price,
                             row.Quantity,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Products product = new Products();

            product.ProductId = Convert.ToInt32(textBox_id.Text);
            product.Name = textBox_name.Text;
            product.Price = Convert.ToInt32(textBox_price.Text);
            product.Quantity = Convert.ToInt32(textBox_quantity.Text);

            context.Products.Add(product);
            context.SaveChanges();
            MessageBox.Show("New product added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Products product = context.Products.Where(s => s.ProductId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the product with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                product.Name = textBox_name.Text;
                product.Price = Convert.ToInt32(textBox_price.Text);
                product.Quantity = Convert.ToInt32(textBox_quantity.Text);
                context.SaveChanges();
                MessageBox.Show("Product modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Products product = context.Products.Where(s => s.ProductId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the product with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                context.Products.Remove(product);
                context.SaveChanges();
                MessageBox.Show("Product deleted.");
            }

            Display();
        }
    }
}
