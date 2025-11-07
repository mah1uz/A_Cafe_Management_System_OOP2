using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management_system_A1
{
    public partial class signUpForm : MetroForm
    {
        private int _userId; 

        public signUpForm()
        {
            InitializeComponent();
        }

        public signUpForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (CMS cms = new CMS())
                {
                    bool nameExists = cms.users.Any(u => u.Username == name);
                    if (nameExists)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please create a unique username.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var userRole = "customer";
                    if (_userId > 0)
                    {
                        var adminUser = cms.users.FirstOrDefault(u => u.ID == _userId);
                        if (adminUser != null && adminUser.Role == "admin")
                        {
                            userRole = "admin";
                        }
                    }

                    var user = new user
                    {
                        Username = name,
                        Password = password,
                        Role = userRole,
                        Email = email,
                        Created = DateTime.Now
                    };

                    cms.users.Add(user);
                    cms.SaveChanges();

                    MetroFramework.MetroMessageBox.Show(this, "Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    logInForm logInForm = new logInForm();
                    logInForm.Show();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUpForm_Load(object sender, EventArgs e)
        {

        }

        private void idTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            logInForm logInForm = new logInForm();
            logInForm.Show();
            this.Hide();
        }
    }
}
