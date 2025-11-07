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
    public partial class AdminDeshboard : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
      //  string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";
        public AdminDeshboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDeshboard admin = new AdminDeshboard();
            admin.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Addemployee addHR = new Addemployee();
            addHR.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT  *FROM Users WHERE Role = 'Admin'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT  *FROM Users WHERE Role = 'Customer'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users WHERE Role = 'Employee'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Username"].Value.ToString();
                textBox2.Text = row.Cells["Password"].Value.ToString();
                textBox3.Text = row.Cells["Salary"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["Gender"].Value.ToString();
                comboBox2.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Deshboard deshboard = new Deshboard();
            deshboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cpage employeesPage = new cpage();
            employeesPage.Show();
            this.Hide();
        }
    }
}
