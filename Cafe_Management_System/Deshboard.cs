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
    public partial class Deshboard : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
      //  string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";
        public Deshboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deshboard hrDeshboard = new Deshboard();
            hrDeshboard.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmployeesHr employeesHr = new EmployeesHr();
            employeesHr.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT Username, Role, Salary, Gender, Status FROM Users WHERE Role = 'Employee'";
            string query1 = "SELECT COUNT(*) FROM Users WHERE Role = 'Customer'";
            string query2 = "SELECT COUNT(*) FROM Users WHERE Role = 'Employee'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query1, conn);
                    int totalHR = (int)cmd.ExecuteScalar();

                    label7.Text = "Total Customer: " + totalHR.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    int totalEmployee = (int)cmd.ExecuteScalar();

                    label9.Text = "Total Employees: " + totalEmployee.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Username"].Value.ToString();

                textBox3.Text = row.Cells["Salary"].Value.ToString();
                comboBox1.SelectedItem = row.Cells["Gender"].Value.ToString();
                comboBox2.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {




        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void HrDeshboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu56 menu = new Menu56();
            menu.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cpage employeesPage = new cpage();
            employeesPage.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CustomerOder customerOrder = new CustomerOder();
            customerOrder.Show();
            this.Hide();
        }
    }
}

