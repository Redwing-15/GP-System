using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GP_System
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>();
        List<Patient> patients = new List<Patient>();
        List<Appointment> appointments = new List<Appointment>();


        public Form1()
        {
            // REMOVE WHEN FINISHED
            //doctors.Add(new Doctor("Dave", "Smith", "Doctor", "Dave@Beckett.com", "07843319766", "62 bobsmith drive"));
            //patients.Add(new Patient("Bob", "Ross", "1234567890", "Bob@Ross.com", "07843319767", "21 lovejoy lane", "0"));
            //appointments.Add(new Appointment("Bob Ross", "Dave Smith", "01/01/2004", "08:40", "Has an inflamed arm"));
            //appointments.Add(new Appointment("Bob Ross", "Dave Smith", "02/12/2023", "08:50", "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the lazy dog."));
            InitializeComponent();
            tabControl.TabPages.Remove(editAppointmentPage);
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

            if (firstName == "" | lastName == "" | phone == "" | address == "")
            {
                MessageBox.Show("Please enter all mandatory fields");
                return;
            }
            else if (email.Contains('@') == false | email.Contains('.') == false)
            {
                // Cannot put this statement in above if for some reason. I don't see the logic.
                if (email != "")
                {
                    Debug.WriteLine($"Email: {email}");
                    MessageBox.Show("Email must contain an \'@\' and a domain (e.g .com)");
                    return;
                }
            }
            if (double.TryParse(phone, out double result) == false)
            {
                MessageBox.Show("Phone must only contain numbers");
                return;
            }
            else if (phone.Length < 11)
            {
                MessageBox.Show("Phone number must be 11 numbers long");
                return;
            }

            doctors.Add(new Doctor(firstName, lastName, position, email, phone, address));

            MessageBox.Show($"Successfully added doctor {firstName} {lastName} to system!");

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

            if (firstName == "" | lastName == "" | nhsNumber == "" | address == "" | doctor == "")
            {
                MessageBox.Show("Please enter all mandatory fields");
                return;
            }
            else if (email.Contains('@') == false | email.Contains('.') == false)
            {
                // Cannot put this statement in above if for some reason. I don't see the logic.
                if (email != "")
                {
                    Debug.WriteLine($"Email: {email}");
                    MessageBox.Show("Email must contain an \'@\' and a domain (e.g .com)");
                    return;
                }
            }
            if (double.TryParse(nhsNumber, out double result2) == false)
            {
                MessageBox.Show("NHS number must only contain numbers");
                return;
            }
            else if (nhsNumber.Length < 10)
            {
                MessageBox.Show("NHS number must be 10 numbers long");
                return;
            }
            if (phone != "")
            {
                if (double.TryParse(phone, out double result) == false | phone != "")
                {
                    MessageBox.Show("Phone must only contain numbers");
                    return;
                }
                else if (phone.Length < 11)
                {
                    MessageBox.Show("Phone number must be 11 numbers long");
                    return;
                }
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

            MessageBox.Show($"Successfully added patient {firstName} {lastName} to system!");

            AP_firstNameEntry.Text = "";
            AP_lastNameEntry.Text = "";
            AP_nhsNumberEntry.Text = "";
            AP_emailEntry.Text = "";
            AP_phoneEntry.Text = "";
            AP_addressEntry.Text = "";
            AP_doctorCombobox.SelectedItem = null;
        }

        private void BA_entryButton_Click(object sender, EventArgs e)
        {
            string patient = BA_patientCombobox.Text;
            string doctor = BA_doctorTextbox.Text;
            string date = BA_datePicker.Value.ToString("dd/MM/yyyy");
            string hour = BA_hourCombobox.Text;
            string minute = BA_minuteCombobox.Text;
            string time = $"{hour}:{minute}";
            string comment = BA_commentTextbox.Text;

            if (patient == "" | hour == "" | minute == "")
            {
                MessageBox.Show("Please enter all mandatory fields");
                return;
            }

            appointments.Add(new Appointment(patient, doctor, date, time, comment));

            MessageBox.Show($"Successfully created appointment for {patient}!");

            BA_patientCombobox.SelectedItem = null;
            BA_doctorTextbox.Text = "";
            BA_datePicker.Value = BA_datePicker.MinDate;
            BA_hourCombobox.SelectedItem = null;
            BA_minuteCombobox.SelectedItem = null;
            BA_commentTextbox.Text = "";
        }

        private void BA_patientCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BA_patientCombobox.Text == "") { return; }
            int id = BA_patientCombobox.Items.IndexOf(BA_patientCombobox.Text);
            int doctorID = Convert.ToInt32(patients[id].GetData()["assignedDoctor"]);
            string doctor = doctors[doctorID].GetName();

            BA_doctorTextbox.Text = doctor;
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
            // Checks if the "View Appointments" tab is selected in order to
            // update the fields with the latest data
            else if (tabControl.SelectedIndex == 3)
            {
                VA_appointmentTable.Rows.Clear();
                foreach (Appointment appointment in appointments)
                {
                    var data = appointment.GetData();
                    string[] values = [data["patient"], data["doctor"], data["date"],
                        data["time"], data["comment"]];
                    VA_appointmentTable.Rows.Add(values);
                }
            }
        }

        private void ShowAppointmentEditPage(int index)
        {
            Appointment appointment = appointments[index];
            Dictionary<string, string> data = appointment.GetData();

            tabControl.TabPages.Insert(4, editAppointmentPage);

            EA_appointmentIDLabel.Text = data["id"];
            EA_patientCombobox.Items.Clear();
            for (int n = 0; n < patients.Count; n++)
            {
                EA_patientCombobox.Items.Add(patients[n].GetName());
            }
            EA_patientCombobox.Text = data["patient"];
            EA_doctorTextbox.Text = data["doctor"];
            EA_datePicker.Text = data["date"];
            string[] time = data["time"].Split(':');
            EA_hourCombobox.Text = time[0];
            EA_minuteCombobox.Text = time[1];
            EA_commentTextbox.Text = data["comment"];

            tabControl.SelectedIndex = 4;
        }
        private void CancelAppointment(int index)
        {
            appointments[index].SubtractCount(1);
            appointments.Remove(appointments[index]);
            
            VA_appointmentTable.Rows.RemoveAt(index);
        }

        private void VA_appointmentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code slightly modified from the stackoverflow answer:
            // https://stackoverflow.com/a/13687844
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is not DataGridViewButtonColumn)
            {
                return;
            }
            else if (e.RowIndex < 0)
            {
                return;
            }

            int rowIndex = e.RowIndex;
            if (e.ColumnIndex == 5)
            {
                ShowAppointmentEditPage(rowIndex);
            }
            else if (e.ColumnIndex == 6)
            {
                CancelAppointment(rowIndex);
            }
        }

        private void EA_cancelButton_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(editAppointmentPage);
            tabControl.SelectedIndex = 3;
        }

        private void EA_updateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(EA_appointmentIDLabel.Text)-1;
            string patient = EA_patientCombobox.Text;
            string doctor = EA_doctorTextbox.Text;
            string date = EA_datePicker.Value.ToString("dd/MM/yyyy");
            string hour = EA_hourCombobox.Text;
            string minute = EA_minuteCombobox.Text;
            string time = $"{hour}:{minute}";
            string comment = EA_commentTextbox.Text;

            if (patient == "" | hour == "" | minute == "")
            {
                MessageBox.Show("Please enter all fields");
                return;
            }

            appointments[id].UpdateData(new List<string> {patient, doctor, date, time, comment});

            MessageBox.Show("Successfully updated appointment!");
            tabControl.TabPages.Remove(editAppointmentPage);
            tabControl.SelectedIndex = 3;
        }
    }
}
