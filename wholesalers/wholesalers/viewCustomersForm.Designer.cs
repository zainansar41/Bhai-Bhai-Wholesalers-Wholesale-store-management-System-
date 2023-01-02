namespace wholesalers
{
    partial class viewCustomersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.filters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomerView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ShopName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CNIC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressBar = new System.Windows.Forms.RichTextBox();
            this.AddCus = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMERS INFORMATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(875, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 5);
            this.panel1.TabIndex = 1;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(1232, 186);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(397, 34);
            this.searchbox.TabIndex = 2;
            this.searchbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1264, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Customer by Contact No";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(1648, 181);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(102, 45);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // filters
            // 
            this.filters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filters.FormattingEnabled = true;
            this.filters.Items.AddRange(new object[] {
            "All",
            "Search By Most Orders",
            "Search By Most Debt Orders",
            "Search By Least Number of Orders",
            "Search By least Debt Order"});
            this.filters.Location = new System.Drawing.Point(1436, 312);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(286, 28);
            this.filters.TabIndex = 5;
            this.filters.SelectedIndexChanged += new System.EventHandler(this.filters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1336, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filters:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CustomerView);
            this.panel2.Location = new System.Drawing.Point(58, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 737);
            this.panel2.TabIndex = 7;
            // 
            // CustomerView
            // 
            this.CustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerView.Location = new System.Drawing.Point(152, 0);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.RowHeadersWidth = 51;
            this.CustomerView.RowTemplate.Height = 24;
            this.CustomerView.Size = new System.Drawing.Size(727, 734);
            this.CustomerView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(875, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(1154, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 3);
            this.panel4.TabIndex = 8;
            // 
            // ShopName
            // 
            this.ShopName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopName.Location = new System.Drawing.Point(1436, 456);
            this.ShopName.Name = "ShopName";
            this.ShopName.Size = new System.Drawing.Size(371, 34);
            this.ShopName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1300, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Shop Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1305, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact No";
            // 
            // ContactNo
            // 
            this.ContactNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.Location = new System.Drawing.Point(1436, 534);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(371, 34);
            this.ContactNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1314, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "CNIC No";
            // 
            // CNIC
            // 
            this.CNIC.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC.Location = new System.Drawing.Point(1436, 721);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(371, 34);
            this.CNIC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1314, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address";
            // 
            // AddressBar
            // 
            this.AddressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBar.Location = new System.Drawing.Point(1436, 627);
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(371, 74);
            this.AddressBar.TabIndex = 16;
            this.AddressBar.Text = "";
            // 
            // AddCus
            // 
            this.AddCus.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCus.Location = new System.Drawing.Point(1436, 819);
            this.AddCus.Name = "AddCus";
            this.AddCus.Size = new System.Drawing.Size(267, 66);
            this.AddCus.TabIndex = 17;
            this.AddCus.Text = "Add Customers";
            this.AddCus.UseVisualStyleBackColor = true;
            this.AddCus.Click += new System.EventHandler(this.AddCus_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(58, 31);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(166, 105);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Go to Dashboard";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1727, 819);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(125, 66);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Visible = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // viewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.AddCus);
            this.Controls.Add(this.AddressBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShopName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filters);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "viewCustomersForm";
            this.Text = "viewCustomersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox filters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ShopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CNIC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox AddressBar;
        private System.Windows.Forms.Button AddCus;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView CustomerView;
        private System.Windows.Forms.Button Clear;
    }
}