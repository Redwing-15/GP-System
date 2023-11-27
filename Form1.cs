using System.Diagnostics;
using System.Windows.Forms;

namespace GP_System
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>();
        List<Patient> patients = new List<Patient>();
        List<Appointment> appointments = new List<Appointment>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LS_loginButton_Click(object sender, EventArgs e)
        {
            string Password = "admin";

            if (LS_passwordEntry.Text != Password)
            {
                LS_resultLabel.Visible = true;
                return;
            }

            tabControl.Visible = true;
            LS_logoutButton.Visible = true;

            LS_resultLabel.Visible = false;
            LS_passwordEntry.Text = "";
        }

        private void LS_logoutButton_Click(object sender, EventArgs e)
        {
            tabControl.Visible = false;
            LS_logoutButton.Visible = false;
        }

        private void AD_enterButton_Click(object sender, EventArgs e)
        {
            string firstName = AD_firstNameEntry.Text;
            string lastName = AD_lastNameEntry.Text;
            string position = AD_positionCombobox.Text;
            string email = AD_emailEntry.Text;
            string phone = AD_phoneEntry.Text;
            string address = AD_addressEntry.Text;

            if (firstName == "" | lastName == "" | position == "" | email == "" | phone == ""
                | address == "")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }
            else if (email.Contains('@') == false | email.Contains('.') == false)
            {
                MessageBox.Show("Email must contain an \'@\' and a domain (e.g .com)");
                return;
            }
            else if (double.TryParse(phone, out double result) == false)
            {
                MessageBox.Show("Phone must only contain numbers");
                return;
            }

            doctors.Add(new Doctor(firstName, lastName, position, email, phone, address));

            AD_firstNameEntry.Text = "";
            AD_lastNameEntry.Text = "";
            AD_positionCombobox.SelectedItem = null;
            AD_emailEntry.Text = "";
            AD_phoneEntry.Text = "";
            AD_addressEntry.Text = "";
        }

        private void AP_enterButton_Click(object sender, EventArgs e)
        {
            string firstName = AP_firstNameEntry.Text;
            string lastName = AP_lastNameEntry.Text;
            string nhsNumber = AP_nhsNumberEntry.Text;
            string email = AP_emailEntry.Text;
            string phone = AP_phoneEntry.Text;
            string address = AP_addressEntry.Text;
            string doctor = AP_doctorCombobox.Text;
            string doctorID = AP_doctorCombobox.Items.IndexOf(doctor).ToString();

            if (firstName == "" | lastName == "" | nhsNumber == "" | email == "" | phone == ""
                | address == "" | doctor == "")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }
            else if (email.Contains('@') == false | email.Contains('.') == false)
            {
                MessageBox.Show("Email must contain an \'@\' and a domain (e.g .com)");
                return;
            }
            else if (double.TryParse(phone, out double result) == false)
            {
                MessageBox.Show("Phone must only contain numbers");
                return;
            }
            List<string> ids = new List<string>();
            foreach (Patient patient in patients)
            {
                ids.Add(patient.GetData()["nhsNumber"]);
            }
            if (ids.Contains(nhsNumber))
            {
                MessageBox.Show("NHS number already in system");
                return;
            }

            patients.Add(new Patient(firstName, lastName, nhsNumber, email, phone, address, doctorID));

            AP_firstNameEntry.Text = "";
            AP_lastNameEntry.Text = "";
            AP_nhsNumberEntry.Text = "";
            AP_emailEntry.Text = "";
            AP_phoneEntry.Text = "";
            AP_addressEntry.Text = "";
            AP_doctorCombobox.SelectedItem = null;
        }

        private void BA_patientCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BA_patientCombobox.Text == ""){return;}
            int id = BA_patientCombobox.Items.IndexOf(BA_patientCombobox.Text);
            int doctorID = Convert.ToInt32(patients[id].GetData()["assignedDoctor"]);
            string doctor = doctors[doctorID].GetName();

            BA_doctorTextbox.Text = doctor;
        }

        private void BA_entryButton_Click(object sender, EventArgs e)
        {
            string patient = BA_patientCombobox.Text;
            string doctor = BA_doctorTextbox.Text;
            string date = BA_datePicker.Value.ToString("dd/MM/yyyy");
            string time = $"{BA_hourCombobox.Text}:{BA_minuteCombobox.Text}";
            string comment = BA_commentTextbox.Text;

            appointments.Add(new Appointment(patient, doctor, date, time, comment));
            
            BA_patientCombobox.SelectedItem = null;
            BA_doctorTextbox.Text = "";
            BA_datePicker.Value = BA_datePicker.MinDate;
            BA_hourCombobox.SelectedItem = null;
            BA_minuteCombobox.SelectedItem = null;
            BA_commentTextbox.Text = "";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Checks if the "Add Patients" tab is selected in order to
            // update the doctor select with latest Doctors
            if (tabControl.SelectedIndex == 1)
            {
                AP_doctorCombobox.Items.Clear();
                for (int n = 0; n < doctors.Count; n++)
                {
                    AP_doctorCombobox.Items.Add(doctors[n].GetName());
                }
            }
            // Checks if the "Book Appointment" tab is selected in order to
            // update the dropdowns with the latest patients
            else if (tabControl.SelectedIndex == 2)
            {
                BA_patientCombobox.Items.Clear();
                for (int n = 0; n < patients.Count; n++)
                {
                    BA_patientCombobox.Items.Add(patients[n].GetName());
                }

                BA_datePicker.MinDate = DateTime.Now.Date;
            }
        }
    }
}
