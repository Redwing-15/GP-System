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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            LS_tabControl.SuspendLayout();
            loginPage.SuspendLayout();
            tabControl.SuspendLayout();
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
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(0, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(801, 418);
            tabControl.TabIndex = 2;
            tabControl.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 390);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
