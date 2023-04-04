namespace Assignment2
{
    partial class PatientManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_mas = new System.Windows.Forms.RadioButton();
            this.radioButton_fem = new System.Windows.Forms.RadioButton();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_birthdate = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_mas);
            this.groupBox1.Controls.Add(this.radioButton_fem);
            this.groupBox1.Controls.Add(this.textBox_address);
            this.groupBox1.Controls.Add(this.button_exit);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_edit);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.button_new);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_code);
            this.groupBox1.Controls.Add(this.label_gender);
            this.groupBox1.Controls.Add(this.label_address);
            this.groupBox1.Controls.Add(this.label_birthdate);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Controls.Add(this.label_code);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Management";
            // 
            // radioButton_mas
            // 
            this.radioButton_mas.AutoSize = true;
            this.radioButton_mas.Location = new System.Drawing.Point(153, 302);
            this.radioButton_mas.Name = "radioButton_mas";
            this.radioButton_mas.Size = new System.Drawing.Size(94, 19);
            this.radioButton_mas.TabIndex = 17;
            this.radioButton_mas.TabStop = true;
            this.radioButton_mas.Text = "Masculine";
            this.radioButton_mas.UseVisualStyleBackColor = true;
            // 
            // radioButton_fem
            // 
            this.radioButton_fem.AutoSize = true;
            this.radioButton_fem.Location = new System.Drawing.Point(153, 266);
            this.radioButton_fem.Name = "radioButton_fem";
            this.radioButton_fem.Size = new System.Drawing.Size(85, 19);
            this.radioButton_fem.TabIndex = 1;
            this.radioButton_fem.TabStop = true;
            this.radioButton_fem.Text = "Feminine";
            this.radioButton_fem.UseVisualStyleBackColor = true;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(153, 183);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(215, 68);
            this.textBox_address.TabIndex = 16;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(476, 228);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(144, 23);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(476, 199);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(144, 23);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(476, 170);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(144, 23);
            this.button_edit.TabIndex = 13;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(476, 141);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(144, 23);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(476, 112);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(144, 23);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(476, 83);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(144, 23);
            this.button_new.TabIndex = 10;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 25);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(153, 89);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(215, 25);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(153, 45);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(215, 25);
            this.textBox_code.TabIndex = 5;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(16, 266);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(54, 15);
            this.label_gender.TabIndex = 4;
            this.label_gender.Text = "Gender";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(16, 186);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(60, 15);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Address";
            // 
            // label_birthdate
            // 
            this.label_birthdate.AutoSize = true;
            this.label_birthdate.Location = new System.Drawing.Point(16, 139);
            this.label_birthdate.Name = "label_birthdate";
            this.label_birthdate.Size = new System.Drawing.Size(71, 15);
            this.label_birthdate.TabIndex = 2;
            this.label_birthdate.Text = "Birth Date";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(16, 92);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(43, 15);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(16, 48);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(42, 15);
            this.label_code.TabIndex = 0;
            this.label_code.Text = "Code";
            // 
            // PatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientManagement";
            this.Text = "Patient_Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_birthdate;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.RadioButton radioButton_mas;
        private System.Windows.Forms.RadioButton radioButton_fem;
    }
}