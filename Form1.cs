using System.Diagnostics;

namespace GP_System
{
    public partial class Form1 : Form
    {
        List<Doctor> doctors = new List<Doctor>();
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
    }
}
