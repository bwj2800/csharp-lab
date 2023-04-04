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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseFirst
{
    public partial class Form_Sales : Form
    {
        SalesEntities3 context = new SalesEntities3();
        public Form_Sales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var response = context.Sales.ToList();
            dataGridView1.DataSource = response;


            var result = from row in context.Sales
                         select new
                         {
                             row.SaleId,
                             row.Date,
                             row.CustomerId,
                             row.StoreId,
                             row.ProductId,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();

            sale.SaleId = Convert.ToInt32(textBox_saleid.Text);
            sale.CustomerId = Convert.ToInt32(textBox_customerid.Text);
            sale.ProductId = Convert.ToInt32(textBox_productid.Text);
            sale.StoreId = Convert.ToInt32(textBox_storeid.Text);
            sale.Date = dateTimePicker1.Value;

            context.Sales.Add(sale);
            context.SaveChanges();
            MessageBox.Show("New sale added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_saleid.Text);

            // Take the fist row in table with specific Id
            Sales sale = context.Sales.Where(s => s.SaleId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the sale with sale id "+id+"?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                sale.CustomerId = Convert.ToInt32(textBox_customerid.Text);
                sale.ProductId = Convert.ToInt32(textBox_productid.Text);
                sale.StoreId = Convert.ToInt32(textBox_storeid.Text);
                sale.Date = dateTimePicker1.Value;
                context.SaveChanges();
                MessageBox.Show("Sale modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_saleid.Text);

            // Take the fist row in table with specific Id
            Sales sale = context.Sales.Where(s => s.SaleId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the sale with sale id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                context.Sales.Remove(sale);
                context.SaveChanges();
                MessageBox.Show("Sale deleted.");
            }

            Display();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Customers form = new Form_Customers();
            form.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Products form = new Form_Products();
            form.Show();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Stores form = new Form_Stores();
            form.Show();
        }
    }
}
