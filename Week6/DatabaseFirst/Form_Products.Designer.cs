namespace DatabaseFirst
{
    partial class Form_Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(409, 264);
            this.textBox_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(147, 25);
            this.textBox_quantity.TabIndex = 54;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(480, 316);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(76, 28);
            this.button_delete.TabIndex = 53;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Product ID:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 53);
            this.label1.TabIndex = 48;
            this.label1.Text = "Products";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(398, 316);
            this.button_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(76, 28);
            this.button_edit.TabIndex = 47;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(409, 235);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(147, 25);
            this.textBox_price.TabIndex = 46;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(127, 235);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(122, 25);
            this.textBox_id.TabIndex = 45;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(127, 264);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(122, 25);
            this.textBox_name.TabIndex = 44;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(316, 316);
            this.button_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(76, 28);
            this.button_insert.TabIndex = 43;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 112);
            this.dataGridView1.TabIndex = 42;
            // 
            // Form_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 375);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Products";
            this.Text = "Form_Products";
            this.Load += new System.EventHandler(this.Form_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}