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
    public partial class PatientManagement : Form
    {
        public PatientManagement()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textBox_code.Text = "";
            textBox_name.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox_address.Text = "";
            radioButton_fem.Checked = true;
            radioButton_mas.Checked = false;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Check if the input of code is int-type
            if (!int.TryParse(textBox_code.Text, out int res))
            {
                MessageBox.Show("Enter the valid code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Patient p = db.Patient.FirstOrDefault(pat => pat.PatientId.Equals(Int32.Parse(textBox_code.Text)));

                if (p == null) // no patient data matching the patientId input
                {
                    MessageBox.Show("No result.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_name.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    textBox_address.Text = "";
                    radioButton_fem.Checked = true;
                    radioButton_mas.Checked = false;
                }
                else //showing result
                {
                    textBox_name.Text = p.PatientName;
                    dateTimePicker1.Value = p.BirthDate.Value;
                    textBox_address.Text = p.PatientAddress;
                    if (p.PatientGender.TrimEnd() == "Feminine")
                    {
                        radioButton_fem.Checked = true;
                        radioButton_mas.Checked = false;
                    }
                    else
                    {
                        radioButton_fem.Checked = false;
                        radioButton_mas.Checked = true;
                    }
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //Check if there's an empty fields
            if (String.IsNullOrEmpty(textBox_code.Text)
                || String.IsNullOrEmpty(textBox_name.Text)
                || String.IsNullOrEmpty(dateTimePicker1.Text)
                || String.IsNullOrEmpty(textBox_address.Text))
            {
                MessageBox.Show("Fields should not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Check if the input of code is int-type
            else if (!int.TryParse(textBox_code.Text, out int res))
            {
                MessageBox.Show("Enter the valid code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                var Query =
                    from pat in db.Patient
                    where pat.PatientId == Int32.Parse(textBox_code.Text)
                    select pat;

                // check if the patientId already exists
                if (Query.Count() > 0)
                {
                    MessageBox.Show("Patient Code already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Add new patient
                else
                {
                    Patient patient = new Patient();
                    patient.PatientId = Int32.Parse(textBox_code.Text);
                    patient.PatientName = textBox_name.Text.TrimEnd();
                    patient.BirthDate = Convert.ToDateTime(dateTimePicker1.Text);
                    patient.PatientAddress = textBox_address.Text;
                    if (radioButton_fem.Checked==true)
                    {
                        patient.PatientGender = "Feminine";
                    }
                    else
                    {
                        patient.PatientGender = "Masculine";
                    }
                    
                    db.Patient.InsertOnSubmit(patient);
                    db.SubmitChanges();

                    MessageBox.Show("New patient is added.");
                    textBox_code.Text = "";
                    textBox_name.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    textBox_address.Text = "";
                    radioButton_fem.Checked = true;
                    radioButton_mas.Checked = false;
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Check if the input of code is int-type
            if (!int.TryParse(textBox_code.Text, out int res))
            {
                MessageBox.Show("Enter the valid code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Patient patient = db.Patient.FirstOrDefault(pat => pat.PatientId.Equals(Int32.Parse(textBox_code.Text)));

                if (patient == null) // no patient data matching the input doctorId
                {
                    MessageBox.Show("Enter the valid patient code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DialogResult response = MessageBox.Show("Are you sure to edit the information of patient with patientId " + patient.PatientId + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes) //Checking the response
                    {
                        //Check if there's an empty fields
                        if (String.IsNullOrEmpty(textBox_code.Text)
                            || String.IsNullOrEmpty(textBox_name.Text)
                            || String.IsNullOrEmpty(dateTimePicker1.Text)
                            || String.IsNullOrEmpty(textBox_address.Text))
                        {
                            MessageBox.Show("Fields should not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else //Edit the patient information
                        {

                            patient.PatientName = textBox_name.Text;
                            patient.BirthDate = Convert.ToDateTime(dateTimePicker1.Text);
                            patient.PatientAddress = textBox_address.Text;
                            if (radioButton_fem.Checked == true)
                            {
                                patient.PatientGender = "Feminine";
                            }
                            else
                            {
                                patient.PatientGender = "Masculine";
                            }
                            db.SubmitChanges();

                            MessageBox.Show("Successfully Edited.");
                            textBox_code.Text = "";
                            textBox_name.Text = "";
                            dateTimePicker1.Value = DateTime.Now;
                            textBox_address.Text = "";
                            radioButton_fem.Checked = true;
                            radioButton_mas.Checked = false;
                        }
                    }
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Check if the input of code is int-type
            if (!int.TryParse(textBox_code.Text, out int res))
            {
                MessageBox.Show("Enter the valid code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Patient patient = db.Patient.FirstOrDefault(pat => pat.PatientId.Equals(Int32.Parse(textBox_code.Text)));

                if (patient == null) // no patient data matching the input doctorId
                {
                    MessageBox.Show("Enter the valid patient code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DialogResult response = MessageBox.Show("Are you sure to delete the information of patient with patientId " + patient.PatientId + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes) //Checking the response
                    {
                        db.Patient.DeleteOnSubmit(patient);
                        db.SubmitChanges();

                        MessageBox.Show("Successfully Deleted.");
                        textBox_code.Text = "";
                        textBox_name.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        textBox_address.Text = "";
                        radioButton_fem.Checked = true;
                        radioButton_mas.Checked = false;
                    }
                }
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
