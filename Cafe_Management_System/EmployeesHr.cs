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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Management_System
{
    public partial class EmployeesHr : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";

        //  string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";
        public EmployeesHr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmployeesHr employeesHr = new EmployeesHr();
            employeesHr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Users WHERE Role = 'Customer'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                textBox1.Text = row.Cells["Username"].Value?.ToString();
                textBox2.Text = row.Cells["Password"].Value?.ToString();
                textBox3.Text = row.Cells["Salary"].Value?.ToString();
                textBox4.Text = row.Cells["ID"].Value?.ToString();
                textBox8.Text = row.Cells["Name"].Value?.ToString();
                comboBox1.SelectedItem = row.Cells["Gender"].Value?.ToString();
                comboBox2.SelectedItem = row.Cells["Status"].Value?.ToString();
                comboBox3.SelectedItem = row.Cells["Position"].Value?.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            string username = textBox1.Text.Trim();
            string salaryText = textBox3.Text.Trim();
            string gender = comboBox1.SelectedItem?.ToString();
            string status = comboBox2.SelectedItem?.ToString();
            string password = textBox2.Text.Trim();
            string position = textBox4.Text.Trim();  
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(salaryText) || string.IsNullOrEmpty(gender)
               || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Please fill all fields including Password and Position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Invalid salary value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = "Employee";

            string query = "INSERT INTO Users (Username, Role, Salary, Gender, Status, Password, Position) VALUES (@Username, @Role, @Salary, @Gender, @Status, @Password, @Position)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Position", position);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Employee data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else
                        MessageBox.Show("Failed to add Employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text.Trim(), out int userId))
            {
                MessageBox.Show("Please enter a valid User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            string query = "DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("User not found or delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(textBox4.Text.Trim(), out int userId))
            {
                MessageBox.Show("Please enter a valid User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = textBox1.Text.Trim();
            string salaryText = textBox3.Text.Trim();
            string gender = comboBox1.SelectedItem?.ToString();
            string status = comboBox2.SelectedItem?.ToString();
            string password = textBox2.Text.Trim();
            string position = textBox4.Text.Trim(); 

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(salaryText) || string.IsNullOrEmpty(gender)
               || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please fill all fields including Password and Position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Invalid salary value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
UPDATE Users SET 
    Username = @Username, 
    Salary = @Salary, 
    Gender = @Gender, 
    Status = @Status, 
    Password = @Password,
    Position = @Position
WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("User data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("User not found or update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string name = textBox8.Text.Trim();
            string username = textBox1.Text.Trim();
            string salaryText = textBox3.Text.Trim();
            string gender = comboBox1.SelectedItem?.ToString();
            string status = comboBox2.SelectedItem?.ToString();
            string position = comboBox3.SelectedItem?.ToString();
            string password = textBox2.Text.Trim();
            string role = "Customer";


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(salaryText) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Please fill all fields including Name, Password, and Position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Invalid salary value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string query = "INSERT INTO Users (Name, Username, Role, Salary, Gender, Status, Password, Position) " +
                           "VALUES (@Name, @Username, @Role, @Salary, @Gender, @Status, @Password, @Position)";

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

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Failed to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text.Trim(), out int userId))
            {
                MessageBox.Show("Please enter a valid User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = textBox8.Text.Trim();
            string username = textBox1.Text.Trim();
            string salaryText = textBox3.Text.Trim();
            string gender = comboBox1.SelectedItem?.ToString();
            string status = comboBox2.SelectedItem?.ToString();
            string position = comboBox3.SelectedItem?.ToString();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(salaryText) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields including Name and Position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Invalid salary value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
        UPDATE Users SET 
            Name = @Name,
            Username = @Username, 
            Salary = @Salary, 
            Gender = @Gender, 
            Status = @Status, 
            Password = @Password,
            Position = @Position
        WHERE ID = @UserID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("User data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("User not found or update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text.Trim(), out int userId))
            {
                MessageBox.Show("Please enter a valid User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            string query = "DELETE FROM Users WHERE ID = @UserID"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("User not found or delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Deshboard deshboard = new Deshboard();
            deshboard.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Menu56 menu56 = new Menu56();
            menu56.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cpage employeesPage = new cpage();
            employeesPage.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CustomerOder customerOder = new CustomerOder();
            customerOder.Show();
            this.Hide();

        }
    }
}
