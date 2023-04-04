using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment2
{
    public partial class AppointmentManagement : Form
    {
        public AppointmentManagement()
        {
            InitializeComponent();
        }

        private void AppointmentManagement_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var doctorQuery =
                from doctor in db.Doctors
                select doctor;
            var patientQuery =
                from patient in db.Patient
                select patient;
            
            foreach (var d in doctorQuery)
            {
                comboBox_doctorcode.Items.Add(d.DoctorId);
            }
            foreach (var p in patientQuery)
            {
                comboBox_patientcode.Items.Add(p.PatientId);
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            comboBox_doctorcode.Text = "";
            comboBox_patientcode.Text = "";
            textBox_doctorname.Text = "";
            textBox_patientname.Text = "";
            radioButton_F.Checked = false;
            radioButton_M.Checked = false;
            textBox_doctorspeciality.Text = "";
            dateTimePicker1.Value= DateTime.Now;
            maskedTextBox_time.Text = "";

        }

        private void comboBox_patientcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Patient p = db.Patient.FirstOrDefault(pat => pat.PatientId.Equals(Int32.Parse(comboBox_patientcode.Text)));

            textBox_patientname.Text = p.PatientName;
            if (p.PatientGender == "Feminine")
            {
                radioButton_F.Checked = true;
                radioButton_M.Checked = false;
            }
            else
            {
                radioButton_F.Checked = false;
                radioButton_M.Checked = true;
            }
        }

        private void comboBox_doctorcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Doctors d = db.Doctors.FirstOrDefault(doc => doc.DoctorId.Equals(Int32.Parse(comboBox_doctorcode.Text)));

            textBox_doctorname.Text = d.DoctorName;
            textBox_doctorspeciality.Text = d.DoctorSpecialism;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int hour=0;
            int minute=0;
            //Check if codes are empty
            if (String.IsNullOrEmpty(comboBox_doctorcode.Text)
                || String.IsNullOrEmpty(comboBox_patientcode.Text))
            {
                MessageBox.Show("Fields should not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Check if the time input is valid
            else if (maskedTextBox_time.Text.Replace(" ", "").Length != 5
                || !int.TryParse(maskedTextBox_time.Text.Substring(0, 2), out hour)
                || !int.TryParse(maskedTextBox_time.Text.Substring(3), out minute)
                || hour < 0 || hour > 23
                || minute < 0 || minute > 59)
            {
                MessageBox.Show("Input the valid time.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //Add new appointment
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                Appointments a = new Appointments();
                a.AppointmentDate = Convert.ToDateTime(dateTimePicker1.Text);
                a.AppointmentTime = new TimeSpan(hour, minute, 0);
                a.DoctorId = Int32.Parse(comboBox_doctorcode.Text);
                a.PatientId = Int32.Parse(comboBox_patientcode.Text);

                db.Appointments.InsertOnSubmit(a);
                db.SubmitChanges();

                MessageBox.Show("New appointment is added.");
                comboBox_doctorcode.Text = "";
                comboBox_patientcode.Text = "";
                textBox_doctorname.Text = "";
                textBox_patientname.Text = "";
                radioButton_F.Checked = false;
                radioButton_M.Checked = false;
                textBox_doctorspeciality.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                maskedTextBox_time.Text = "";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure to close the Doctor Management page?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes) //Checking the response
            {
                this.Close();
            }
        }
    }
}
