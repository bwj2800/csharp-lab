namespace Assignment2
{
    partial class ShowPatientsAppointment
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_patientcode = new System.Windows.Forms.TextBox();
            this.label_patientcode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_birthdate = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.label_birthdate = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_time = new System.Windows.Forms.MaskedTextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_doctorcode = new System.Windows.Forms.ComboBox();
            this.textBox_appointmentcode = new System.Windows.Forms.TextBox();
            this.label_doctorcode = new System.Windows.Forms.Label();
            this.label_appointmenttime = new System.Windows.Forms.Label();
            this.label_appointmentdate = new System.Windows.Forms.Label();
            this.label_appointmentcode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.textBox_patientcode);
            this.groupBox1.Controls.Add(this.label_patientcode);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Patient Code";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(726, 56);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(81, 36);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(726, 16);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(81, 36);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_patientcode
            // 
            this.textBox_patientcode.Location = new System.Drawing.Point(140, 42);
            this.textBox_patientcode.Name = "textBox_patientcode";
            this.textBox_patientcode.Size = new System.Drawing.Size(214, 25);
            this.textBox_patientcode.TabIndex = 9;
            // 
            // label_patientcode
            // 
            this.label_patientcode.AutoSize = true;
            this.label_patientcode.Location = new System.Drawing.Point(7, 45);
            this.label_patientcode.Name = "label_patientcode";
            this.label_patientcode.Size = new System.Drawing.Size(92, 15);
            this.label_patientcode.TabIndex = 0;
            this.label_patientcode.Text = "Patient Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_address);
            this.groupBox2.Controls.Add(this.textBox_birthdate);
            this.groupBox2.Controls.Add(this.textBox_name);
            this.groupBox2.Controls.Add(this.label_address);
            this.groupBox2.Controls.Add(this.label_birthdate);
            this.groupBox2.Controls.Add(this.label_name);
            this.groupBox2.Location = new System.Drawing.Point(26, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Info";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(504, 29);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(214, 55);
            this.textBox_address.TabIndex = 12;
            // 
            // textBox_birthdate
            // 
            this.textBox_birthdate.Location = new System.Drawing.Point(140, 59);
            this.textBox_birthdate.Name = "textBox_birthdate";
            this.textBox_birthdate.Size = new System.Drawing.Size(214, 25);
            this.textBox_birthdate.TabIndex = 11;
            this.textBox_birthdate.Text = "__ /__ /____";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(140, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(214, 25);
            this.textBox_name.TabIndex = 10;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(410, 32);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(60, 15);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Address";
            // 
            // label_birthdate
            // 
            this.label_birthdate.AutoSize = true;
            this.label_birthdate.Location = new System.Drawing.Point(7, 62);
            this.label_birthdate.Name = "label_birthdate";
            this.label_birthdate.Size = new System.Drawing.Size(74, 15);
            this.label_birthdate.TabIndex = 2;
            this.label_birthdate.Text = "Birth_Date";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(7, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(43, 15);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(684, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox_time);
            this.groupBox3.Controls.Add(this.button_delete);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.button_save);
            this.groupBox3.Controls.Add(this.comboBox_doctorcode);
            this.groupBox3.Controls.Add(this.textBox_appointmentcode);
            this.groupBox3.Controls.Add(this.label_doctorcode);
            this.groupBox3.Controls.Add(this.label_appointmenttime);
            this.groupBox3.Controls.Add(this.label_appointmentdate);
            this.groupBox3.Controls.Add(this.label_appointmentcode);
            this.groupBox3.Location = new System.Drawing.Point(26, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment";
            // 
            // maskedTextBox_time
            // 
            this.maskedTextBox_time.Location = new System.Drawing.Point(504, 25);
            this.maskedTextBox_time.Mask = "00:00";
            this.maskedTextBox_time.Name = "maskedTextBox_time";
            this.maskedTextBox_time.Size = new System.Drawing.Size(214, 25);
            this.maskedTextBox_time.TabIndex = 14;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(744, 57);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(81, 36);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 25);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(744, 17);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(81, 36);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_doctorcode
            // 
            this.comboBox_doctorcode.FormattingEnabled = true;
            this.comboBox_doctorcode.Location = new System.Drawing.Point(504, 63);
            this.comboBox_doctorcode.Name = "comboBox_doctorcode";
            this.comboBox_doctorcode.Size = new System.Drawing.Size(214, 23);
            this.comboBox_doctorcode.TabIndex = 3;
            // 
            // textBox_appointmentcode
            // 
            this.textBox_appointmentcode.Location = new System.Drawing.Point(140, 24);
            this.textBox_appointmentcode.Name = "textBox_appointmentcode";
            this.textBox_appointmentcode.Size = new System.Drawing.Size(214, 25);
            this.textBox_appointmentcode.TabIndex = 1;
            // 
            // label_doctorcode
            // 
            this.label_doctorcode.AutoSize = true;
            this.label_doctorcode.Location = new System.Drawing.Point(376, 66);
            this.label_doctorcode.Name = "label_doctorcode";
            this.label_doctorcode.Size = new System.Drawing.Size(91, 15);
            this.label_doctorcode.TabIndex = 7;
            this.label_doctorcode.Text = "Doctor Code";
            // 
            // label_appointmenttime
            // 
            this.label_appointmenttime.AutoSize = true;
            this.label_appointmenttime.Location = new System.Drawing.Point(376, 31);
            this.label_appointmenttime.Name = "label_appointmenttime";
            this.label_appointmenttime.Size = new System.Drawing.Size(122, 15);
            this.label_appointmenttime.TabIndex = 6;
            this.label_appointmenttime.Text = "Appointment Time";
            // 
            // label_appointmentdate
            // 
            this.label_appointmentdate.AutoSize = true;
            this.label_appointmentdate.Location = new System.Drawing.Point(7, 66);
            this.label_appointmentdate.Name = "label_appointmentdate";
            this.label_appointmentdate.Size = new System.Drawing.Size(122, 15);
            this.label_appointmentdate.TabIndex = 5;
            this.label_appointmentdate.Text = "Appointment Date";
            // 
            // label_appointmentcode
            // 
            this.label_appointmentcode.AutoSize = true;
            this.label_appointmentcode.Location = new System.Drawing.Point(7, 31);
            this.label_appointmentcode.Name = "label_appointmentcode";
            this.label_appointmentcode.Size = new System.Drawing.Size(127, 15);
            this.label_appointmentcode.TabIndex = 4;
            this.label_appointmentcode.Text = "Appointment Code";
            // 
            // ShowPatientsAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 543);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowPatientsAppointment";
            this.Text = "Show_Patients_Appointment";
            this.Load += new System.EventHandler(this.ShowPatientsAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_patientcode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_birthdate;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_appointmentcode;
        private System.Windows.Forms.Label label_doctorcode;
        private System.Windows.Forms.Label label_appointmenttime;
        private System.Windows.Forms.Label label_appointmentdate;
        private System.Windows.Forms.Label label_appointmentcode;
        private System.Windows.Forms.TextBox textBox_patientcode;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_birthdate;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_doctorcode;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_time;
    }
}