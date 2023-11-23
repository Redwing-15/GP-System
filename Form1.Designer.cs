namespace GP_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LS_tabControl = new TabControl();
            loginPage = new TabPage();
            LS_resultLabel = new Label();
            LS_loginButton = new Button();
            LS_passwordLabel = new Label();
            LS_passwordEntry = new TextBox();
            LS_logoutButton = new Button();
            tabControl = new TabControl();
            addDoctorPage = new TabPage();
            AD_enterButton = new Button();
            AD_positionEntry = new TextBox();
            AD_phoneEntry = new TextBox();
            AD_addressEntry = new TextBox();
            AD_firstNameEntry = new TextBox();
            AD_lastNameEntry = new TextBox();
            addPatientPage = new TabPage();
            bookAppointmentPage = new TabPage();
            LS_tabControl.SuspendLayout();
            loginPage.SuspendLayout();
            tabControl.SuspendLayout();
            addDoctorPage.SuspendLayout();
            SuspendLayout();
            // 
            // LS_tabControl
            // 
            LS_tabControl.Controls.Add(loginPage);
            LS_tabControl.Location = new Point(305, 151);
            LS_tabControl.Name = "LS_tabControl";
            LS_tabControl.SelectedIndex = 0;
            LS_tabControl.Size = new Size(241, 123);
            LS_tabControl.TabIndex = 0;
            // 
            // loginPage
            // 
            loginPage.Controls.Add(LS_resultLabel);
            loginPage.Controls.Add(LS_loginButton);
            loginPage.Controls.Add(LS_passwordLabel);
            loginPage.Controls.Add(LS_passwordEntry);
            loginPage.Location = new Point(4, 24);
            loginPage.Name = "loginPage";
            loginPage.Padding = new Padding(3);
            loginPage.Size = new Size(233, 95);
            loginPage.TabIndex = 0;
            loginPage.Text = "Admin Login";
            loginPage.UseVisualStyleBackColor = true;
            // 
            // LS_resultLabel
            // 
            LS_resultLabel.AutoSize = true;
            LS_resultLabel.Location = new Point(64, 77);
            LS_resultLabel.Name = "LS_resultLabel";
            LS_resultLabel.Size = new Size(110, 15);
            LS_resultLabel.TabIndex = 3;
            LS_resultLabel.Text = "Incorrect password!";
            LS_resultLabel.Visible = false;
            // 
            // LS_loginButton
            // 
            LS_loginButton.Location = new Point(82, 51);
            LS_loginButton.Name = "LS_loginButton";
            LS_loginButton.Size = new Size(75, 23);
            LS_loginButton.TabIndex = 2;
            LS_loginButton.Text = "Sign In";
            LS_loginButton.UseVisualStyleBackColor = true;
            LS_loginButton.Click += LS_loginButton_Click;
            // 
            // LS_passwordLabel
            // 
            LS_passwordLabel.AutoSize = true;
            LS_passwordLabel.Location = new Point(26, 25);
            LS_passwordLabel.Name = "LS_passwordLabel";
            LS_passwordLabel.Size = new Size(60, 15);
            LS_passwordLabel.TabIndex = 0;
            LS_passwordLabel.Text = "Password:";
            // 
            // LS_passwordEntry
            // 
            LS_passwordEntry.Location = new Point(92, 22);
            LS_passwordEntry.Name = "LS_passwordEntry";
            LS_passwordEntry.PasswordChar = '*';
            LS_passwordEntry.Size = new Size(116, 23);
            LS_passwordEntry.TabIndex = 1;
            LS_passwordEntry.UseSystemPasswordChar = true;
            // 
            // LS_logoutButton
            // 
            LS_logoutButton.Location = new Point(713, 421);
            LS_logoutButton.Name = "LS_logoutButton";
            LS_logoutButton.Size = new Size(75, 23);
            LS_logoutButton.TabIndex = 1;
            LS_logoutButton.Text = "Sign Out";
            LS_logoutButton.UseVisualStyleBackColor = true;
            LS_logoutButton.Visible = false;
            LS_logoutButton.Click += LS_logoutButton_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(addDoctorPage);
            tabControl.Controls.Add(addPatientPage);
            tabControl.Controls.Add(bookAppointmentPage);
            tabControl.Location = new Point(0, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(801, 418);
            tabControl.TabIndex = 2;
            // 
            // addDoctorPage
            // 
            addDoctorPage.Controls.Add(AD_enterButton);
            addDoctorPage.Controls.Add(AD_positionEntry);
            addDoctorPage.Controls.Add(AD_phoneEntry);
            addDoctorPage.Controls.Add(AD_addressEntry);
            addDoctorPage.Controls.Add(AD_firstNameEntry);
            addDoctorPage.Controls.Add(AD_lastNameEntry);
            addDoctorPage.Location = new Point(4, 24);
            addDoctorPage.Name = "addDoctorPage";
            addDoctorPage.Padding = new Padding(3);
            addDoctorPage.Size = new Size(793, 390);
            addDoctorPage.TabIndex = 0;
            addDoctorPage.Text = "Add Doctor";
            addDoctorPage.UseVisualStyleBackColor = true;
            // 
            // AD_enterButton
            // 
            AD_enterButton.Location = new Point(379, 242);
            AD_enterButton.Name = "AD_enterButton";
            AD_enterButton.Size = new Size(100, 23);
            AD_enterButton.TabIndex = 5;
            AD_enterButton.Text = "Add Doctor";
            AD_enterButton.UseVisualStyleBackColor = true;
            AD_enterButton.Click += AD_enterButton_Click;
            // 
            // AD_positionEntry
            // 
            AD_positionEntry.Location = new Point(379, 155);
            AD_positionEntry.Name = "AD_positionEntry";
            AD_positionEntry.Size = new Size(100, 23);
            AD_positionEntry.TabIndex = 4;
            AD_positionEntry.Text = "Nurse";
            // 
            // AD_phoneEntry
            // 
            AD_phoneEntry.Location = new Point(379, 213);
            AD_phoneEntry.Name = "AD_phoneEntry";
            AD_phoneEntry.Size = new Size(100, 23);
            AD_phoneEntry.TabIndex = 3;
            AD_phoneEntry.Text = "07843319766";
            // 
            // AD_addressEntry
            // 
            AD_addressEntry.Location = new Point(379, 184);
            AD_addressEntry.Name = "AD_addressEntry";
            AD_addressEntry.Size = new Size(267, 23);
            AD_addressEntry.TabIndex = 2;
            AD_addressEntry.Text = "21 longport, canterbury, kent CT11TA";
            // 
            // AD_firstNameEntry
            // 
            AD_firstNameEntry.Location = new Point(379, 97);
            AD_firstNameEntry.Name = "AD_firstNameEntry";
            AD_firstNameEntry.Size = new Size(100, 23);
            AD_firstNameEntry.TabIndex = 1;
            AD_firstNameEntry.Text = "Tim";
            // 
            // AD_lastNameEntry
            // 
            AD_lastNameEntry.Location = new Point(379, 126);
            AD_lastNameEntry.Name = "AD_lastNameEntry";
            AD_lastNameEntry.Size = new Size(100, 23);
            AD_lastNameEntry.TabIndex = 0;
            AD_lastNameEntry.Text = "Smith";
            // 
            // addPatientPage
            // 
            addPatientPage.Location = new Point(4, 24);
            addPatientPage.Name = "addPatientPage";
            addPatientPage.Padding = new Padding(3);
            addPatientPage.Size = new Size(793, 390);
            addPatientPage.TabIndex = 1;
            addPatientPage.Text = "Add Patient";
            addPatientPage.UseVisualStyleBackColor = true;
            // 
            // bookAppointmentPage
            // 
            bookAppointmentPage.Location = new Point(4, 24);
            bookAppointmentPage.Name = "bookAppointmentPage";
            bookAppointmentPage.Size = new Size(793, 390);
            bookAppointmentPage.TabIndex = 2;
            bookAppointmentPage.Text = "Book Appointment";
            bookAppointmentPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(LS_logoutButton);
            Controls.Add(LS_tabControl);
            Name = "Form1";
            Text = "Form1";
            LS_tabControl.ResumeLayout(false);
            loginPage.ResumeLayout(false);
            loginPage.PerformLayout();
            tabControl.ResumeLayout(false);
            addDoctorPage.ResumeLayout(false);
            addDoctorPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl LS_tabControl;
        private TabPage loginPage;
        private Label LS_resultLabel;
        private Button LS_loginButton;
        private Label LS_passwordLabel;
        private TextBox LS_passwordEntry;
        private Button LS_logoutButton;
        private TabControl tabControl;
        private TabPage addDoctorPage;
        private TabPage addPatientPage;
        private TabPage bookAppointmentPage;
        private Button AD_enterButton;
        private TextBox AD_positionEntry;
        private TextBox AD_phoneEntry;
        private TextBox AD_addressEntry;
        private TextBox AD_firstNameEntry;
        private TextBox AD_lastNameEntry;
    }
}
