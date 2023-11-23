using System.Diagnostics;
using System.Windows.Forms;

namespace GP_System
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>();
        List<Patient> patients = new List<Patient>();

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
            string position = AD_positionEntry.Text;
            string email = AD_emailEntry.Text;
            string phone = AD_phoneEntry.Text;
            string address = AD_addressEntry.Text;

            doctors.Add(new Doctor(firstName, lastName, position, email, phone, address));
        }

        private void AP_enterButton_Click(object sender, EventArgs e)
        {
            string firstName = AP_firstNameEntry.Text;
            string lastName = AP_lastNameEntry.Text;
            string nhsNumber = AP_nhsNumberEntry.Text;
            string email = AP_emailEntry.Text;
            string phone = AP_phoneEntry.Text;
            string address = AP_addressEntry.Text;
            string doctor = AP_doctorCombobox.Text.Split(':')[0];

            patients.Add(new Patient(firstName, lastName, nhsNumber, email, phone, address, doctor));
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
                    AP_doctorCombobox.Items.Add($"{n + 1}: {doctors[n].GetName()}");
                }

            }
        }
    }
}
