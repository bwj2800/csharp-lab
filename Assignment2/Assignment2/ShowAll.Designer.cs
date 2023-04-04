namespace Assignment2
{
    partial class ShowAll
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
            this.radioButton_doctors = new System.Windows.Forms.RadioButton();
            this.radioButton_patients = new System.Windows.Forms.RadioButton();
            this.radioButton_appointments = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_appointments);
            this.groupBox1.Controls.Add(this.radioButton_patients);
            this.groupBox1.Controls.Add(this.radioButton_doctors);
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choice";
            // 
            // radioButton_doctors
            // 
            this.radioButton_doctors.AutoSize = true;
            this.radioButton_doctors.Location = new System.Drawing.Point(17, 44);
            this.radioButton_doctors.Name = "radioButton_doctors";
            this.radioButton_doctors.Size = new System.Drawing.Size(123, 19);
            this.radioButton_doctors.TabIndex = 0;
            this.radioButton_doctors.TabStop = true;
            this.radioButton_doctors.Text = "All the doctors";
            this.radioButton_doctors.UseVisualStyleBackColor = true;
            this.radioButton_doctors.CheckedChanged += new System.EventHandler(this.radioButton_doctors_CheckedChanged);
            // 
            // radioButton_patients
            // 
            this.radioButton_patients.AutoSize = true;
            this.radioButton_patients.Location = new System.Drawing.Point(297, 44);
            this.radioButton_patients.Name = "radioButton_patients";
            this.radioButton_patients.Size = new System.Drawing.Size(124, 19);
            this.radioButton_patients.TabIndex = 1;
            this.radioButton_patients.TabStop = true;
            this.radioButton_patients.Text = "All the patients";
            this.radioButton_patients.UseVisualStyleBackColor = true;
            this.radioButton_patients.CheckedChanged += new System.EventHandler(this.radioButton_patients_CheckedChanged);
            // 
            // radioButton_appointments
            // 
            this.radioButton_appointments.AutoSize = true;
            this.radioButton_appointments.Location = new System.Drawing.Point(552, 44);
            this.radioButton_appointments.Name = "radioButton_appointments";
            this.radioButton_appointments.Size = new System.Drawing.Size(160, 19);
            this.radioButton_appointments.TabIndex = 2;
            this.radioButton_appointments.TabStop = true;
            this.radioButton_appointments.Text = "All the appointments";
            this.radioButton_appointments.UseVisualStyleBackColor = true;
            this.radioButton_appointments.CheckedChanged += new System.EventHandler(this.radioButton_appointments_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(753, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // ShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowAll";
            this.Text = "Show_All";
            this.Load += new System.EventHandler(this.ShowAll_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton_appointments;
        private System.Windows.Forms.RadioButton radioButton_patients;
        private System.Windows.Forms.RadioButton radioButton_doctors;
    }
}