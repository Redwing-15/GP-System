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
            AD_emailEntry = new TextBox();
            AD_enterButton = new Button();
            AD_positionEntry = new TextBox();
            AD_phoneEntry = new TextBox();
            AD_addressEntry = new TextBox();
            AD_firstNameEntry = new TextBox();
            AD_lastNameEntry = new TextBox();
            addPatientPage = new TabPage();
            AP_doctorCombobox = new ComboBox();
            AP_enterButton = new Button();
            AP_addressEntry = new TextBox();
            AP_phoneEntry = new TextBox();
            AP_emailEntry = new TextBox();
            AP_nhsNumberEntry = new TextBox();
            AP_lastNameEntry = new TextBox();
            AP_firstNameEntry = new TextBox();
            bookAppointmentPage = new TabPage();
            BA_entryButton = new Button();
            BA_commentTextbox = new TextBox();
            BA_datePicker = new DateTimePicker();
            BA_doctorTextbox = new TextBox();
            BA_minuteCombobox = new ComboBox();
            BA_hourCombobox = new ComboBox();
            BA_patientCombobox = new ComboBox();
            LS_tabControl.SuspendLayout();
            loginPage.SuspendLayout();
            tabControl.SuspendLayout();
            addDoctorPage.SuspendLayout();
            addPatientPage.SuspendLayout();
            bookAppointmentPage.SuspendLayout();
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
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // addDoctorPage
            // 
            addDoctorPage.Controls.Add(AD_emailEntry);
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
            // AD_emailEntry
            // 
            AD_emailEntry.Location = new Point(379, 184);
            AD_emailEntry.Name = "AD_emailEntry";
            AD_emailEntry.Size = new Size(100, 23);
            AD_emailEntry.TabIndex = 6;
            AD_emailEntry.Text = "Tim@Smith.com";
            // 
            // AD_enterButton
            // 
            AD_enterButton.Location = new Point(379, 271);
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
            AD_positionEntry.Text = "Doctor";
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
            AD_addressEntry.Location = new Point(379, 242);
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
            addPatientPage.Controls.Add(AP_doctorCombobox);
            addPatientPage.Controls.Add(AP_enterButton);
            addPatientPage.Controls.Add(AP_addressEntry);
            addPatientPage.Controls.Add(AP_phoneEntry);
            addPatientPage.Controls.Add(AP_emailEntry);
            addPatientPage.Controls.Add(AP_nhsNumberEntry);
            addPatientPage.Controls.Add(AP_lastNameEntry);
            addPatientPage.Controls.Add(AP_firstNameEntry);
            addPatientPage.Location = new Point(4, 24);
            addPatientPage.Name = "addPatientPage";
            addPatientPage.Padding = new Padding(3);
            addPatientPage.Size = new Size(793, 390);
            addPatientPage.TabIndex = 1;
            addPatientPage.Text = "Add Patient";
            addPatientPage.UseVisualStyleBackColor = true;
            // 
            // AP_doctorCombobox
            // 
            AP_doctorCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            AP_doctorCombobox.FormattingEnabled = true;
            AP_doctorCombobox.Location = new Point(289, 237);
            AP_doctorCombobox.Name = "AP_doctorCombobox";
            AP_doctorCombobox.Size = new Size(102, 23);
            AP_doctorCombobox.TabIndex = 8;
            // 
            // AP_enterButton
            // 
            AP_enterButton.Location = new Point(289, 266);
            AP_enterButton.Name = "AP_enterButton";
            AP_enterButton.Size = new Size(102, 23);
            AP_enterButton.TabIndex = 7;
            AP_enterButton.Text = "Add Patient";
            AP_enterButton.UseVisualStyleBackColor = true;
            AP_enterButton.Click += AP_enterButton_Click;
            // 
            // AP_addressEntry
            // 
            AP_addressEntry.Location = new Point(289, 208);
            AP_addressEntry.Name = "AP_addressEntry";
            AP_addressEntry.Size = new Size(243, 23);
            AP_addressEntry.TabIndex = 5;
            AP_addressEntry.Text = "22 Love Lane, Northfleet, Kent, CT1 8BA";
            // 
            // AP_phoneEntry
            // 
            AP_phoneEntry.Location = new Point(289, 179);
            AP_phoneEntry.Name = "AP_phoneEntry";
            AP_phoneEntry.Size = new Size(100, 23);
            AP_phoneEntry.TabIndex = 4;
            AP_phoneEntry.Text = "07843319767";
            // 
            // AP_emailEntry
            // 
            AP_emailEntry.Location = new Point(289, 150);
            AP_emailEntry.Name = "AP_emailEntry";
            AP_emailEntry.Size = new Size(100, 23);
            AP_emailEntry.TabIndex = 3;
            AP_emailEntry.Text = "Dave@Roberts.com";
            // 
            // AP_nhsNumberEntry
            // 
            AP_nhsNumberEntry.Location = new Point(289, 121);
            AP_nhsNumberEntry.Name = "AP_nhsNumberEntry";
            AP_nhsNumberEntry.Size = new Size(100, 23);
            AP_nhsNumberEntry.TabIndex = 2;
            AP_nhsNumberEntry.Text = "1984623845";
            // 
            // AP_lastNameEntry
            // 
            AP_lastNameEntry.Location = new Point(289, 92);
            AP_lastNameEntry.Name = "AP_lastNameEntry";
            AP_lastNameEntry.Size = new Size(100, 23);
            AP_lastNameEntry.TabIndex = 1;
            AP_lastNameEntry.Text = "Roberts";
            // 
            // AP_firstNameEntry
            // 
            AP_firstNameEntry.Location = new Point(289, 63);
            AP_firstNameEntry.Name = "AP_firstNameEntry";
            AP_firstNameEntry.Size = new Size(100, 23);
            AP_firstNameEntry.TabIndex = 0;
            AP_firstNameEntry.Text = "Dave";
            // 
            // bookAppointmentPage
            // 
            bookAppointmentPage.Controls.Add(BA_entryButton);
            bookAppointmentPage.Controls.Add(BA_commentTextbox);
            bookAppointmentPage.Controls.Add(BA_datePicker);
            bookAppointmentPage.Controls.Add(BA_doctorTextbox);
            bookAppointmentPage.Controls.Add(BA_minuteCombobox);
            bookAppointmentPage.Controls.Add(BA_hourCombobox);
            bookAppointmentPage.Controls.Add(BA_patientCombobox);
            bookAppointmentPage.Location = new Point(4, 24);
            bookAppointmentPage.Name = "bookAppointmentPage";
            bookAppointmentPage.Size = new Size(793, 390);
            bookAppointmentPage.TabIndex = 2;
            bookAppointmentPage.Text = "Book Appointment";
            bookAppointmentPage.UseVisualStyleBackColor = true;
            // 
            // BA_entryButton
            // 
            BA_entryButton.Location = new Point(305, 325);
            BA_entryButton.Name = "BA_entryButton";
            BA_entryButton.Size = new Size(75, 23);
            BA_entryButton.TabIndex = 6;
            BA_entryButton.Text = "Book";
            BA_entryButton.UseVisualStyleBackColor = true;
            BA_entryButton.Click += BA_entryButton_Click;
            // 
            // BA_commentTextbox
            // 
            BA_commentTextbox.Location = new Point(266, 202);
            BA_commentTextbox.Multiline = true;
            BA_commentTextbox.Name = "BA_commentTextbox";
            BA_commentTextbox.Size = new Size(181, 103);
            BA_commentTextbox.TabIndex = 5;
            BA_commentTextbox.Text = "pipi brokey";
            // 
            // BA_datePicker
            // 
            BA_datePicker.Location = new Point(266, 126);
            BA_datePicker.Name = "BA_datePicker";
            BA_datePicker.Size = new Size(142, 23);
            BA_datePicker.TabIndex = 4;
            // 
            // BA_doctorTextbox
            // 
            BA_doctorTextbox.AcceptsReturn = true;
            BA_doctorTextbox.Location = new Point(266, 87);
            BA_doctorTextbox.Name = "BA_doctorTextbox";
            BA_doctorTextbox.ReadOnly = true;
            BA_doctorTextbox.Size = new Size(100, 23);
            BA_doctorTextbox.TabIndex = 3;
            // 
            // BA_minuteCombobox
            // 
            BA_minuteCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            BA_minuteCombobox.FormattingEnabled = true;
            BA_minuteCombobox.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            BA_minuteCombobox.Location = new Point(358, 167);
            BA_minuteCombobox.Name = "BA_minuteCombobox";
            BA_minuteCombobox.Size = new Size(50, 23);
            BA_minuteCombobox.TabIndex = 2;
            // 
            // BA_hourCombobox
            // 
            BA_hourCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            BA_hourCombobox.FormattingEnabled = true;
            BA_hourCombobox.Items.AddRange(new object[] { "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "19", "19", "20" });
            BA_hourCombobox.Location = new Point(266, 167);
            BA_hourCombobox.Name = "BA_hourCombobox";
            BA_hourCombobox.Size = new Size(59, 23);
            BA_hourCombobox.TabIndex = 1;
            // 
            // BA_patientCombobox
            // 
            BA_patientCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            BA_patientCombobox.FormattingEnabled = true;
            BA_patientCombobox.Location = new Point(266, 48);
            BA_patientCombobox.Name = "BA_patientCombobox";
            BA_patientCombobox.Size = new Size(100, 23);
            BA_patientCombobox.TabIndex = 0;
            BA_patientCombobox.SelectedIndexChanged += BA_patientCombobox_SelectedIndexChanged;
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
            addPatientPage.ResumeLayout(false);
            addPatientPage.PerformLayout();
            bookAppointmentPage.ResumeLayout(false);
            bookAppointmentPage.PerformLayout();
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
        private TextBox AD_emailEntry;
        private TextBox AP_emailEntry;
        private TextBox AP_nhsNumberEntry;
        private TextBox AP_lastNameEntry;
        private TextBox AP_firstNameEntry;
        private Button AP_enterButton;
        private TextBox AP_addressEntry;
        private TextBox AP_phoneEntry;
        private ComboBox AP_doctorCombobox;
        private TextBox BA_commentTextbox;
        private DateTimePicker BA_datePicker;
        private TextBox BA_doctorTextbox;
        private ComboBox BA_minuteCombobox;
        private ComboBox BA_hourCombobox;
        private ComboBox BA_patientCombobox;
        private Button BA_entryButton;
    }
}
