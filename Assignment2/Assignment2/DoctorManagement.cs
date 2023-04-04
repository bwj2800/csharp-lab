using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment2
{
    public partial class DoctorManagement : Form
    {
        public DoctorManagement()
        {
            InitializeComponent();
        }

        public DoctorManagement(int docID)
        {
            InitializeComponent();
            DataClasses1DataContext db = new DataClasses1DataContext();

            Doctors d = db.Doctors.FirstOrDefault(doc => doc.DoctorId.Equals(docID));

            if (d == null) // no doctor data matching the doctorId
            {
                MessageBox.Show("No result.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_name.Text = "";
                maskedTextBox_telephone.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                comboBox_speciality.SelectedIndex = 0;
            }
            else //showing result
            {
                textBox_code.Text = d.DoctorId.ToString();
                textBox_name.Text = d.DoctorName;
                maskedTextBox_telephone.Text = d.DoctorTel;
                dateTimePicker1.Value = d.HiringDate.Value;
                comboBox_speciality.Text = d.DoctorSpecialism;
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textBox_code.Text = "";
            textBox_name.Text = "";
            maskedTextBox_telephone.Text = "";
            dateTimePicker1.Value= DateTime.Now;
            comboBox_speciality.SelectedIndex = 0;
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
                Doctors d = db.Doctors.FirstOrDefault(doc => doc.DoctorId.Equals(Int32.Parse(textBox_code.Text)));

                if (d == null) // no doctor data matching the doctorId input
                {
                    MessageBox.Show("No result.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_name.Text = "";
                    maskedTextBox_telephone.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox_speciality.SelectedIndex = 0;
                }
                else //showing result
                {
                    textBox_name.Text = d.DoctorName;
                    maskedTextBox_telephone.Text = d.DoctorTel;
                    dateTimePicker1.Value = d.HiringDate.Value;
                    comboBox_speciality.Text = d.DoctorSpecialism;
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //Check if there's an empty fields
            if (String.IsNullOrEmpty(textBox_code.Text) 
                || String.IsNullOrEmpty(textBox_name.Text) 
                || String.IsNullOrEmpty(dateTimePicker1.Text)) 
            {
                MessageBox.Show("Fields should not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Check if the input of code is int-type
            else if (!int.TryParse(textBox_code.Text, out int res))
            {
                MessageBox.Show("Enter the valid code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Check if the format of telephone input is correct
            else if (maskedTextBox_telephone.Text.Replace(" ", "").Length != 10) 
            {
                MessageBox.Show("The phone number must be valid (10 digits).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                var Query =
                    from doc in db.Doctors
                    where doc.DoctorId == Int32.Parse(textBox_code.Text)
                    select doc;

                // check if the doctorId already exists
                if (Query.Count()>0) 
                {
                    MessageBox.Show("Doctor Code already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Add new doctor
                else
                {
                    Doctors doctor = new Doctors();
                    doctor.DoctorId = Int32.Parse(textBox_code.Text);
                    doctor.DoctorName = textBox_name.Text;
                    doctor.DoctorTel = maskedTextBox_telephone.Text;
                    doctor.HiringDate = Convert.ToDateTime(dateTimePicker1.Text);
                    doctor.DoctorSpecialism = comboBox_speciality.Text;
                    db.Doctors.InsertOnSubmit(doctor);
                    db.SubmitChanges();

                    MessageBox.Show("New doctor is added.");
                    textBox_code.Text = "";
                    textBox_name.Text = "";
                    maskedTextBox_telephone.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox_speciality.SelectedIndex = 0;
                }
            }
        }

        private void DoctorManagement_Load(object sender, EventArgs e)
        {
            if (comboBox_speciality.Text=="")
            {
                comboBox_speciality.SelectedIndex = 0;
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
                Doctors doctor = db.Doctors.FirstOrDefault(doc => doc.DoctorId.Equals(Int32.Parse(textBox_code.Text)));

                if (doctor == null) // no doctor data matching the input doctorId
                {
                    MessageBox.Show("Enter the valid doctor code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DialogResult response = MessageBox.Show("Are you sure to edit the information of doctor with doctorId " + doctor.DoctorId + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes) //Checking the response
                    {
                        //Check if there's an empty fields
                        if (String.IsNullOrEmpty(textBox_code.Text)
                            || String.IsNullOrEmpty(textBox_name.Text)
                            || String.IsNullOrEmpty(dateTimePicker1.Text))
                        {
                            MessageBox.Show("Fields should not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //Check if the format of telephone input is correct
                        else if (maskedTextBox_telephone.Text.Replace(" ", "").Length != 10)
                        {
                            MessageBox.Show("The phone number must be valid (10 digits).", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else //Edit the doctor information
                        {
                            doctor.DoctorName = textBox_name.Text;
                            doctor.DoctorTel = maskedTextBox_telephone.Text;
                            doctor.HiringDate = Convert.ToDateTime(dateTimePicker1.Text);
                            doctor.DoctorSpecialism = comboBox_speciality.Text;
                            db.SubmitChanges();

                            MessageBox.Show("Successfully Edited.");
                            textBox_code.Text = "";
                            textBox_name.Text = "";
                            maskedTextBox_telephone.Text = "";
                            dateTimePicker1.Value = DateTime.Now;
                            comboBox_speciality.SelectedIndex = 0;
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
                Doctors doctor = db.Doctors.FirstOrDefault(doc => doc.DoctorId.Equals(Int32.Parse(textBox_code.Text)));

                if (doctor == null) // no doctor data matching the input doctorId
                {
                    MessageBox.Show("Enter the valid doctor code.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    DialogResult response = MessageBox.Show("Are you sure to delete the information of doctor with doctorId " + doctor.DoctorId + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (response == DialogResult.Yes) //Checking the response
                    {
                        db.Doctors.DeleteOnSubmit(doctor);
                        db.SubmitChanges();

                        MessageBox.Show("Successfully Deleted.");
                        textBox_code.Text = "";
                        textBox_name.Text = "";
                        maskedTextBox_telephone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        comboBox_speciality.SelectedIndex = 0;
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
