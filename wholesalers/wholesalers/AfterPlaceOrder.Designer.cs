namespace wholesalers
{
    partial class AfterPlaceOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.CusContactNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isDEBTcheck = new System.Windows.Forms.CheckBox();
            this.placeOrder = new System.Windows.Forms.Button();
            this.addCus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpList = new System.Windows.Forms.ComboBox();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Phone No";
            // 
            // CusContactNO
            // 
            this.CusContactNO.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusContactNO.Location = new System.Drawing.Point(351, 84);
            this.CusContactNO.Name = "CusContactNO";
            this.CusContactNO.Size = new System.Drawing.Size(257, 34);
            this.CusContactNO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // isDEBTcheck
            // 
            this.isDEBTcheck.AutoSize = true;
            this.isDEBTcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isDEBTcheck.Location = new System.Drawing.Point(169, 255);
            this.isDEBTcheck.Name = "isDEBTcheck";
            this.isDEBTcheck.Size = new System.Drawing.Size(152, 29);
            this.isDEBTcheck.TabIndex = 4;
            this.isDEBTcheck.Text = "Place as debt";
            this.isDEBTcheck.UseVisualStyleBackColor = true;
            // 
            // placeOrder
            // 
            this.placeOrder.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrder.Location = new System.Drawing.Point(305, 365);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(118, 72);
            this.placeOrder.TabIndex = 6;
            this.placeOrder.Text = "Place Order";
            this.placeOrder.UseVisualStyleBackColor = true;
            this.placeOrder.Click += new System.EventHandler(this.placeOrder_Click);
            // 
            // addCus
            // 
            this.addCus.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCus.Location = new System.Drawing.Point(456, 365);
            this.addCus.Name = "addCus";
            this.addCus.Size = new System.Drawing.Size(118, 72);
            this.addCus.TabIndex = 7;
            this.addCus.Text = "Add Customer";
            this.addCus.UseVisualStyleBackColor = true;
            this.addCus.Click += new System.EventHandler(this.addCus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.QuantityOrdered,
            this.TotalPrice,
            this.ProductID});
            this.dataGridView1.Location = new System.Drawing.Point(781, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(64, 31);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            // 
            // EmpList
            // 
            this.EmpList.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpList.FormattingEnabled = true;
            this.EmpList.Location = new System.Drawing.Point(351, 180);
            this.EmpList.Name = "EmpList";
            this.EmpList.Size = new System.Drawing.Size(257, 39);
            this.EmpList.TabIndex = 9;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // QuantityOrdered
            // 
            this.QuantityOrdered.HeaderText = "Quantity";
            this.QuantityOrdered.MinimumWidth = 6;
            this.QuantityOrdered.Name = "QuantityOrdered";
            this.QuantityOrdered.ReadOnly = true;
            this.QuantityOrdered.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            this.ProductID.Width = 125;
            // 
            // AfterPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 557);
            this.Controls.Add(this.EmpList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addCus);
            this.Controls.Add(this.placeOrder);
            this.Controls.Add(this.isDEBTcheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CusContactNO);
            this.Controls.Add(this.label1);
            this.Name = "AfterPlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfterPlaceOrder";
            this.Load += new System.EventHandler(this.AfterPlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CusContactNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isDEBTcheck;
        private System.Windows.Forms.Button placeOrder;
        private System.Windows.Forms.Button addCus;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox EmpList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
    }
}