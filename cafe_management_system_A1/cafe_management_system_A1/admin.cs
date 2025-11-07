using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_management_system_A1
{
    public partial class admin : Form
    {
        private string connectionString = "Data Source=DESKTOP-6QC7E5J;Initial Catalog=cafe_management_system_A1;Integrated Security=True;TrustServerCertificate=True";
        private string[] tables = { "users", "menuItems", "orders" };
        int currentTableIndex = 0;
        private int _adminUserId;

        public admin(int adminUserId)
        {
            InitializeComponent();
            _adminUserId = adminUserId;
            LoadTable();
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            currentTableIndex = (currentTableIndex + 1) % tables.Length;
            LoadTable();
        }

        private void LoadTable()
        {
            string query = $"SELECT * FROM {tables[currentTableIndex]}";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                tableNameLabel.Text = $"Table: {tables[currentTableIndex]}";
            }
    
            checkOutButton.Visible = (tables[currentTableIndex] == "orders");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells.Count > 0 ? row.Cells[0].Value?.ToString() ?? "" : "";
                textBox2.Text = row.Cells.Count > 1 ? row.Cells[1].Value?.ToString() ?? "" : "";
                textBox3.Text = row.Cells.Count > 2 ? row.Cells[2].Value?.ToString() ?? "" : "";
                textBox4.Text = row.Cells.Count > 3 ? row.Cells[3].Value?.ToString() ?? "" : "";
                textBox5.Text = row.Cells.Count > 4 ? row.Cells[4].Value?.ToString() ?? "" : "";
                textBox6.Text = row.Cells.Count > 5 ? row.Cells[5].Value?.ToString() ?? "" : "";





            }
        }

        private void UpdateRow()
        {
            var dt = dataGridView1.DataSource as DataTable;
            if (dt == null) return;

            var pkColumn = dt.Columns[0].ColumnName;
            var pkValue = textBox1.Text;

            List<string> setClauses = new List<string>();
            for (int i = 1; i < Math.Min(6, dt.Columns.Count); i++)
            {
                var colName = dt.Columns[i].ColumnName;
                var tb = Controls.Find($"textBox{i + 1}", true).FirstOrDefault() as TextBox;
                if (tb != null)
                    setClauses.Add($"{colName} = '{tb.Text.Replace("'", "''")}'");
            }

            string query = $"UPDATE {tables[currentTableIndex]} SET {string.Join(", ", setClauses)} WHERE {pkColumn} = '{pkValue.Replace("'", "''")}'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            LoadTable();
        }

        private void DeleteRow()
        {
            var dt = dataGridView1.DataSource as DataTable;
            if (dt == null) return;

            var pkColumn = dt.Columns[0].ColumnName;
            var pkValue = textBox1.Text;

            string query = $"DELETE FROM {tables[currentTableIndex]} WHERE {pkColumn} = '{pkValue.Replace("'", "''")}'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            LoadTable();
        }

        private void CreateRow()
        {
            var dt = dataGridView1.DataSource as DataTable;
            if (dt == null) return;

            List<string> columns = new List<string>();
            List<string> values = new List<string>();
            for (int i = 0; i < Math.Min(6, dt.Columns.Count); i++)
            {
                var colName = dt.Columns[i].ColumnName;
                var tb = Controls.Find($"textBox{i + 1}", true).FirstOrDefault() as TextBox;
                if (tb != null && !string.IsNullOrWhiteSpace(tb.Text))
                {
                    columns.Add(colName);
                    values.Add($"'{tb.Text.Replace("'", "''")}'");
                }
            }

            string query = $"INSERT INTO {tables[currentTableIndex]} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)})";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            LoadTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTable();


            textBox1.Text =  "";
            textBox2.Text =  "";
            textBox3.Text =  "";
            textBox4.Text = "";
            textBox5.Text =  "";
            textBox6.Text =  "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateRow();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateRow();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logInForm loginForm = new logInForm();  
            loginForm.Show();
            this.Hide(); 
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
           
            if (tables[currentTableIndex] == "orders")
            {
                var result = MessageBox.Show("Are you sure you want to checkout all orders?", "Confirm checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM orders";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    LoadTable();
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

      
    }
}
