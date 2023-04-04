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
    public partial class ShowPatientsAppointment : Form
    {
        public ShowPatientsAppointment()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void button_search_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Check if the input of code is int-type
            if (!int.TryParse(textBox_patientcode.Text, out int res))
            {
                MessageBox.Show("Enter the valid code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Patient p = db.Patient.FirstOrDefault(pat => pat.PatientId.Equals(Int32.Parse(textBox_patientcode.Text)));

                if (p == null) // no patient data matching the patientId input
                {
                    MessageBox.Show("No result.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_name.Text = "";
                    textBox_address.Text = "";
                    textBox_birthdate.Text = "__ /__ /____";
                    table.Clear();
                    dataGridView1.DataSource = table;
                    textBox_appointmentcode.Text = "";
                    maskedTextBox_time.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox_doctorcode.Text = "";
                }
                else //showing result
                {
                    //fill the patient info
                    textBox_name.Text = p.PatientName;
                    textBox_address.Text = p.PatientAddress;
                    textBox_birthdate.Text = p.BirthDate.Value.ToString().Substring(0, 10).Replace("-", "/");

                    //search for the patient's appointments
                    var Query =
                        from appointment in db.Appointments
                        where appointment.PatientId == Int32.Parse(textBox_patientcode.Text)
                        orderby appointment.AppointmentDate descending
                        select appointment;

                    table.Clear();
                    foreach (var a in Query)
                    {
                        table.Rows.Add(a.AppointmentCode, a.AppointmentDate, a.AppointmentTime.ToString().Substring(0, 5), a.DoctorId);
                    }
                    dataGridView1.DataSource = table;
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            textBox_patientcode.Text = "";
            textBox_name.Text = "";
            textBox_address.Text = "";
            textBox_birthdate.Text = "__ /__ /____";
            table.Clear();
            dataGridView1.DataSource = table;
            textBox_appointmentcode.Text = "";
            maskedTextBox_time.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox_doctorcode.Text = "";
        }


        private void ShowPatientsAppointment_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Appointment Code", typeof(int));
            table.Columns.Add("Appointment Date", typeof(DateTime));
            table.Columns.Add("Appointment Time", typeof(string));
            table.Columns.Add("Doctor Code", typeof(int));

            DataClasses1DataContext db = new DataClasses1DataContext();
            var doctorQuery =
                from doctor in db.Doctors
                select doctor;

            foreach (var d in doctorQuery)
            {
                comboBox_doctorcode.Items.Add(d.DoctorId);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when user clicks on the doctor code
            if (dataGridView1.SelectedCells[0].ColumnIndex==3)
            {
                DoctorManagement doctorManagement = new DoctorManagement(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                doctorManagement.Show();
            }
            //when user clicks on the appointment cells
            else
            {
                textBox_appointmentcode.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value);
                maskedTextBox_time.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                comboBox_doctorcode.Text= dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Check if the input of code is int-type
            if (!int.TryParse(textBox_appointmentcode.Text, out int res))
            {
                MessageBox.Show("Enter the valid appointment code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Appointments appointment = db.Appointments.FirstOrDefault(ap => ap.AppointmentCode.Equals(Int32.Parse(textBox_appointmentcode.Text)));

                if (appointment == null) // no appointment data matching the input code
                {
                    MessageBox.Show("Enter the valid appointment code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult response = MessageBox.Show("Are you sure to edit the information of appointment with appointment code " + appointment.AppointmentCode + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes) //Checking the response
                    {
                        int hour = 0;
                        int minute = 0;
                        //Check if there's an empty fields
                        if (String.IsNullOrEmpty(dateTimePicker1.Text)
                            || String.IsNullOrEmpty(comboBox_doctorcode.Text))
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
                        else //Edit the appointment information
                        {
                            appointment.AppointmentDate = Convert.ToDateTime(dateTimePicker1.Text);
                            appointment.AppointmentTime = new TimeSpan(hour, minute, 0);
                            appointment.DoctorId = Int32.Parse(comboBox_doctorcode.Text);
                            db.SubmitChanges();

                            MessageBox.Show("Successfully Edited.");
                        }
                    }
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Check if the input of code is int-type
            if (!int.TryParse(textBox_appointmentcode.Text, out int res))
            {
                MessageBox.Show("Enter the valid appointment code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Appointments appointment = db.Appointments.FirstOrDefault(ap => ap.AppointmentCode.Equals(Int32.Parse(textBox_appointmentcode.Text)));

                if (appointment == null) // no appointment data matching the input code
                {
                    MessageBox.Show("Enter the valid appointment code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult response = MessageBox.Show("Are you sure to delete the information of appointment with appointment code " + appointment.AppointmentCode + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes) //Checking the response
                    {
                        db.Appointments.DeleteOnSubmit(appointment);
                        db.SubmitChanges();

                        MessageBox.Show("Successfully Deleted.");
                    }
                }
            }
        }
    }
}
