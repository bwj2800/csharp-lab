namespace Assignment2
{
    partial class SearchAppointment
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
            this.button_ok = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_speciality = new System.Windows.Forms.TextBox();
            this.textBox_doctorname = new System.Windows.Forms.TextBox();
            this.label_speciality = new System.Windows.Forms.Label();
            this.label_doctorname = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_patientname = new System.Windows.Forms.TextBox();
            this.label_patientname = new System.Windows.Forms.Label();
            this.label_birthdate = new System.Windows.Forms.Label();
            this.textBox_birthdate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(39, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the date";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(567, 55);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(567, 26);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(667, 143);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_speciality);
            this.groupBox2.Controls.Add(this.textBox_doctorname);
            this.groupBox2.Controls.Add(this.label_speciality);
            this.groupBox2.Controls.Add(this.label_doctorname);
            this.groupBox2.Location = new System.Drawing.Point(39, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor";
            // 
            // textBox_speciality
            // 
            this.textBox_speciality.Location = new System.Drawing.Point(138, 66);
            this.textBox_speciality.Name = "textBox_speciality";
            this.textBox_speciality.Size = new System.Drawing.Size(153, 25);
            this.textBox_speciality.TabIndex = 5;
            // 
            // textBox_doctorname
            // 
            this.textBox_doctorname.Location = new System.Drawing.Point(138, 30);
            this.textBox_doctorname.Name = "textBox_doctorname";
            this.textBox_doctorname.Size = new System.Drawing.Size(153, 25);
            this.textBox_doctorname.TabIndex = 4;
            // 
            // label_speciality
            // 
            this.label_speciality.Location = new System.Drawing.Point(18, 69);
            this.label_speciality.Name = "label_speciality";
            this.label_speciality.Size = new System.Drawing.Size(75, 17);
            this.label_speciality.TabIndex = 1;
            this.label_speciality.Text = "Speciality";
            // 
            // label_doctorname
            // 
            this.label_doctorname.Location = new System.Drawing.Point(18, 33);
            this.label_doctorname.Name = "label_doctorname";
            this.label_doctorname.Size = new System.Drawing.Size(45, 15);
            this.label_doctorname.TabIndex = 0;
            this.label_doctorname.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_birthdate);
            this.groupBox3.Controls.Add(this.textBox_patientname);
            this.groupBox3.Controls.Add(this.label_patientname);
            this.groupBox3.Controls.Add(this.label_birthdate);
            this.groupBox3.Location = new System.Drawing.Point(393, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 111);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patient";
            // 
            // textBox_patientname
            // 
            this.textBox_patientname.Location = new System.Drawing.Point(137, 30);
            this.textBox_patientname.Name = "textBox_patientname";
            this.textBox_patientname.Size = new System.Drawing.Size(153, 25);
            this.textBox_patientname.TabIndex = 8;
            // 
            // label_patientname
            // 
            this.label_patientname.Location = new System.Drawing.Point(21, 33);
            this.label_patientname.Name = "label_patientname";
            this.label_patientname.Size = new System.Drawing.Size(45, 15);
            this.label_patientname.TabIndex = 6;
            this.label_patientname.Text = "Name";
            // 
            // label_birthdate
            // 
            this.label_birthdate.Location = new System.Drawing.Point(21, 69);
            this.label_birthdate.Name = "label_birthdate";
            this.label_birthdate.Size = new System.Drawing.Size(75, 17);
            this.label_birthdate.TabIndex = 7;
            this.label_birthdate.Text = "Birth Date";
            // 
            // textBox_birthdate
            // 
            this.textBox_birthdate.Location = new System.Drawing.Point(137, 66);
            this.textBox_birthdate.Name = "textBox_birthdate";
            this.textBox_birthdate.Size = new System.Drawing.Size(151, 25);
            this.textBox_birthdate.TabIndex = 9;
            this.textBox_birthdate.Text = "__ /__ /____";
            // 
            // SearchAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 468);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchAppointment";
            this.Text = "Search_Appointment";
            this.Load += new System.EventHandler(this.SearchAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_doctorname;
        private System.Windows.Forms.TextBox textBox_speciality;
        private System.Windows.Forms.TextBox textBox_doctorname;
        private System.Windows.Forms.Label label_speciality;
        private System.Windows.Forms.TextBox textBox_patientname;
        private System.Windows.Forms.Label label_patientname;
        private System.Windows.Forms.Label label_birthdate;
        private System.Windows.Forms.TextBox textBox_birthdate;
    }
}