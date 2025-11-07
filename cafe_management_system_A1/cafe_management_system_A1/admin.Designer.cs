using System;
using System.Windows.Forms;

namespace cafe_management_system_A1
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toggleButton = new MetroFramework.Controls.MetroButton();
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.logOutButton = new MetroFramework.Controls.MetroButton();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.adminCreatorButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleButton
            // 
            this.toggleButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.toggleButton.Location = new System.Drawing.Point(52, 29);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(118, 47);
            this.toggleButton.TabIndex = 0;
            this.toggleButton.Text = "TOGGLE";
            this.toggleButton.UseSelectable = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableNameLabel.Location = new System.Drawing.Point(25, 139);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(341, 32);
            this.tableNameLabel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(771, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Create";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.createButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(896, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(946, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Column 1:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(946, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Column 2:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(946, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Column 3:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(946, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Column 4:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(946, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Column 5:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(946, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Column 6:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1111, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1111, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1111, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 22);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1111, 286);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 22);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1111, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 22);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1111, 409);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 22);
            this.textBox6.TabIndex = 18;
            // 
            // logOutButton
            // 
            this.logOutButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logOutButton.Highlight = true;
            this.logOutButton.Location = new System.Drawing.Point(1225, 606);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(111, 33);
            this.logOutButton.TabIndex = 19;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseSelectable = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(1225, 553);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(111, 37);
            this.checkOutButton.TabIndex = 20;
            this.checkOutButton.Text = "Clear All";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(946, 582);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(140, 42);
            this.confirmButton.TabIndex = 21;
            this.confirmButton.Text = "Confirm Order";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // adminCreatorButton
               
              //this.adminCreatorButton.FontSize = MetroFramework.MetroButtonSize.Tall;
              //this.adminCreatorButton.Location = new System.Drawing.Point(1100, 25);
              //this.adminCreatorButton.Name = "adminCreatorButton";
              //this.adminCreatorButton.Size = new System.Drawing.Size(258, 37);
              //this.adminCreatorButton.TabIndex = 22;
              //this.adminCreatorButton.Text = "Create Admin";
              //this.adminCreatorButton.UseSelectable = true;
              //this.adminCreatorButton.Click += new System.EventHandler(this.adminCreatorButton_Click);
               
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 665);
            this.Controls.Add(this.adminCreatorButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableNameLabel);
            this.Controls.Add(this.toggleButton);
            this.Name = "admin";
            this.Text = "ADMIN PANEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add your implementation here, if needed.
            MessageBox.Show($"Cell clicked at row {e.RowIndex}, column {e.ColumnIndex}");
        }

        #endregion

        private MetroFramework.Controls.MetroButton toggleButton;
        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private MetroFramework.Controls.MetroButton logOutButton;
        private Button checkOutButton;
        private Button confirmButton;
        private MetroFramework.Controls.MetroButton adminCreatorButton;
    }
}