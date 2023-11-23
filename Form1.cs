namespace GP_System
{
    public partial class Form1 : Form
    {
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
    }
}
