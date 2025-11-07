namespace cafe_management_system_A1
{
    partial class customerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.quantityLabel = new MetroFramework.Controls.MetroLabel();
            this.addToCartButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clearCartButton = new MetroFramework.Controls.MetroButton();
            this.changeInfoButton = new MetroFramework.Controls.MetroButton();
            this.logOutButton = new MetroFramework.Controls.MetroButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.confirmButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(630, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // quantityTextBox
            // 
            // 
            // 
            // 
            this.quantityTextBox.CustomButton.Image = null;
            this.quantityTextBox.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.quantityTextBox.CustomButton.Name = "";
            this.quantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantityTextBox.CustomButton.TabIndex = 1;
            this.quantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantityTextBox.CustomButton.UseSelectable = true;
            this.quantityTextBox.CustomButton.Visible = false;
            this.quantityTextBox.Lines = new string[0];
            this.quantityTextBox.Location = new System.Drawing.Point(698, 163);
            this.quantityTextBox.MaxLength = 32767;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.PromptText = "Integar Number";
            this.quantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityTextBox.SelectedText = "";
            this.quantityTextBox.SelectionLength = 0;
            this.quantityTextBox.SelectionStart = 0;
            this.quantityTextBox.ShortcutsEnabled = true;
            this.quantityTextBox.Size = new System.Drawing.Size(119, 23);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.UseSelectable = true;
            this.quantityTextBox.WaterMark = "Integar Number";
            this.quantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.quantityTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.quantityLabel.Location = new System.Drawing.Point(720, 132);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(83, 28);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity";
            // 
            // addToCartButton
            // 
            this.addToCartButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addToCartButton.Location = new System.Drawing.Point(674, 203);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(158, 41);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseSelectable = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(850, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(546, 361);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // clearCartButton
            // 
            this.clearCartButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearCartButton.Location = new System.Drawing.Point(850, 493);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(162, 48);
            this.clearCartButton.TabIndex = 5;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseSelectable = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // changeInfoButton
            // 
            this.changeInfoButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.changeInfoButton.Location = new System.Drawing.Point(1136, 30);
            this.changeInfoButton.Name = "changeInfoButton";
            this.changeInfoButton.Size = new System.Drawing.Size(189, 42);
            this.changeInfoButton.TabIndex = 6;
            this.changeInfoButton.Text = "Change Info";
            this.changeInfoButton.UseSelectable = true;
            this.changeInfoButton.Click += new System.EventHandler(this.changeInfoButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.logOutButton.Highlight = true;
            this.logOutButton.Location = new System.Drawing.Point(1255, 643);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(111, 33);
            this.logOutButton.TabIndex = 20;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseSelectable = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(1083, 493);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(283, 48);
            this.statusLabel.TabIndex = 21;
            this.statusLabel.Text = "Pending...";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.confirmButton.Location = new System.Drawing.Point(850, 574);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(162, 48);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseSelectable = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // customerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 708);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.changeInfoButton);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "customerForm";
            this.Text = "Customer View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.customerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox quantityTextBox;
        private MetroFramework.Controls.MetroLabel quantityLabel;
        private MetroFramework.Controls.MetroButton addToCartButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroButton clearCartButton;
        private MetroFramework.Controls.MetroButton changeInfoButton;
        private MetroFramework.Controls.MetroButton logOutButton;
        private System.Windows.Forms.Label statusLabel;
        private MetroFramework.Controls.MetroButton confirmButton;
    }
}