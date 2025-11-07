using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management_system_A1
{
    public partial class logInForm : MetroForm
    {
        public logInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void logIn( string name, string password)
        {
            using (CMS cms = new CMS())
            {
                
                

                var user = cms.users.FirstOrDefault(u =>
                   
                    u.Username == name &&
                    u.Password == password);

                if (user == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Not registered, please sign up.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                 
                    if (user.Role == "admin")
                    {
                        this.Hide();
                        new admin(user.ID).Show();
                    }
                    
                    else if (user.Role == "customer")
                   {
                       this.Hide();
                       new customerForm( user.ID).Show();
                    }
                }
            }
        }

        private void IdTextBox_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            

            string name = nameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MetroFramework.MetroMessageBox.Show(this, "Name and password cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            logIn( name, password);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUpForm signUpForm = new signUpForm();
            signUpForm.Show();

            this.Hide();
        }
    }
}
