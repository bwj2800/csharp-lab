using System;
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
    public partial class SearchAppointment : Form
    {
        public SearchAppointment()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void button_ok_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            
            //search for the appointments on input date
            var Query =
                from appointment in db.Appointments
                where appointment.AppointmentDate.Value == dateTimePicker1.Value
                select appointment;

            table.Clear();
            foreach (var a in Query)
            {
                table.Rows.Add(a.AppointmentCode, a.AppointmentDate, a.AppointmentTime.ToString().Substring(0, 5), a.DoctorId, a.PatientId);
            }
            dataGridView1.DataSource = table;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            textBox_doctorname.Text = "";
            textBox_speciality.Text = "";
            textBox_patientname.Text = "";
            textBox_birthdate.Text = "__ /__ /____";
            dateTimePicker1.Value = DateTime.Now;
            table.Clear();
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Doctors d = db.Doctors.FirstOrDefault(doc => doc.DoctorId.Equals(dataGridView1.SelectedRows[0].Cells[3].Value));
            Patient p = db.Patient.FirstOrDefault(pat => pat.PatientId.Equals(dataGridView1.SelectedRows[0].Cells[4].Value));

            //display the information of doctor and patient for an appointment that user selected
            textBox_doctorname.Text = d.DoctorName;
            textBox_speciality.Text = d.DoctorSpecialism;
            textBox_patientname.Text = p.PatientName;
            textBox_birthdate.Text = p.BirthDate.Value.ToString().Substring(0,10).Replace("-","/");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Doctors d = db.Doctors.FirstOrDefault(doc => doc.DoctorId.Equals(dataGridView1.SelectedRows[0].Cells[3].Value));
            Patient p = db.Patient.FirstOrDefault(pat => pat.PatientId.Equals(dataGridView1.SelectedRows[0].Cells[4].Value));

            //display the information of doctor and patient for an appointment that user selected
            textBox_doctorname.Text = d.DoctorName;
            textBox_speciality.Text = d.DoctorSpecialism;
            textBox_patientname.Text = p.PatientName;
            textBox_birthdate.Text = p.BirthDate.Value.ToString().Substring(0, 10).Replace("-", "/");
        }

        private void SearchAppointment_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Appointment Code", typeof(int));
            table.Columns.Add("Appointment Date", typeof(DateTime));
            table.Columns.Add("Appointment Time", typeof(string));
            table.Columns.Add("Doctor Code", typeof(int));
            table.Columns.Add("Patient Code", typeof(int));
        }
    }
}
