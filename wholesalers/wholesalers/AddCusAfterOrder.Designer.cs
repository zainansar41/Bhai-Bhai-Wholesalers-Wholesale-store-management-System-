namespace wholesalers
{
    partial class AddCusAfterOrder
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
            this.AddCus = new System.Windows.Forms.Button();
            this.AddressBar = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShopName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCus
            // 
            this.AddCus.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCus.Location = new System.Drawing.Point(306, 480);
            this.AddCus.Name = "AddCus";
            this.AddCus.Size = new System.Drawing.Size(267, 66);
            this.AddCus.TabIndex = 26;
            this.AddCus.Text = "Add Customers";
            this.AddCus.UseVisualStyleBackColor = true;
            this.AddCus.Click += new System.EventHandler(this.AddCus_Click);
            // 
            // AddressBar
            // 
            this.AddressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBar.Location = new System.Drawing.Point(259, 285);
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(371, 74);
            this.AddressBar.TabIndex = 25;
            this.AddressBar.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "CNIC No";
            // 
            // CNIC
            // 
            this.CNIC.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC.Location = new System.Drawing.Point(259, 379);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(371, 34);
            this.CNIC.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Contact No";
            // 
            // ContactNo
            // 
            this.ContactNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.Location = new System.Drawing.Point(259, 192);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(371, 34);
            this.ContactNo.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Shop Name";
            // 
            // ShopName
            // 
            this.ShopName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopName.Location = new System.Drawing.Point(259, 114);
            this.ShopName.Name = "ShopName";
            this.ShopName.Size = new System.Drawing.Size(371, 34);
            this.ShopName.TabIndex = 18;
            // 
            // AddCusAfterOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 678);
            this.Controls.Add(this.AddCus);
            this.Controls.Add(this.AddressBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShopName);
            this.Name = "AddCusAfterOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCusAfterOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCus;
        private System.Windows.Forms.RichTextBox AddressBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShopName;
    }
}