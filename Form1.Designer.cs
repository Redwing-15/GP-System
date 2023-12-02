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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            LS_tabControl = new TabControl();
            loginPage = new TabPage();
            LS_resultLabel = new Label();
            LS_loginButton = new Button();
            LS_passwordLabel = new Label();
            LS_passwordEntry = new TextBox();
            LS_logoutButton = new Button();
            tabControl = new TabControl();
            addDoctorPage = new TabPage();
            AD_label6 = new Label();
            AD_label5 = new Label();
            AD_label4 = new Label();
            AD_label3 = new Label();
            AD_label2 = new Label();
            AD_label1 = new Label();
            AD_positionCombobox = new ComboBox();
            AD_emailEntry = new TextBox();
            AD_enterButton = new Button();
            AD_phoneEntry = new TextBox();
            AD_addressEntry = new TextBox();
            AD_firstNameEntry = new TextBox();
            AD_lastNameEntry = new TextBox();
            addPatientPage = new TabPage();
            AP_label7 = new Label();
            AP_label6 = new Label();
            AP_label5 = new Label();
            AP_label4 = new Label();
            AP_label3 = new Label();
            AP_label2 = new Label();
            AP_label1 = new Label();
            AP_doctorCombobox = new ComboBox();
            AP_enterButton = new Button();
            AP_addressEntry = new TextBox();
            AP_phoneEntry = new TextBox();
            AP_emailEntry = new TextBox();
            AP_nhsNumberEntry = new TextBox();
            AP_lastNameEntry = new TextBox();
            AP_firstNameEntry = new TextBox();
            bookAppointmentPage = new TabPage();
            BA_label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            BA_label4 = new Label();
            BA_label3 = new Label();
            BA_label2 = new Label();
            BA_label1 = new Label();
            BA_entryButton = new Button();
            BA_commentTextbox = new TextBox();
            BA_datePicker = new DateTimePicker();
            BA_doctorTextbox = new TextBox();
            BA_minuteCombobox = new ComboBox();
            BA_hourCombobox = new ComboBox();
            BA_patientCombobox = new ComboBox();
            viewAppointmentPage = new TabPage();
            VA_appointmentTable = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            LS_tabControl.SuspendLayout();
            loginPage.SuspendLayout();
            tabControl.SuspendLayout();
            addDoctorPage.SuspendLayout();
            addPatientPage.SuspendLayout();
            bookAppointmentPage.SuspendLayout();
            viewAppointmentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VA_appointmentTable).BeginInit();
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
            tabControl.Controls.Add(viewAppointmentPage);
            tabControl.Dock = DockStyle.Top;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 418);
            tabControl.TabIndex = 2;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // addDoctorPage
            // 
            addDoctorPage.Controls.Add(AD_label6);
            addDoctorPage.Controls.Add(AD_label5);
            addDoctorPage.Controls.Add(AD_label4);
            addDoctorPage.Controls.Add(AD_label3);
            addDoctorPage.Controls.Add(AD_label2);
            addDoctorPage.Controls.Add(AD_label1);
            addDoctorPage.Controls.Add(AD_positionCombobox);
            addDoctorPage.Controls.Add(AD_emailEntry);
            addDoctorPage.Controls.Add(AD_enterButton);
            addDoctorPage.Controls.Add(AD_phoneEntry);
            addDoctorPage.Controls.Add(AD_addressEntry);
            addDoctorPage.Controls.Add(AD_firstNameEntry);
            addDoctorPage.Controls.Add(AD_lastNameEntry);
            addDoctorPage.Location = new Point(4, 24);
            addDoctorPage.Name = "addDoctorPage";
            addDoctorPage.Padding = new Padding(3);
            addDoctorPage.Size = new Size(792, 390);
            addDoctorPage.TabIndex = 0;
            addDoctorPage.Text = "Add Doctor";
            addDoctorPage.UseVisualStyleBackColor = true;
            // 
            // AD_label6
            // 
            AD_label6.AutoSize = true;
            AD_label6.Location = new Point(198, 286);
            AD_label6.Name = "AD_label6";
            AD_label6.Size = new Size(49, 15);
            AD_label6.TabIndex = 13;
            AD_label6.Text = "Address";
            // 
            // AD_label5
            // 
            AD_label5.AutoSize = true;
            AD_label5.Location = new Point(198, 245);
            AD_label5.Name = "AD_label5";
            AD_label5.Size = new Size(41, 15);
            AD_label5.TabIndex = 12;
            AD_label5.Text = "Phone";
            // 
            // AD_label4
            // 
            AD_label4.AutoSize = true;
            AD_label4.Location = new Point(198, 205);
            AD_label4.Name = "AD_label4";
            AD_label4.Size = new Size(36, 15);
            AD_label4.TabIndex = 11;
            AD_label4.Text = "Email";
            // 
            // AD_label3
            // 
            AD_label3.AutoSize = true;
            AD_label3.Location = new Point(198, 159);
            AD_label3.Name = "AD_label3";
            AD_label3.Size = new Size(62, 15);
            AD_label3.TabIndex = 10;
            AD_label3.Text = "Profession";
            // 
            // AD_label2
            // 
            AD_label2.AutoSize = true;
            AD_label2.Location = new Point(198, 111);
            AD_label2.Name = "AD_label2";
            AD_label2.Size = new Size(58, 15);
            AD_label2.TabIndex = 9;
            AD_label2.Text = "Lastname";
            // 
            // AD_label1
            // 
            AD_label1.AutoSize = true;
            AD_label1.Location = new Point(198, 58);
            AD_label1.Name = "AD_label1";
            AD_label1.Size = new Size(59, 15);
            AD_label1.TabIndex = 8;
            AD_label1.Text = "Firstname";
            // 
            // AD_positionCombobox
            // 
            AD_positionCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            AD_positionCombobox.FormattingEnabled = true;
            AD_positionCombobox.Items.AddRange(new object[] { "Doctor", "Nurse", "Other" });
            AD_positionCombobox.Location = new Point(267, 156);
            AD_positionCombobox.Name = "AD_positionCombobox";
            AD_positionCombobox.Size = new Size(100, 23);
            AD_positionCombobox.TabIndex = 7;
            // 
            // AD_emailEntry
            // 
            AD_emailEntry.Location = new Point(267, 199);
            AD_emailEntry.Name = "AD_emailEntry";
            AD_emailEntry.Size = new Size(100, 23);
            AD_emailEntry.TabIndex = 6;
            // 
            // AD_enterButton
            // 
            AD_enterButton.Location = new Point(267, 342);
            AD_enterButton.Name = "AD_enterButton";
            AD_enterButton.Size = new Size(100, 23);
            AD_enterButton.TabIndex = 5;
            AD_enterButton.Text = "Add Doctor";
            AD_enterButton.UseVisualStyleBackColor = true;
            AD_enterButton.Click += AD_enterButton_Click;
            // 
            // AD_phoneEntry
            // 
            AD_phoneEntry.Location = new Point(267, 242);
            AD_phoneEntry.MaxLength = 11;
            AD_phoneEntry.Name = "AD_phoneEntry";
            AD_phoneEntry.Size = new Size(100, 23);
            AD_phoneEntry.TabIndex = 3;
            // 
            // AD_addressEntry
            // 
            AD_addressEntry.Location = new Point(267, 283);
            AD_addressEntry.Name = "AD_addressEntry";
            AD_addressEntry.Size = new Size(267, 23);
            AD_addressEntry.TabIndex = 2;
            // 
            // AD_firstNameEntry
            // 
            AD_firstNameEntry.Location = new Point(267, 55);
            AD_firstNameEntry.Name = "AD_firstNameEntry";
            AD_firstNameEntry.Size = new Size(100, 23);
            AD_firstNameEntry.TabIndex = 1;
            // 
            // AD_lastNameEntry
            // 
            AD_lastNameEntry.Location = new Point(267, 108);
            AD_lastNameEntry.Name = "AD_lastNameEntry";
            AD_lastNameEntry.Size = new Size(100, 23);
            AD_lastNameEntry.TabIndex = 0;
            // 
            // addPatientPage
            // 
            addPatientPage.Controls.Add(AP_label7);
            addPatientPage.Controls.Add(AP_label6);
            addPatientPage.Controls.Add(AP_label5);
            addPatientPage.Controls.Add(AP_label4);
            addPatientPage.Controls.Add(AP_label3);
            addPatientPage.Controls.Add(AP_label2);
            addPatientPage.Controls.Add(AP_label1);
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
            addPatientPage.Size = new Size(792, 390);
            addPatientPage.TabIndex = 1;
            addPatientPage.Text = "Add Patient";
            addPatientPage.UseVisualStyleBackColor = true;
            // 
            // AP_label7
            // 
            AP_label7.AutoSize = true;
            AP_label7.Location = new Point(224, 294);
            AP_label7.Name = "AP_label7";
            AP_label7.Size = new Size(43, 15);
            AP_label7.TabIndex = 15;
            AP_label7.Text = "Doctor";
            // 
            // AP_label6
            // 
            AP_label6.AutoSize = true;
            AP_label6.Location = new Point(224, 255);
            AP_label6.Name = "AP_label6";
            AP_label6.Size = new Size(49, 15);
            AP_label6.TabIndex = 14;
            AP_label6.Text = "Address";
            // 
            // AP_label5
            // 
            AP_label5.AutoSize = true;
            AP_label5.Location = new Point(224, 219);
            AP_label5.Name = "AP_label5";
            AP_label5.Size = new Size(41, 15);
            AP_label5.TabIndex = 13;
            AP_label5.Text = "Phone";
            // 
            // AP_label4
            // 
            AP_label4.AutoSize = true;
            AP_label4.Location = new Point(224, 175);
            AP_label4.Name = "AP_label4";
            AP_label4.Size = new Size(36, 15);
            AP_label4.TabIndex = 12;
            AP_label4.Text = "Email";
            // 
            // AP_label3
            // 
            AP_label3.AutoSize = true;
            AP_label3.Location = new Point(204, 140);
            AP_label3.Name = "AP_label3";
            AP_label3.Size = new Size(78, 15);
            AP_label3.TabIndex = 11;
            AP_label3.Text = "NHS Number";
            // 
            // AP_label2
            // 
            AP_label2.AutoSize = true;
            AP_label2.Location = new Point(224, 100);
            AP_label2.Name = "AP_label2";
            AP_label2.Size = new Size(58, 15);
            AP_label2.TabIndex = 10;
            AP_label2.Text = "Lastname";
            // 
            // AP_label1
            // 
            AP_label1.AutoSize = true;
            AP_label1.Location = new Point(208, 63);
            AP_label1.Name = "AP_label1";
            AP_label1.Size = new Size(59, 15);
            AP_label1.TabIndex = 9;
            AP_label1.Text = "Firstname";
            // 
            // AP_doctorCombobox
            // 
            AP_doctorCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            AP_doctorCombobox.FormattingEnabled = true;
            AP_doctorCombobox.Location = new Point(289, 294);
            AP_doctorCombobox.Name = "AP_doctorCombobox";
            AP_doctorCombobox.Size = new Size(102, 23);
            AP_doctorCombobox.TabIndex = 8;
            // 
            // AP_enterButton
            // 
            AP_enterButton.Location = new Point(289, 336);
            AP_enterButton.Name = "AP_enterButton";
            AP_enterButton.Size = new Size(102, 23);
            AP_enterButton.TabIndex = 7;
            AP_enterButton.Text = "Add Patient";
            AP_enterButton.UseVisualStyleBackColor = true;
            AP_enterButton.Click += AP_enterButton_Click;
            // 
            // AP_addressEntry
            // 
            AP_addressEntry.Location = new Point(289, 255);
            AP_addressEntry.Name = "AP_addressEntry";
            AP_addressEntry.Size = new Size(243, 23);
            AP_addressEntry.TabIndex = 5;
            // 
            // AP_phoneEntry
            // 
            AP_phoneEntry.Location = new Point(289, 216);
            AP_phoneEntry.MaxLength = 11;
            AP_phoneEntry.Name = "AP_phoneEntry";
            AP_phoneEntry.Size = new Size(100, 23);
            AP_phoneEntry.TabIndex = 4;
            // 
            // AP_emailEntry
            // 
            AP_emailEntry.Location = new Point(289, 175);
            AP_emailEntry.Name = "AP_emailEntry";
            AP_emailEntry.Size = new Size(100, 23);
            AP_emailEntry.TabIndex = 3;
            // 
            // AP_nhsNumberEntry
            // 
            AP_nhsNumberEntry.Location = new Point(289, 137);
            AP_nhsNumberEntry.MaxLength = 10;
            AP_nhsNumberEntry.Name = "AP_nhsNumberEntry";
            AP_nhsNumberEntry.Size = new Size(100, 23);
            AP_nhsNumberEntry.TabIndex = 2;
            // 
            // AP_lastNameEntry
            // 
            AP_lastNameEntry.Location = new Point(289, 97);
            AP_lastNameEntry.Name = "AP_lastNameEntry";
            AP_lastNameEntry.Size = new Size(100, 23);
            AP_lastNameEntry.TabIndex = 1;
            // 
            // AP_firstNameEntry
            // 
            AP_firstNameEntry.Location = new Point(289, 60);
            AP_firstNameEntry.Name = "AP_firstNameEntry";
            AP_firstNameEntry.Size = new Size(100, 23);
            AP_firstNameEntry.TabIndex = 0;
            // 
            // bookAppointmentPage
            // 
            bookAppointmentPage.Controls.Add(BA_label7);
            bookAppointmentPage.Controls.Add(label6);
            bookAppointmentPage.Controls.Add(label5);
            bookAppointmentPage.Controls.Add(BA_label4);
            bookAppointmentPage.Controls.Add(BA_label3);
            bookAppointmentPage.Controls.Add(BA_label2);
            bookAppointmentPage.Controls.Add(BA_label1);
            bookAppointmentPage.Controls.Add(BA_entryButton);
            bookAppointmentPage.Controls.Add(BA_commentTextbox);
            bookAppointmentPage.Controls.Add(BA_datePicker);
            bookAppointmentPage.Controls.Add(BA_doctorTextbox);
            bookAppointmentPage.Controls.Add(BA_minuteCombobox);
            bookAppointmentPage.Controls.Add(BA_hourCombobox);
            bookAppointmentPage.Controls.Add(BA_patientCombobox);
            bookAppointmentPage.Location = new Point(4, 24);
            bookAppointmentPage.Name = "bookAppointmentPage";
            bookAppointmentPage.Size = new Size(792, 390);
            bookAppointmentPage.TabIndex = 2;
            bookAppointmentPage.Text = "Book Appointment";
            bookAppointmentPage.UseVisualStyleBackColor = true;
            // 
            // BA_label7
            // 
            BA_label7.AutoSize = true;
            BA_label7.Location = new Point(199, 202);
            BA_label7.Name = "BA_label7";
            BA_label7.Size = new Size(61, 15);
            BA_label7.TabIndex = 13;
            BA_label7.Text = "Comment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 170);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 12;
            label6.Text = "M";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 170);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 11;
            label5.Text = "H";
            // 
            // BA_label4
            // 
            BA_label4.AutoSize = true;
            BA_label4.Location = new Point(211, 170);
            BA_label4.Name = "BA_label4";
            BA_label4.Size = new Size(33, 15);
            BA_label4.TabIndex = 10;
            BA_label4.Text = "Time";
            // 
            // BA_label3
            // 
            BA_label3.AutoSize = true;
            BA_label3.Location = new Point(211, 132);
            BA_label3.Name = "BA_label3";
            BA_label3.Size = new Size(31, 15);
            BA_label3.TabIndex = 9;
            BA_label3.Text = "Date";
            // 
            // BA_label2
            // 
            BA_label2.AutoSize = true;
            BA_label2.Location = new Point(211, 90);
            BA_label2.Name = "BA_label2";
            BA_label2.Size = new Size(43, 15);
            BA_label2.TabIndex = 8;
            BA_label2.Text = "Doctor";
            // 
            // BA_label1
            // 
            BA_label1.AutoSize = true;
            BA_label1.Location = new Point(211, 51);
            BA_label1.Name = "BA_label1";
            BA_label1.Size = new Size(44, 15);
            BA_label1.TabIndex = 7;
            BA_label1.Text = "Patient";
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
            // viewAppointmentPage
            // 
            viewAppointmentPage.Controls.Add(VA_appointmentTable);
            viewAppointmentPage.Location = new Point(4, 24);
            viewAppointmentPage.Name = "viewAppointmentPage";
            viewAppointmentPage.Size = new Size(792, 390);
            viewAppointmentPage.TabIndex = 3;
            viewAppointmentPage.Text = "View Appointments";
            viewAppointmentPage.UseVisualStyleBackColor = true;
            // 
            // VA_appointmentTable
            // 
            VA_appointmentTable.AllowUserToAddRows = false;
            VA_appointmentTable.AllowUserToDeleteRows = false;
            VA_appointmentTable.AllowUserToResizeColumns = false;
            VA_appointmentTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            VA_appointmentTable.BackgroundColor = SystemColors.Window;
            VA_appointmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VA_appointmentTable.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            VA_appointmentTable.DefaultCellStyle = dataGridViewCellStyle1;
            VA_appointmentTable.Dock = DockStyle.Fill;
            VA_appointmentTable.Location = new Point(0, 0);
            VA_appointmentTable.Name = "VA_appointmentTable";
            VA_appointmentTable.ReadOnly = true;
            VA_appointmentTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            VA_appointmentTable.Size = new Size(792, 390);
            VA_appointmentTable.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Patient";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Doctor";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 75;
            // 
            // Column4
            // 
            Column4.HeaderText = "Time";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Comment";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 274;
            // 
            // Column6
            // 
            Column6.HeaderText = "Edit";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Edit";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 50;
            // 
            // Column7
            // 
            Column7.HeaderText = "Cancel";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Cancel";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 50;
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
            viewAppointmentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VA_appointmentTable).EndInit();
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
        private ComboBox AD_positionCombobox;
        private Label AD_label6;
        private Label AD_label5;
        private Label AD_label4;
        private Label AD_label3;
        private Label AD_label2;
        private Label AD_label1;
        private Label AP_label7;
        private Label AP_label6;
        private Label AP_label5;
        private Label AP_label4;
        private Label AP_label3;
        private Label AP_label2;
        private Label AP_label1;
        private Label BA_label7;
        private Label label6;
        private Label label5;
        private Label BA_label4;
        private Label BA_label3;
        private Label BA_label2;
        private Label BA_label1;
        private TabPage viewAppointmentPage;
        private DataGridView VA_appointmentTable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}
