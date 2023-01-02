namespace wholesalers
{
    partial class SellPoint
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
            this.SeacrhProc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDinOrder = new System.Windows.Forms.Button();
            this.DebtBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.placeorder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ProcQuantity = new System.Windows.Forms.TextBox();
            this.ProcTotalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderTotalPrice = new System.Windows.Forms.TextBox();
            this.Expensebtn = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // SeacrhProc
            // 
            this.SeacrhProc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeacrhProc.Location = new System.Drawing.Point(141, 193);
            this.SeacrhProc.Name = "SeacrhProc";
            this.SeacrhProc.Size = new System.Drawing.Size(450, 34);
            this.SeacrhProc.TabIndex = 0;
            this.SeacrhProc.TextChanged += new System.EventHandler(this.SeacrhProc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Product";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderView);
            this.panel1.Location = new System.Drawing.Point(1143, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 397);
            this.panel1.TabIndex = 2;
            // 
            // OrderView
            // 
            this.OrderView.AllowUserToAddRows = false;
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.QuantityOrdered,
            this.TotalPrice,
            this.ProductID});
            this.OrderView.Location = new System.Drawing.Point(3, 0);
            this.OrderView.Name = "OrderView";
            this.OrderView.ReadOnly = true;
            this.OrderView.RowHeadersWidth = 51;
            this.OrderView.RowTemplate.Height = 24;
            this.OrderView.Size = new System.Drawing.Size(754, 394);
            this.OrderView.TabIndex = 0;
            this.OrderView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderView_KeyDown);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 150;
            // 
            // QuantityOrdered
            // 
            this.QuantityOrdered.HeaderText = "Quantity";
            this.QuantityOrdered.MinimumWidth = 6;
            this.QuantityOrdered.Name = "QuantityOrdered";
            this.QuantityOrdered.ReadOnly = true;
            this.QuantityOrdered.Width = 190;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 200;
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
            // ADDinOrder
            // 
            this.ADDinOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDinOrder.Location = new System.Drawing.Point(1449, 320);
            this.ADDinOrder.Name = "ADDinOrder";
            this.ADDinOrder.Size = new System.Drawing.Size(179, 51);
            this.ADDinOrder.TabIndex = 3;
            this.ADDinOrder.Text = "Add in Order";
            this.ADDinOrder.UseVisualStyleBackColor = true;
            this.ADDinOrder.Click += new System.EventHandler(this.ADDinOrder_Click);
            // 
            // DebtBtn
            // 
            this.DebtBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebtBtn.Location = new System.Drawing.Point(120, 29);
            this.DebtBtn.Name = "DebtBtn";
            this.DebtBtn.Size = new System.Drawing.Size(126, 102);
            this.DebtBtn.TabIndex = 4;
            this.DebtBtn.Text = "Debt Info";
            this.DebtBtn.UseVisualStyleBackColor = true;
            this.DebtBtn.Click += new System.EventHandler(this.DebtBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductView);
            this.panel2.Location = new System.Drawing.Point(49, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 683);
            this.panel2.TabIndex = 3;
            // 
            // ProductView
            // 
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(0, 0);
            this.ProductView.Name = "ProductView";
            this.ProductView.RowHeadersWidth = 51;
            this.ProductView.RowTemplate.Height = 24;
            this.ProductView.Size = new System.Drawing.Size(686, 683);
            this.ProductView.TabIndex = 0;
            this.ProductView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductView_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1136, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Order Information";
            // 
            // placeorder
            // 
            this.placeorder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorder.Location = new System.Drawing.Point(1742, 905);
            this.placeorder.Name = "placeorder";
            this.placeorder.Size = new System.Drawing.Size(158, 61);
            this.placeorder.TabIndex = 7;
            this.placeorder.Text = "Place Order";
            this.placeorder.UseVisualStyleBackColor = true;
            this.placeorder.Click += new System.EventHandler(this.placeorder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1337, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantity:";
            // 
            // ProcQuantity
            // 
            this.ProcQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcQuantity.Location = new System.Drawing.Point(1511, 208);
            this.ProcQuantity.Name = "ProcQuantity";
            this.ProcQuantity.Size = new System.Drawing.Size(188, 56);
            this.ProcQuantity.TabIndex = 12;
            this.ProcQuantity.Text = "1";
            this.ProcQuantity.TextChanged += new System.EventHandler(this.ProcQuantity_TextChanged);
            this.ProcQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProcQuantity_KeyPress);
            // 
            // ProcTotalPrice
            // 
            this.ProcTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcTotalPrice.Location = new System.Drawing.Point(1724, 12);
            this.ProcTotalPrice.Name = "ProcTotalPrice";
            this.ProcTotalPrice.Size = new System.Drawing.Size(188, 56);
            this.ProcTotalPrice.TabIndex = 14;
            this.ProcTotalPrice.Text = "0";
            this.ProcTotalPrice.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1148, 899);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Amount";
            // 
            // OrderTotalPrice
            // 
            this.OrderTotalPrice.AccessibleName = "";
            this.OrderTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTotalPrice.Location = new System.Drawing.Point(1366, 896);
            this.OrderTotalPrice.Name = "OrderTotalPrice";
            this.OrderTotalPrice.Size = new System.Drawing.Size(189, 43);
            this.OrderTotalPrice.TabIndex = 16;
            // 
            // Expensebtn
            // 
            this.Expensebtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expensebtn.Location = new System.Drawing.Point(290, 29);
            this.Expensebtn.Name = "Expensebtn";
            this.Expensebtn.Size = new System.Drawing.Size(126, 102);
            this.Expensebtn.TabIndex = 17;
            this.Expensebtn.Text = "Expense";
            this.Expensebtn.UseVisualStyleBackColor = true;
            this.Expensebtn.Click += new System.EventHandler(this.Expensebtn_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(1788, 74);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(124, 58);
            this.Logout.TabIndex = 18;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // SellPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Expensebtn);
            this.Controls.Add(this.OrderTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProcTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProcQuantity);
            this.Controls.Add(this.placeorder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DebtBtn);
            this.Controls.Add(this.ADDinOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeacrhProc);
            this.Name = "SellPoint";
            this.Text = "SellPoint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeacrhProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ADDinOrder;
        private System.Windows.Forms.Button DebtBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button placeorder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProcQuantity;
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.TextBox ProcTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Button Expensebtn;
        private System.Windows.Forms.Button Logout;
    }
}