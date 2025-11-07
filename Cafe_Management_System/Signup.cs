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
    public partial class Signup : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
     //   string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";
        public Signup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text.Trim();
            string username = textBox1.Text.Trim();
            string salaryText = " ";
            string gender = comboBox1.SelectedItem?.ToString();
            string status = "Active";
            string position = " ";
            string password = textBox2.Text.Trim();
            string role = "Customer";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(salaryText) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please fill all fields including Name, Password, and Position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal salary = 0;

            string query = @"
    INSERT INTO Users (Name, Username, Role, Salary, Gender, Status, Password, Position) 
    VALUES (@Name, @Username, @Role, @Salary, @Gender, @Status, @Password, @Position);
    SELECT SCOPE_IDENTITY();"; // Get the inserted ID

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Position", position);

                    object result = cmd.ExecuteScalar(); // returns the ID
                    if (result != null)
                    {
                        int insertedId = Convert.ToInt32(result);
                        MessageBox.Show($"Registration successful!\nYour ID: {insertedId}\nUsername: {username}\nPassword: {password}",
                  "Success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                        Loginpage loginpage = new Loginpage();
                        loginpage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginpage loginpage = new Loginpage();  
                loginpage.Show();
            this.Hide();

        }
    }
}
