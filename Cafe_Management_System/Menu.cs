using Cafe_Management_System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Cafe_Management_System
{
    public partial class Menu56 : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
       // string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";

        public Menu56()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deshboard deshboard = new Deshboard();
            deshboard.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadMenuData();
        }

        private void LoadMenuData()
        {
            string query = "SELECT * FROM Menu";

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

                textBox3.Text = row.Cells["ID"].Value?.ToString() ?? "";
                textBox2.Text = row.Cells["Title"].Value?.ToString() ?? "";
                textBox1.Text = row.Cells["Price"].Value?.ToString() ?? "";
                comboBox2.SelectedItem = row.Cells["Status"].Value?.ToString() ?? "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox2.Text.Trim();
            string priceText = textBox1.Text.Trim();
            string status = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price format. Please enter a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Menu (Title, Price, Status) VALUES (@Title, @Price, @Status)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Status", status);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMenuData();  
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idText = textBox3.Text.Trim();
            string title = textBox2.Text.Trim();
            string priceText = textBox1.Text.Trim();
            string status = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(idText) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select a menu item to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idText, out int menuId))
            {
                MessageBox.Show("Invalid ID format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Menu SET Title = @Title, Price = @Price, Status = @Status WHERE ID = @ID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@ID", menuId);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Menu item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMenuData();  
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            comboBox2.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
