namespace wholesalers
{
    partial class updateSupinfo
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
            this.UpdateSup = new System.Windows.Forms.Button();
            this.companyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(336, 197);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(272, 124);
            this.Address.TabIndex = 20;
            this.Address.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address";
            // 
            // ContactSup
            // 
            this.ContactSup.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactSup.Location = new System.Drawing.Point(336, 130);
            this.ContactSup.Name = "ContactSup";
            this.ContactSup.Size = new System.Drawing.Size(272, 33);
            this.ContactSup.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contact No";
            // 
            // UpdateSup
            // 
            this.UpdateSup.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSup.Location = new System.Drawing.Point(336, 352);
            this.UpdateSup.Name = "UpdateSup";
            this.UpdateSup.Size = new System.Drawing.Size(159, 73);
            this.UpdateSup.TabIndex = 16;
            this.UpdateSup.Text = "UPDATE";
            this.UpdateSup.UseVisualStyleBackColor = true;
            this.UpdateSup.Click += new System.EventHandler(this.UpdateSup_Click);
            // 
            // companyName
            // 
            this.companyName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(336, 71);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(272, 33);
            this.companyName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Company Name";
            // 
            // updateSupinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContactSup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateSup);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.label1);
            this.Name = "updateSupinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateSupinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox Address;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ContactSup;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button UpdateSup;
        public System.Windows.Forms.TextBox companyName;
        public System.Windows.Forms.Label label1;
    }
}