namespace wholesalers
{
    partial class viewStocks
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
            this.Goback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productViewasStock = new System.Windows.Forms.DataGridView();
            this.filterProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceRetail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.priceUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ContackNoCom = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.PreOrder = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.addInOrder = new System.Windows.Forms.Button();
            this.UpdateStock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderListView = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintO = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.updatePrice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productViewasStock)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderListView)).BeginInit();
            this.SuspendLayout();
            // 
            // Goback
            // 
            this.Goback.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goback.Location = new System.Drawing.Point(12, 12);
            this.Goback.Name = "Goback";
            this.Goback.Size = new System.Drawing.Size(176, 110);
            this.Goback.TabIndex = 0;
            this.Goback.Text = "Go to Dashboard";
            this.Goback.UseVisualStyleBackColor = true;
            this.Goback.Click += new System.EventHandler(this.Goback_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productViewasStock);
            this.panel1.Location = new System.Drawing.Point(1294, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 664);
            this.panel1.TabIndex = 1;
            // 
            // productViewasStock
            // 
            this.productViewasStock.AllowUserToAddRows = false;
            this.productViewasStock.AllowUserToDeleteRows = false;
            this.productViewasStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productViewasStock.Location = new System.Drawing.Point(0, 0);
            this.productViewasStock.Name = "productViewasStock";
            this.productViewasStock.ReadOnly = true;
            this.productViewasStock.RowHeadersWidth = 51;
            this.productViewasStock.RowTemplate.Height = 24;
            this.productViewasStock.Size = new System.Drawing.Size(618, 661);
            this.productViewasStock.TabIndex = 1;
            this.productViewasStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productViewasStock_CellClick);
            // 
            // filterProducts
            // 
            this.filterProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterProducts.FormattingEnabled = true;
            this.filterProducts.Items.AddRange(new object[] {
            "All",
            "Quantity less than 30",
            "Quantity with price greater than 5000"});
            this.filterProducts.Location = new System.Drawing.Point(1425, 60);
            this.filterProducts.Name = "filterProducts";
            this.filterProducts.Size = new System.Drawing.Size(451, 35);
            this.filterProducts.TabIndex = 2;
            this.filterProducts.SelectedIndexChanged += new System.EventHandler(this.filterProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1298, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filters:";
            // 
            // SearchProduct
            // 
            this.SearchProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProduct.Location = new System.Drawing.Point(1516, 141);
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(360, 37);
            this.SearchProduct.TabIndex = 4;
            this.SearchProduct.TextChanged += new System.EventHandler(this.SearchProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1597, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search by Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1297, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Products Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(532, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 49);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Info";
            // 
            // NameProduct
            // 
            this.NameProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct.Location = new System.Drawing.Point(298, 271);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(269, 37);
            this.NameProduct.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(693, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Company Name";
            // 
            // NameCompany
            // 
            this.NameCompany.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameCompany.Location = new System.Drawing.Point(928, 273);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.Size = new System.Drawing.Size(269, 37);
            this.NameCompany.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Retail Price";
            // 
            // PriceRetail
            // 
            this.PriceRetail.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceRetail.Location = new System.Drawing.Point(298, 426);
            this.PriceRetail.Name = "PriceRetail";
            this.PriceRetail.Size = new System.Drawing.Size(269, 37);
            this.PriceRetail.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Unit Price";
            // 
            // priceUnit
            // 
            this.priceUnit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceUnit.Location = new System.Drawing.Point(928, 428);
            this.priceUnit.Name = "priceUnit";
            this.priceUnit.Size = new System.Drawing.Size(269, 37);
            this.priceUnit.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Supplier\'s Contact No";
            // 
            // ContackNoCom
            // 
            this.ContackNoCom.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContackNoCom.Location = new System.Drawing.Point(642, 351);
            this.ContackNoCom.Name = "ContackNoCom";
            this.ContackNoCom.Size = new System.Drawing.Size(322, 37);
            this.ContackNoCom.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(716, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ordered Quantity";
            // 
            // PreOrder
            // 
            this.PreOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreOrder.Location = new System.Drawing.Point(997, 511);
            this.PreOrder.Name = "PreOrder";
            this.PreOrder.Size = new System.Drawing.Size(200, 37);
            this.PreOrder.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 31);
            this.label11.TabIndex = 19;
            this.label11.Text = "Quantity In Sotcks";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(385, 509);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(182, 37);
            this.Quantity.TabIndex = 18;
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(1086, 660);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(124, 82);
            this.AddProduct.TabIndex = 22;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // addInOrder
            // 
            this.addInOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInOrder.Location = new System.Drawing.Point(956, 660);
            this.addInOrder.Name = "addInOrder";
            this.addInOrder.Size = new System.Drawing.Size(124, 175);
            this.addInOrder.TabIndex = 23;
            this.addInOrder.Text = "Add in Order";
            this.addInOrder.UseVisualStyleBackColor = true;
            this.addInOrder.Click += new System.EventHandler(this.addInOrder_Click);
            // 
            // UpdateStock
            // 
            this.UpdateStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStock.Location = new System.Drawing.Point(1086, 748);
            this.UpdateStock.Name = "UpdateStock";
            this.UpdateStock.Size = new System.Drawing.Size(124, 87);
            this.UpdateStock.TabIndex = 24;
            this.UpdateStock.Text = "Update Stocks ";
            this.UpdateStock.UseVisualStyleBackColor = true;
            this.UpdateStock.Click += new System.EventHandler(this.UpdateStock_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orderListView);
            this.panel2.Location = new System.Drawing.Point(12, 660);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 311);
            this.panel2.TabIndex = 25;
            // 
            // orderListView
            // 
            this.orderListView.AllowUserToAddRows = false;
            this.orderListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.CName,
            this.ContactNo,
            this.UPrice,
            this.QuantityOrdered,
            this.TotalP,
            this.ProductID});
            this.orderListView.Location = new System.Drawing.Point(0, 3);
            this.orderListView.Name = "orderListView";
            this.orderListView.ReadOnly = true;
            this.orderListView.RowHeadersWidth = 51;
            this.orderListView.RowTemplate.Height = 24;
            this.orderListView.Size = new System.Drawing.Size(880, 311);
            this.orderListView.TabIndex = 0;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProductName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 125;
            // 
            // CName
            // 
            this.CName.HeaderText = "Company Name";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 125;
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "Contact Number";
            this.ContactNo.MinimumWidth = 6;
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.ReadOnly = true;
            this.ContactNo.Width = 125;
            // 
            // UPrice
            // 
            this.UPrice.HeaderText = "Price";
            this.UPrice.MinimumWidth = 6;
            this.UPrice.Name = "UPrice";
            this.UPrice.ReadOnly = true;
            this.UPrice.Width = 125;
            // 
            // QuantityOrdered
            // 
            this.QuantityOrdered.HeaderText = "Quantity";
            this.QuantityOrdered.MinimumWidth = 6;
            this.QuantityOrdered.Name = "QuantityOrdered";
            this.QuantityOrdered.ReadOnly = true;
            this.QuantityOrdered.Width = 125;
            // 
            // TotalP
            // 
            this.TotalP.HeaderText = "TotalPrice";
            this.TotalP.MinimumWidth = 6;
            this.TotalP.Name = "TotalP";
            this.TotalP.ReadOnly = true;
            this.TotalP.Width = 125;
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
            // PrintO
            // 
            this.PrintO.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintO.Location = new System.Drawing.Point(952, 890);
            this.PrintO.Name = "PrintO";
            this.PrintO.Size = new System.Drawing.Size(192, 84);
            this.PrintO.TabIndex = 26;
            this.PrintO.Text = "Print List";
            this.PrintO.UseVisualStyleBackColor = true;
            this.PrintO.Click += new System.EventHandler(this.PrintO_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "Order to be Placed";
            // 
            // updatePrice
            // 
            this.updatePrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrice.Location = new System.Drawing.Point(952, 606);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.Size = new System.Drawing.Size(258, 48);
            this.updatePrice.TabIndex = 28;
            this.updatePrice.Text = "Update Price";
            this.updatePrice.UseVisualStyleBackColor = true;
            this.updatePrice.Click += new System.EventHandler(this.updatePrice_Click);
            // 
            // viewStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.updatePrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PrintO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UpdateStock);
            this.Controls.Add(this.addInOrder);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PreOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ContackNoCom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.priceUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PriceRetail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Goback);
            this.Name = "viewStocks";
            this.Text = "viewStocks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productViewasStock)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Goback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox filterProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceRetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ContackNoCom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PreOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button addInOrder;
        private System.Windows.Forms.Button UpdateStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PrintO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button updatePrice;
        private System.Windows.Forms.DataGridView productViewasStock;
        private System.Windows.Forms.DataGridView orderListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
    }
}