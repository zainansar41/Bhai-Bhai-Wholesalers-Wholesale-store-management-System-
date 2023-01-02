namespace wholesalers
{
    partial class addSupplierform
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
            this.Address = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactSup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSup = new System.Windows.Forms.Button();
            this.companyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(348, 179);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(272, 124);
            this.Address.TabIndex = 13;
            this.Address.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // ContactSup
            // 
            this.ContactSup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactSup.Location = new System.Drawing.Point(348, 112);
            this.ContactSup.Name = "ContactSup";
            this.ContactSup.Size = new System.Drawing.Size(272, 33);
            this.ContactSup.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contact No";
            // 
            // AddSup
            // 
            this.AddSup.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSup.Location = new System.Drawing.Point(348, 334);
            this.AddSup.Name = "AddSup";
            this.AddSup.Size = new System.Drawing.Size(159, 73);
            this.AddSup.TabIndex = 9;
            this.AddSup.Text = "ADD";
            this.AddSup.UseVisualStyleBackColor = true;
            this.AddSup.Click += new System.EventHandler(this.AddSup_Click);
            // 
            // companyName
            // 
            this.companyName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(348, 53);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(272, 33);
            this.companyName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Company Name";
            // 
            // addSupplierform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContactSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddSup);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.label1);
            this.Name = "addSupplierform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addSupplierform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContactSup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddSup;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.Label label1;
    }
}