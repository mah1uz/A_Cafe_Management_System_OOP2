namespace cafe_management_system_A1
{
    partial class logInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logInButton = new MetroFramework.Controls.MetroButton();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signUpButton = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logInButton);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(31, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 471);
            this.panel1.TabIndex = 1;
            // 
            // logInButton
            // 
            this.logInButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logInButton.Location = new System.Drawing.Point(523, 236);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(145, 40);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseSelectable = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(577, 2);
            this.passwordTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(257, 160);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PromptText = "PASSWORD";
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(459, 28);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMark = "PASSWORD";
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(577, 2);
            this.nameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(257, 106);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PromptText = "Your Unique User Name";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(459, 28);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMark = "Your Unique User Name";
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordLabel
            // 
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordLabel.Location = new System.Drawing.Point(4, 160);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(187, 28);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nameLabel.Location = new System.Drawing.Point(4, 106);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(187, 28);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "User Name:";
            this.nameLabel.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signUpButton);
            this.panel2.Location = new System.Drawing.Point(31, 576);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 52);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // signUpButton
            // 
            this.signUpButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.signUpButton.Highlight = true;
            this.signUpButton.Location = new System.Drawing.Point(0, 4);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(117, 44);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseSelectable = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // logInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "logInForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Log In Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton logInButton;
        private MetroFramework.Controls.MetroButton signUpButton;
    }
}

