namespace Assignment2
{
    partial class AppointmentManagement
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_time = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_appointmentime = new System.Windows.Forms.Label();
            this.label_appointmentdate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_doctorspeciality = new System.Windows.Forms.TextBox();
            this.textBox_doctorname = new System.Windows.Forms.TextBox();
            this.label_doctorspeciality = new System.Windows.Forms.Label();
            this.comboBox_doctorcode = new System.Windows.Forms.ComboBox();
            this.label_doctorname = new System.Windows.Forms.Label();
            this.label_doctorcode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_M = new System.Windows.Forms.RadioButton();
            this.radioButton_F = new System.Windows.Forms.RadioButton();
            this.textBox_patientname = new System.Windows.Forms.TextBox();
            this.comboBox_patientcode = new System.Windows.Forms.ComboBox();
            this.label_patientgender = new System.Windows.Forms.Label();
            this.label_patientname = new System.Windows.Forms.Label();
            this.label_patientcode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_exit);
            this.groupBox1.Controls.Add(this.button_new);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Management";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(551, 305);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(168, 23);
            this.button_exit.TabIndex = 18;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(551, 276);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(168, 23);
            this.button_new.TabIndex = 17;
            this.button_new.Text = "New";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(551, 247);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(168, 23);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "Add Appointment";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedTextBox_time);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label_appointmentime);
            this.groupBox4.Controls.Add(this.label_appointmentdate);
            this.groupBox4.Location = new System.Drawing.Point(16, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 116);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // maskedTextBox_time
            // 
            this.maskedTextBox_time.Location = new System.Drawing.Point(153, 69);
            this.maskedTextBox_time.Mask = "90:90";
            this.maskedTextBox_time.Name = "maskedTextBox_time";
            this.maskedTextBox_time.Size = new System.Drawing.Size(230, 25);
            this.maskedTextBox_time.TabIndex = 16;
            this.maskedTextBox_time.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 25);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label_appointmentime
            // 
            this.label_appointmentime.AutoSize = true;
            this.label_appointmentime.Location = new System.Drawing.Point(17, 72);
            this.label_appointmentime.Name = "label_appointmentime";
            this.label_appointmentime.Size = new System.Drawing.Size(122, 15);
            this.label_appointmentime.TabIndex = 14;
            this.label_appointmentime.Text = "Appointment Time";
            // 
            // label_appointmentdate
            // 
            this.label_appointmentdate.AutoSize = true;
            this.label_appointmentdate.Location = new System.Drawing.Point(17, 36);
            this.label_appointmentdate.Name = "label_appointmentdate";
            this.label_appointmentdate.Size = new System.Drawing.Size(122, 15);
            this.label_appointmentdate.TabIndex = 13;
            this.label_appointmentdate.Text = "Appointment Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_doctorspeciality);
            this.groupBox3.Controls.Add(this.textBox_doctorname);
            this.groupBox3.Controls.Add(this.label_doctorspeciality);
            this.groupBox3.Controls.Add(this.comboBox_doctorcode);
            this.groupBox3.Controls.Add(this.label_doctorname);
            this.groupBox3.Controls.Add(this.label_doctorcode);
            this.groupBox3.Location = new System.Drawing.Point(394, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // textBox_doctorspeciality
            // 
            this.textBox_doctorspeciality.Location = new System.Drawing.Point(162, 104);
            this.textBox_doctorspeciality.Name = "textBox_doctorspeciality";
            this.textBox_doctorspeciality.Size = new System.Drawing.Size(133, 25);
            this.textBox_doctorspeciality.TabIndex = 10;
            // 
            // textBox_doctorname
            // 
            this.textBox_doctorname.Location = new System.Drawing.Point(162, 67);
            this.textBox_doctorname.Name = "textBox_doctorname";
            this.textBox_doctorname.Size = new System.Drawing.Size(133, 25);
            this.textBox_doctorname.TabIndex = 9;
            // 
            // label_doctorspeciality
            // 
            this.label_doctorspeciality.AutoSize = true;
            this.label_doctorspeciality.Location = new System.Drawing.Point(19, 107);
            this.label_doctorspeciality.Name = "label_doctorspeciality";
            this.label_doctorspeciality.Size = new System.Drawing.Size(119, 15);
            this.label_doctorspeciality.TabIndex = 6;
            this.label_doctorspeciality.Text = "Doctor Speciality";
            // 
            // comboBox_doctorcode
            // 
            this.comboBox_doctorcode.FormattingEnabled = true;
            this.comboBox_doctorcode.Location = new System.Drawing.Point(162, 31);
            this.comboBox_doctorcode.Name = "comboBox_doctorcode";
            this.comboBox_doctorcode.Size = new System.Drawing.Size(133, 23);
            this.comboBox_doctorcode.TabIndex = 8;
            this.comboBox_doctorcode.SelectedIndexChanged += new System.EventHandler(this.comboBox_doctorcode_SelectedIndexChanged);
            // 
            // label_doctorname
            // 
            this.label_doctorname.AutoSize = true;
            this.label_doctorname.Location = new System.Drawing.Point(19, 70);
            this.label_doctorname.Name = "label_doctorname";
            this.label_doctorname.Size = new System.Drawing.Size(92, 15);
            this.label_doctorname.TabIndex = 5;
            this.label_doctorname.Text = "Doctor Name";
            // 
            // label_doctorcode
            // 
            this.label_doctorcode.AutoSize = true;
            this.label_doctorcode.Location = new System.Drawing.Point(19, 34);
            this.label_doctorcode.Name = "label_doctorcode";
            this.label_doctorcode.Size = new System.Drawing.Size(91, 15);
            this.label_doctorcode.TabIndex = 4;
            this.label_doctorcode.Text = "Doctor Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_M);
            this.groupBox2.Controls.Add(this.radioButton_F);
            this.groupBox2.Controls.Add(this.textBox_patientname);
            this.groupBox2.Controls.Add(this.comboBox_patientcode);
            this.groupBox2.Controls.Add(this.label_patientgender);
            this.groupBox2.Controls.Add(this.label_patientname);
            this.groupBox2.Controls.Add(this.label_patientcode);
            this.groupBox2.Location = new System.Drawing.Point(16, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_M
            // 
            this.radioButton_M.AutoSize = true;
            this.radioButton_M.Location = new System.Drawing.Point(160, 135);
            this.radioButton_M.Name = "radioButton_M";
            this.radioButton_M.Size = new System.Drawing.Size(40, 19);
            this.radioButton_M.TabIndex = 12;
            this.radioButton_M.TabStop = true;
            this.radioButton_M.Text = "M";
            this.radioButton_M.UseVisualStyleBackColor = true;
            // 
            // radioButton_F
            // 
            this.radioButton_F.AutoSize = true;
            this.radioButton_F.Location = new System.Drawing.Point(160, 105);
            this.radioButton_F.Name = "radioButton_F";
            this.radioButton_F.Size = new System.Drawing.Size(36, 19);
            this.radioButton_F.TabIndex = 11;
            this.radioButton_F.TabStop = true;
            this.radioButton_F.Text = "F";
            this.radioButton_F.UseVisualStyleBackColor = true;
            // 
            // textBox_patientname
            // 
            this.textBox_patientname.Location = new System.Drawing.Point(160, 67);
            this.textBox_patientname.Name = "textBox_patientname";
            this.textBox_patientname.Size = new System.Drawing.Size(133, 25);
            this.textBox_patientname.TabIndex = 7;
            // 
            // comboBox_patientcode
            // 
            this.comboBox_patientcode.FormattingEnabled = true;
            this.comboBox_patientcode.Location = new System.Drawing.Point(160, 31);
            this.comboBox_patientcode.Name = "comboBox_patientcode";
            this.comboBox_patientcode.Size = new System.Drawing.Size(133, 23);
            this.comboBox_patientcode.TabIndex = 4;
            this.comboBox_patientcode.SelectedIndexChanged += new System.EventHandler(this.comboBox_patientcode_SelectedIndexChanged);
            // 
            // label_patientgender
            // 
            this.label_patientgender.AutoSize = true;
            this.label_patientgender.Location = new System.Drawing.Point(16, 107);
            this.label_patientgender.Name = "label_patientgender";
            this.label_patientgender.Size = new System.Drawing.Size(104, 15);
            this.label_patientgender.TabIndex = 3;
            this.label_patientgender.Text = "Patient Gender";
            // 
            // label_patientname
            // 
            this.label_patientname.AutoSize = true;
            this.label_patientname.Location = new System.Drawing.Point(16, 70);
            this.label_patientname.Name = "label_patientname";
            this.label_patientname.Size = new System.Drawing.Size(93, 15);
            this.label_patientname.TabIndex = 2;
            this.label_patientname.Text = "Patient Name";
            // 
            // label_patientcode
            // 
            this.label_patientcode.AutoSize = true;
            this.label_patientcode.Location = new System.Drawing.Point(16, 34);
            this.label_patientcode.Name = "label_patientcode";
            this.label_patientcode.Size = new System.Drawing.Size(92, 15);
            this.label_patientcode.TabIndex = 1;
            this.label_patientcode.Text = "Patient Code";
            // 
            // AppointmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 412);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppointmentManagement";
            this.Text = "Appointment_Management";
            this.Load += new System.EventHandler(this.AppointmentManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_appointmentime;
        private System.Windows.Forms.Label label_appointmentdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_doctorspeciality;
        private System.Windows.Forms.TextBox textBox_doctorname;
        private System.Windows.Forms.Label label_doctorspeciality;
        private System.Windows.Forms.ComboBox comboBox_doctorcode;
        private System.Windows.Forms.Label label_doctorname;
        private System.Windows.Forms.Label label_doctorcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_M;
        private System.Windows.Forms.RadioButton radioButton_F;
        private System.Windows.Forms.TextBox textBox_patientname;
        private System.Windows.Forms.ComboBox comboBox_patientcode;
        private System.Windows.Forms.Label label_patientgender;
        private System.Windows.Forms.Label label_patientname;
        private System.Windows.Forms.Label label_patientcode;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_time;
    }
}