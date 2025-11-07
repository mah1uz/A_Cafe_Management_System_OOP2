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
    public partial class customerForm : MetroForm
    {
        private int _userId;
        private string _selectedName;
        private decimal _selectedPrice;
        private string _selectedAvailability;
      

        public customerForm(int id)
        {
            InitializeComponent();
            _userId = id;

            
        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            using (CMS con = new CMS())
            {
                var items = con.menuItems
                    .Select(m => new
                    {
                        m.IDNo,
                        m.Name,
                        m.Price,
                        Availability = m.IsAvailable == 1 ? "Yes" : "No"
                    })
                    .ToList();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = items;
                dataGridView1.Refresh();

                dataGridView1.Columns["IDNo"].Visible = false;

            
                var ordersList = con.orders
                    .Where(o => o.UserID == _userId)
                    .Select(o => new
                    {
                        o.ItemName,
                        o.Price,
                        o.Quantity,
                        o.TotalAmount
                    })
                    .ToList();

                dataGridView2.DataSource = ordersList;

             
                if (ordersList == null || ordersList.Count == 0)
                {
                    statusLabel.Text = "APROOVED ORDER";
                }
                else
                {
                    statusLabel.Text = string.Empty;
                }
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                _selectedName = row.Cells["Name"].Value.ToString();
                _selectedPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                _selectedAvailability = row.Cells["Availability"].Value.ToString();
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedName))
            {
                MessageBox.Show("Please double-click a menu item to select it.");
                return;
            }

            if (_selectedAvailability != "Yes")
            {
                MessageBox.Show("This item is not available and cannot be added to the cart.");
                return;
            }

            int quantity;
            if (!int.TryParse(quantityTextBox.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            decimal totalAmount = _selectedPrice * quantity;

         
            using (CMS con = new CMS())
            {
                var order = new order
                {
                    ItemName = _selectedName,
                    UserID = _userId,
                    Price = _selectedPrice,
                    Quantity = quantity,
                    TotalAmount = totalAmount
                };
                con.orders.Add(order);
                con.SaveChanges();

            
                var ordersList = con.orders
                    .Where(o => o.UserID == _userId)
                    .Select(o => new
                    {
                        o.ItemName,
                        o.Price,
                        o.Quantity,
                        o.TotalAmount
                    })
                    .ToList();

                dataGridView2.DataSource = ordersList;
            }

        
            MessageBox.Show($"Added {_selectedName} in cart with a quantity of {quantity}.", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            _selectedName = null;
            _selectedPrice = 0;
            _selectedAvailability = null;
            quantityTextBox.Text = string.Empty;
        }

       

        private void clearCartButton_Click(object sender, EventArgs e)
        {
           
            using (CMS con = new CMS())
            {
                var userOrders = con.orders.Where(o => o.UserID == _userId).ToList();
                con.orders.RemoveRange(userOrders);
                con.SaveChanges();

              
                dataGridView2.DataSource = null;
            }

            MessageBox.Show("Cart has been cleared", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeInfoButton_Click(object sender, EventArgs e)
        {
            signUpForm sg = new signUpForm(_userId);
            sg.Show();
            this.Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logInForm loginForm = new logInForm();
            loginForm.Show();
            this.Hide();
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your purchase has been confirmed, check the STATUS bar");
            statusLabel.Text = "Pending Order";

        }
    }
}
