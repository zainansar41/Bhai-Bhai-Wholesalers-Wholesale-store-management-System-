namespace wholesalers
{
    partial class DebtForm
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
            this.SellPointBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DebtView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDorder = new System.Windows.Forms.TextBox();
            this.DateOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameShop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Due = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Paid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Something = new System.Windows.Forms.Button();
            this.AllPayButton = new System.Windows.Forms.Button();
            this.totalDebt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebtView)).BeginInit();
            this.SuspendLayout();
            // 
            // SellPointBtn
            // 
            this.SellPointBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPointBtn.Location = new System.Drawing.Point(12, 28);
            this.SellPointBtn.Name = "SellPointBtn";
            this.SellPointBtn.Size = new System.Drawing.Size(133, 85);
            this.SellPointBtn.TabIndex = 0;
            this.SellPointBtn.Text = "Sell Point";
            this.SellPointBtn.UseVisualStyleBackColor = true;
            this.SellPointBtn.Click += new System.EventHandler(this.SellPointBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DebtView);
            this.panel1.Location = new System.Drawing.Point(1231, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 779);
            this.panel1.TabIndex = 1;
            // 
            // DebtView
            // 
            this.DebtView.AllowUserToAddRows = false;
            this.DebtView.AllowUserToDeleteRows = false;
            this.DebtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebtView.Location = new System.Drawing.Point(0, 3);
            this.DebtView.Name = "DebtView";
            this.DebtView.ReadOnly = true;
            this.DebtView.RowHeadersWidth = 51;
            this.DebtView.RowTemplate.Height = 24;
            this.DebtView.Size = new System.Drawing.Size(664, 773);
            this.DebtView.TabIndex = 0;
            this.DebtView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DebtView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1498, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Debt Table";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(893, 294);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(289, 37);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(931, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search by Customer No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Debt Order Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order ID ";
            // 
            // IDorder
            // 
            this.IDorder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDorder.Location = new System.Drawing.Point(281, 533);
            this.IDorder.Name = "IDorder";
            this.IDorder.Size = new System.Drawing.Size(276, 33);
            this.IDorder.TabIndex = 9;
            // 
            // DateOrder
            // 
            this.DateOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOrder.Location = new System.Drawing.Point(804, 530);
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.Size = new System.Drawing.Size(260, 33);
            this.DateOrder.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(672, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Order Date";
            // 
            // NameShop
            // 
            this.NameShop.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameShop.Location = new System.Drawing.Point(281, 604);
            this.NameShop.Name = "NameShop";
            this.NameShop.Size = new System.Drawing.Size(276, 33);
            this.NameShop.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Shop Name";
            // 
            // ContactNo
            // 
            this.ContactNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.Location = new System.Drawing.Point(804, 604);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(260, 33);
            this.ContactNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 607);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "ContactNo";
            // 
            // Due
            // 
            this.Due.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Due.Location = new System.Drawing.Point(281, 677);
            this.Due.Name = "Due";
            this.Due.Size = new System.Drawing.Size(276, 33);
            this.Due.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 680);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "Due";
            // 
            // Paid
            // 
            this.Paid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paid.Location = new System.Drawing.Point(804, 677);
            this.Paid.Name = "Paid";
            this.Paid.Size = new System.Drawing.Size(260, 33);
            this.Paid.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(706, 683);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Paid";
            // 
            // Something
            // 
            this.Something.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Something.Location = new System.Drawing.Point(464, 837);
            this.Something.Name = "Something";
            this.Something.Size = new System.Drawing.Size(468, 65);
            this.Something.TabIndex = 20;
            this.Something.Text = "want to pay anything";
            this.Something.UseVisualStyleBackColor = true;
            this.Something.Click += new System.EventHandler(this.Something_Click);
            // 
            // AllPayButton
            // 
            this.AllPayButton.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPayButton.Location = new System.Drawing.Point(951, 837);
            this.AllPayButton.Name = "AllPayButton";
            this.AllPayButton.Size = new System.Drawing.Size(113, 65);
            this.AllPayButton.TabIndex = 21;
            this.AllPayButton.Text = "Paid";
            this.AllPayButton.UseVisualStyleBackColor = true;
            this.AllPayButton.Click += new System.EventHandler(this.AllPayButton_Click);
            // 
            // totalDebt
            // 
            this.totalDebt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDebt.Location = new System.Drawing.Point(1533, 54);
            this.totalDebt.Name = "totalDebt";
            this.totalDebt.Size = new System.Drawing.Size(237, 33);
            this.totalDebt.TabIndex = 23;
            this.totalDebt.TextChanged += new System.EventHandler(this.totalDebt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1401, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 27);
            this.label11.TabIndex = 22;
            this.label11.Text = "Total Debt";
            // 
            // DebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.totalDebt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AllPayButton);
            this.Controls.Add(this.Something);
            this.Controls.Add(this.Paid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Due);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameShop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IDorder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SellPointBtn);
            this.Name = "DebtForm";
            this.Text = "DebtForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DebtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SellPointBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDorder;
        private System.Windows.Forms.TextBox DateOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameShop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Due;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Paid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Something;
        private System.Windows.Forms.Button AllPayButton;
        private System.Windows.Forms.TextBox totalDebt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DebtView;
    }
}