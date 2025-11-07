using Cafe_Management_System;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Management_System
{
    public partial class CustomerOder : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";

        //  string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";

        public CustomerOder()
        {
            InitializeComponent();
        }

       
        private void LoadOrders()
        {
            string query = "SELECT * FROM Orders WHERE Status = 'Pending'";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

       
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int orderId;
            if (!int.TryParse(textBox1.Text.Trim(), out orderId))
            {
                MessageBox.Show("Please enter a valid OrderID.");
                return;
            }

            string query = "UPDATE Orders SET Status = 'Confirmed' WHERE ID = @ID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", orderId);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order confirmed successfully!");
                    LoadOrders(); 
                }
                else
                {
                    MessageBox.Show("OrderID not found or update failed.");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deshboard deshboard = new Deshboard();
            deshboard.Show();
            this.Hide(); 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

              

                textBox1.Text = row.Cells["ID"].Value.ToString(); 
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Orders";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }

        }
    }

        
    }

