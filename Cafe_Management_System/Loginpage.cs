using Cafe_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Loginpage : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
      //  string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";
        public Loginpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            t2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = t1.Text.Trim();
            string password = t2.Text.Trim();
            string role = comboBox1.Text.Trim();

           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); 

                    string name = reader["Name"].ToString();
                    string userId = reader["ID"].ToString();
                   // string position = reader["Position"]?.ToString();

                    MessageBox.Show($"Login successful!\nWelcome, {name}!\nYour ID: {userId}\nRole: {role}\n",
                                    "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                   
                    if (role == "Admin")
                    {
                        AdminDeshboard admin = new AdminDeshboard();
                        admin.Show();
                    }
                    else if (role == "Customer")
                    {
                       // customer customer = new customer();
                       // customer.Show();
                       cpage customer = new cpage();
                        customer.Show();

                    }
                    else if (role == "Employee")
                    {
                        Deshboard deshboard = new Deshboard();
                        deshboard.Show();
                    }

                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Invalid username, password or role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
