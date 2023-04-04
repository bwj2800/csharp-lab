using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirst
{
    public partial class Form_Stores : Form
    {
        SalesEntities3 context = new SalesEntities3();
        public Form_Stores()
        {
            InitializeComponent();
        }

        private void Form_Stores_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var response = context.Stores.ToList();
            dataGridView1.DataSource = response;


            var result = from row in context.Stores
                         select new
                         {
                             row.StoreId,
                             row.Name,
                         };

            dataGridView1.DataSource = result.ToList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Stores store = new Stores();

            store.StoreId = Convert.ToInt32(textBox_id.Text);
            store.Name = textBox_name.Text;

            context.Stores.Add(store);
            context.SaveChanges();
            MessageBox.Show("New store added.");

            Display();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Stores store = context.Stores.Where(s => s.StoreId == id).First();

            DialogResult result = MessageBox.Show("Do you want to modify the store with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);
            //Modify the data
            if (result == DialogResult.OK)
            {
                store.Name = textBox_name.Text;
                context.SaveChanges();
                MessageBox.Show("Store modified.");
            }

            Display();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // Create id variable
            int id = Convert.ToInt32(textBox_id.Text);

            // Take the fist row in table with specific Id
            Stores store = context.Stores.Where(s => s.StoreId == id).First();

            DialogResult result = MessageBox.Show("Do you want to delete the store with id " + id + "?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                context.Stores.Remove(store);
                context.SaveChanges();
                MessageBox.Show("Store deleted.");
            }

            Display();
        }
    }
}
