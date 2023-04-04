using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void doctorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorManagement doctorManagement = new DoctorManagement();
            doctorManagement.Show();
        }

        private void patientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientManagement patientManagement = new PatientManagement();
            patientManagement.Show();
        }

        private void appointmentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentManagement appointmentManagement = new AppointmentManagement();
            appointmentManagement.Show();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAll showAll = new ShowAll();
            showAll.Show();
        }

        private void searchAppointmentByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAppointment searchAppointment = new SearchAppointment();
            searchAppointment.Show();
        }

        private void showAPatientsAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPatientsAppointment showPatientsAppointment= new ShowPatientsAppointment();
            showPatientsAppointment.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure to close the Doctor Management page?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes) //Checking the response
            {
                this.Close();
            }
        }
    }
}
