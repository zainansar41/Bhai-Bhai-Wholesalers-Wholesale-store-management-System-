namespace wholesalers
{
    partial class orderInfoForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderInfoView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shopSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountOrders = new System.Windows.Forms.TextBox();
            this.countDebtOrders = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderDetailsView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPriceOfOrder = new System.Windows.Forms.TextBox();
            this.IDorder = new System.Windows.Forms.TextBox();
            this.ViewOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // Goback
            // 
            this.Goback.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goback.Location = new System.Drawing.Point(12, 12);
            this.Goback.Name = "Goback";
            this.Goback.Size = new System.Drawing.Size(179, 114);
            this.Goback.TabIndex = 0;
            this.Goback.Text = "Go to Dashboard";
            this.Goback.UseVisualStyleBackColor = true;
            this.Goback.Click += new System.EventHandler(this.Goback_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.OrderInfoView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(72, 357);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 618);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // OrderInfoView
            // 
            this.OrderInfoView.AllowUserToAddRows = false;
            this.OrderInfoView.AllowUserToDeleteRows = false;
            this.OrderInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderInfoView.Location = new System.Drawing.Point(3, 3);
            this.OrderInfoView.Name = "OrderInfoView";
            this.OrderInfoView.ReadOnly = true;
            this.OrderInfoView.RowHeadersWidth = 51;
            this.OrderInfoView.RowTemplate.Height = 24;
            this.OrderInfoView.Size = new System.Drawing.Size(880, 615);
            this.OrderInfoView.TabIndex = 0;
            this.OrderInfoView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderInfoView_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(832, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(430, 34);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(989, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search with date";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(956, 183);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(177, 54);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search by Shop Name";
            // 
            // shopSearch
            // 
            this.shopSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopSearch.Location = new System.Drawing.Point(384, 277);
            this.shopSearch.Name = "shopSearch";
            this.shopSearch.Size = new System.Drawing.Size(267, 33);
            this.shopSearch.TabIndex = 8;
            this.shopSearch.TextChanged += new System.EventHandler(this.shopSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1396, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Numbers Of Orders";
            // 
            // CountOrders
            // 
            this.CountOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOrders.Location = new System.Drawing.Point(1677, 71);
            this.CountOrders.Name = "CountOrders";
            this.CountOrders.Size = new System.Drawing.Size(194, 33);
            this.CountOrders.TabIndex = 10;
            // 
            // countDebtOrders
            // 
            this.countDebtOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDebtOrders.Location = new System.Drawing.Point(1677, 137);
            this.countDebtOrders.Name = "countDebtOrders";
            this.countDebtOrders.Size = new System.Drawing.Size(194, 33);
            this.countDebtOrders.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1459, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "No of Debt Orders";
            // 
            // OrderDetailsView
            // 
            this.OrderDetailsView.AllowUserToAddRows = false;
            this.OrderDetailsView.AllowUserToDeleteRows = false;
            this.OrderDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsView.Location = new System.Drawing.Point(1197, 466);
            this.OrderDetailsView.Name = "OrderDetailsView";
            this.OrderDetailsView.ReadOnly = true;
            this.OrderDetailsView.RowHeadersWidth = 51;
            this.OrderDetailsView.RowTemplate.Height = 24;
            this.OrderDetailsView.Size = new System.Drawing.Size(715, 402);
            this.OrderDetailsView.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1211, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Order Details";
            // 
            // totalPriceOfOrder
            // 
            this.totalPriceOfOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceOfOrder.Location = new System.Drawing.Point(1677, 426);
            this.totalPriceOfOrder.Name = "totalPriceOfOrder";
            this.totalPriceOfOrder.Size = new System.Drawing.Size(194, 33);
            this.totalPriceOfOrder.TabIndex = 15;
            // 
            // IDorder
            // 
            this.IDorder.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDorder.Location = new System.Drawing.Point(1513, 310);
            this.IDorder.Name = "IDorder";
            this.IDorder.Size = new System.Drawing.Size(200, 38);
            this.IDorder.TabIndex = 16;
            // 
            // ViewOrder
            // 
            this.ViewOrder.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrder.Location = new System.Drawing.Point(1719, 306);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.Size = new System.Drawing.Size(152, 42);
            this.ViewOrder.TabIndex = 17;
            this.ViewOrder.Text = "View";
            this.ViewOrder.UseVisualStyleBackColor = true;
            this.ViewOrder.Click += new System.EventHandler(this.ViewOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1412, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Order ID";
            // 
            // orderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ViewOrder);
            this.Controls.Add(this.IDorder);
            this.Controls.Add(this.totalPriceOfOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrderDetailsView);
            this.Controls.Add(this.countDebtOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CountOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shopSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Goback);
            this.Name = "orderInfoForm";
            this.Text = "orderInfoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.orderInfoForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Goback;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shopSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountOrders;
        private System.Windows.Forms.TextBox countDebtOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView OrderInfoView;
        private System.Windows.Forms.DataGridView OrderDetailsView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalPriceOfOrder;
        private System.Windows.Forms.TextBox IDorder;
        private System.Windows.Forms.Button ViewOrder;
        private System.Windows.Forms.Label label7;
    }
}