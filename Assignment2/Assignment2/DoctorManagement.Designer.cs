namespace Assignment2
{
    partial class DoctorManagement
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
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_speciality = new System.Windows.Forms.ComboBox();
            this.label_code = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_telephone = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_hiringdate = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_speciality = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.button_new = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_telephone);
            this.groupBox1.Controls.Add(this.comboBox_speciality);
            this.groupBox1.Controls.Add(this.label_code);
            this.groupBox1.Controls.Add(this.button_exit);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.label_telephone);
            this.groupBox1.Controls.Add(this.button_edit);
            this.groupBox1.Controls.Add(this.label_hiringdate);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.label_speciality);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.textBox_code);
            this.groupBox1.Controls.Add(this.button_new);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Management";
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(156, 132);
            this.maskedTextBox_telephone.Mask = "00 00 00 00 00";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(215, 25);
            this.maskedTextBox_telephone.TabIndex = 34;
            // 
            // comboBox_speciality
            // 
            this.comboBox_speciality.FormattingEnabled = true;
            this.comboBox_speciality.Items.AddRange(new object[] {
            "Family Medicine",
            "Otolaryngology",
            "Dermatology",
            "Ophthalmology",
            "Pediatrics",
            "Psychiatry"});
            this.comboBox_speciality.Location = new System.Drawing.Point(156, 225);
            this.comboBox_speciality.Name = "comboBox_speciality";
            this.comboBox_speciality.Size = new System.Drawing.Size(215, 23);
            this.comboBox_speciality.TabIndex = 33;
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.Location = new System.Drawing.Point(19, 44);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(42, 15);
            this.label_code.TabIndex = 18;
            this.label_code.Text = "Code";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(479, 224);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(144, 22);
            this.button_exit.TabIndex = 31;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(19, 88);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(43, 15);
            this.label_name.TabIndex = 19;
            this.label_name.Text = "Name";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(479, 195);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(144, 22);
            this.button_delete.TabIndex = 30;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(19, 135);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(75, 15);
            this.label_telephone.TabIndex = 20;
            this.label_telephone.Text = "Telephone";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(479, 166);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(144, 22);
            this.button_edit.TabIndex = 29;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label_hiringdate
            // 
            this.label_hiringdate.AutoSize = true;
            this.label_hiringdate.Location = new System.Drawing.Point(19, 182);
            this.label_hiringdate.Name = "label_hiringdate";
            this.label_hiringdate.Size = new System.Drawing.Size(78, 15);
            this.label_hiringdate.TabIndex = 21;
            this.label_hiringdate.Text = "Hiring Date";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(479, 137);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(144, 22);
            this.button_add.TabIndex = 28;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_speciality
            // 
            this.label_speciality.AutoSize = true;
            this.label_speciality.Location = new System.Drawing.Point(19, 228);
            this.label_speciality.Name = "label_speciality";
            this.label_speciality.Size = new System.Drawing.Size(70, 15);
            this.label_speciality.TabIndex = 22;
            this.label_speciality.Text = "Speciality";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(479, 108);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(144, 22);
            this.button_search.TabIndex = 27;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(156, 41);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(215, 25);
            this.textBox_code.TabIndex = 23;
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(479, 79);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(144, 22);
            this.button_new.TabIndex = 26;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(156, 85);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(215, 25);
            this.textBox_name.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 25);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // DoctorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 340);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoctorManagement";
            this.Text = "Doctor_Management";
            this.Load += new System.EventHandler(this.DoctorManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_speciality;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label_speciality;
        private System.Windows.Forms.Label label_hiringdate;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
    }
}