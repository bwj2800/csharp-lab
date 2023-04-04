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

namespace Assignment2
{
    public partial class ShowAll : Form
    {
        public ShowAll()
        {
            InitializeComponent();
        }

        private void ShowAll_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            DataTable table = new DataTable();
            

            if (radioButton_doctors.Checked==true)
            {
                var Query =
                    from doctor in db.Doctors
                    select doctor;

                table.Columns.Add("Code", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Telephone", typeof(string));
                table.Columns.Add("Hiring Date", typeof(DateTime));
                table.Columns.Add("Speciality", typeof(string));
                foreach (var d in Query)
                {
                    table.Rows.Add(d.DoctorId, d.DoctorName, d.DoctorTel, d.HiringDate, d.DoctorSpecialism);
                }
            }
            else if(radioButton_patients.Checked==true)
            {
                var Query =
                    from patient in db.Patient
                    select patient;

                table.Columns.Add("Code", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Birth Date", typeof(DateTime));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("Gender", typeof(string));
                foreach (var p in Query)
                {
                    table.Rows.Add(p.PatientId, p.PatientName, p.BirthDate, p.PatientAddress, p.PatientGender);
                }
            }
            else
            {
                var Query =
                    from appointment in db.Appointments
                    select appointment;

                table.Columns.Add("Code", typeof(int));
                table.Columns.Add("Date", typeof(DateTime));
                table.Columns.Add("Time", typeof(string));
                table.Columns.Add("Doctor Code", typeof(string));
                table.Columns.Add("Patient Code", typeof(string));
                foreach (var a in Query)
                {
                    table.Rows.Add(a.AppointmentCode, a.AppointmentDate, a.AppointmentTime.ToString().Substring(0,5), a.DoctorId, a.PatientId);
                }
            }

            dataGridView1.DataSource = table;
        }

        private void radioButton_doctors_CheckedChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            DataTable table = new DataTable();
            var Query =
                from doctor in db.Doctors
                select doctor;

            table.Columns.Add("Code", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Hiring Date", typeof(DateTime));
            table.Columns.Add("Speciality", typeof(string));
            foreach (var d in Query)
            {
                table.Rows.Add(d.DoctorId, d.DoctorName, d.DoctorTel, d.HiringDate, d.DoctorSpecialism);
            }
            dataGridView1.DataSource = table;
        }

        private void radioButton_patients_CheckedChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            DataTable table = new DataTable();
            var Query =
                    from patient in db.Patient
                    select patient;

            table.Columns.Add("Code", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Birth Date", typeof(DateTime));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            foreach (var p in Query)
            {
                table.Rows.Add(p.PatientId, p.PatientName, p.BirthDate, p.PatientAddress, p.PatientGender);
            }
            dataGridView1.DataSource = table;
        }

        private void radioButton_appointments_CheckedChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            DataTable table = new DataTable();
            var Query =
                    from appointment in db.Appointments
                    select appointment;

            table.Columns.Add("Code", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Time", typeof(string));
            table.Columns.Add("Doctor Code", typeof(string));
            table.Columns.Add("Patient Code", typeof(string));
            foreach (var a in Query)
            {
                table.Rows.Add(a.AppointmentCode, a.AppointmentDate, a.AppointmentTime.ToString().Substring(0, 5), a.DoctorId, a.PatientId);
            }
            dataGridView1.DataSource = table;
        }
    }
}
