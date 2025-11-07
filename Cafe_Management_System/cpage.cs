using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_Management_System { 
    public partial class cpage : Form
    {
        string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=NEW_CAFE_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        //  string connectionString = "Data Source=LAPTOP-2STO46IM\\SQLEXPRESS;Initial Catalog=neww;Integrated Security=True;TrustServerCertificate=True";
        public cpage()
        {
            InitializeComponent();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           //textBox5.Text = "";
            textBox6.Text = "";
            //textBox7.Text = "";
            textBox8.Text = "";

            comboBox1.SelectedIndex = -1; 

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                int userId;
                if (!int.TryParse(textBox1.Text.Trim(), out userId))
                {
                    MessageBox.Show("Invalid User ID");
                    return;
                }

                string comment = textBox2.Text.Trim();

                
                var orderItems = new List<(int menuId, int quantity)>();

                
                if (int.TryParse(textBox3.Text.Trim(), out int menuId1) &&
                    int.TryParse(textBox4.Text.Trim(), out int qty1) && qty1 > 0)
                {
                    orderItems.Add((menuId1, qty1));
                }

               
                if (int.TryParse(textBox5.Text.Trim(), out int menuId2) &&
                    int.TryParse(textBox6.Text.Trim(), out int qty2) && qty2 > 0)
                {
                    orderItems.Add((menuId2, qty2));
                }

                if (orderItems.Count == 0)
                {
                    MessageBox.Show("Please enter at least one valid order item.");
                    return;
                }

                string paymentType = comboBox1.Text.Trim();
                string trxns = " ";
                string phone = textBox8.Text.Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                       
                        string insertOrderQuery = "INSERT INTO Orders (UserID, Comment) OUTPUT INSERTED.ID VALUES (@UserID, @Comment)";
                        SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, conn, transaction);
                        cmdOrder.Parameters.AddWithValue("@UserID", userId);
                        cmdOrder.Parameters.AddWithValue("@Comment", comment);

                        int orderId = (int)cmdOrder.ExecuteScalar();

                       
                        foreach (var item in orderItems)
                        {
                         
                            string priceQuery = "SELECT Price FROM Menu WHERE ID = @MenuID";
                            SqlCommand cmdPrice = new SqlCommand(priceQuery, conn, transaction);
                            cmdPrice.Parameters.AddWithValue("@MenuID", item.menuId);
                            decimal price = (decimal)cmdPrice.ExecuteScalar();

                            string insertOrderItemQuery = "INSERT INTO OrderItems (OrderID, MenuID, Quantity, Price) VALUES (@OrderID, @MenuID, @Quantity, @Price)";
                            SqlCommand cmdOrderItem = new SqlCommand(insertOrderItemQuery, conn, transaction);
                            cmdOrderItem.Parameters.AddWithValue("@OrderID", orderId);
                            cmdOrderItem.Parameters.AddWithValue("@MenuID", item.menuId);
                            cmdOrderItem.Parameters.AddWithValue("@Quantity", item.quantity);
                            cmdOrderItem.Parameters.AddWithValue("@Price", price);

                            cmdOrderItem.ExecuteNonQuery();
                        }

                     
                        if (!string.IsNullOrEmpty(paymentType))
                        {
                            string insertPaymentQuery = "INSERT INTO Payment (OrderID, Type, Trxns, Phone) VALUES (@OrderID, @Type, @Trxns, @Phone)";
                            SqlCommand cmdPayment = new SqlCommand(insertPaymentQuery, conn, transaction);
                            cmdPayment.Parameters.AddWithValue("@OrderID", orderId);
                            cmdPayment.Parameters.AddWithValue("@Type", paymentType);
                            cmdPayment.Parameters.AddWithValue("@Trxns", trxns);
                            cmdPayment.Parameters.AddWithValue("@Phone", phone);

                            cmdPayment.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Order placed successfully. Order ID: " + orderId);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error placing order: " + ex.Message);
                    }
                }
            


        }

        private void ClearInputs()
        {
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT ID, Title, Price, Status FROM Menu WHERE Status = 'Available'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"
SELECT 
    o.ID AS OrderID,
	  o.Status AS Status,
    u.Name AS CustomerName,
    u.Role AS UserRole,
    m.Title AS MenuItem,
    oi.Quantity,
    oi.Price,
    oi.TotalPrice AS TotalAmount,
    o.Date AS OrderDate,
    o.Comment
  
FROM Orders o
JOIN Users u ON o.UserID = u.ID
JOIN OrderItems oi ON o.ID = oi.OrderID
JOIN Menu m ON oi.MenuID = m.ID";
 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt; 
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
               
                
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();


        }
    }
}
