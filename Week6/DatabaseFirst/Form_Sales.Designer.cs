namespace DatabaseFirst
{
    partial class Form_Sales
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.textBox_storeid = new System.Windows.Forms.TextBox();
            this.textBox_saleid = new System.Windows.Forms.TextBox();
            this.textBox_customerid = new System.Windows.Forms.TextBox();
            this.button_insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_productid = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sale ID:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 53);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sales";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(637, 268);
            this.button_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(76, 28);
            this.button_edit.TabIndex = 15;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // textBox_storeid
            // 
            this.textBox_storeid.Location = new System.Drawing.Point(422, 236);
            this.textBox_storeid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_storeid.Name = "textBox_storeid";
            this.textBox_storeid.Size = new System.Drawing.Size(114, 25);
            this.textBox_storeid.TabIndex = 14;
            // 
            // textBox_saleid
            // 
            this.textBox_saleid.Location = new System.Drawing.Point(133, 236);
            this.textBox_saleid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_saleid.Name = "textBox_saleid";
            this.textBox_saleid.Size = new System.Drawing.Size(114, 25);
            this.textBox_saleid.TabIndex = 13;
            // 
            // textBox_customerid
            // 
            this.textBox_customerid.Location = new System.Drawing.Point(133, 265);
            this.textBox_customerid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_customerid.Name = "textBox_customerid";
            this.textBox_customerid.Size = new System.Drawing.Size(114, 25);
            this.textBox_customerid.TabIndex = 12;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(637, 236);
            this.button_insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(76, 28);
            this.button_insert.TabIndex = 11;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 112);
            this.dataGridView1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Store ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date:";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(637, 300);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(76, 28);
            this.button_delete.TabIndex = 22;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_productid
            // 
            this.textBox_productid.Location = new System.Drawing.Point(422, 265);
            this.textBox_productid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_productid.Name = "textBox_productid";
            this.textBox_productid.Size = new System.Drawing.Size(114, 25);
            this.textBox_productid.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 300);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.storesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.storesToolStripMenuItem.Text = "Stores";
            this.storesToolStripMenuItem.Click += new System.EventHandler(this.storesToolStripMenuItem_Click);
            // 
            // Form_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 351);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_productid);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_storeid);
            this.Controls.Add(this.textBox_saleid);
            this.Controls.Add(this.textBox_customerid);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Sales";
            this.Text = "Form_Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.TextBox textBox_storeid;
        private System.Windows.Forms.TextBox textBox_saleid;
        private System.Windows.Forms.TextBox textBox_customerid;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_productid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
    }
}

