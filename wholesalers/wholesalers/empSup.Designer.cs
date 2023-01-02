namespace wholesalers
{
    partial class empSup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchSupp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchEmp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supllierView = new System.Windows.Forms.DataGridView();
            this.updateSupinfo = new System.Windows.Forms.Button();
            this.deleteSup = new System.Windows.Forms.Button();
            this.addSup = new System.Windows.Forms.Button();
            this.addEmp = new System.Windows.Forms.Button();
            this.deleteEmp = new System.Windows.Forms.Button();
            this.updateEmpInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EmployeeView = new System.Windows.Forms.DataGridView();
            this.BackDash = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supllierView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1008, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 709);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suppliers Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1402, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Section";
            // 
            // searchSupp
            // 
            this.searchSupp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSupp.Location = new System.Drawing.Point(314, 143);
            this.searchSupp.Name = "searchSupp";
            this.searchSupp.Size = new System.Drawing.Size(232, 34);
            this.searchSupp.TabIndex = 3;
            this.searchSupp.TextChanged += new System.EventHandler(this.searchSupp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search By Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1447, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search By Name";
            // 
            // searchEmp
            // 
            this.searchEmp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmp.Location = new System.Drawing.Point(1409, 153);
            this.searchEmp.Name = "searchEmp";
            this.searchEmp.Size = new System.Drawing.Size(232, 34);
            this.searchEmp.TabIndex = 5;
            this.searchEmp.TextChanged += new System.EventHandler(this.searchEmp_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.supllierView);
            this.panel2.Location = new System.Drawing.Point(57, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 489);
            this.panel2.TabIndex = 7;
            // 
            // supllierView
            // 
            this.supllierView.AllowUserToAddRows = false;
            this.supllierView.AllowUserToDeleteRows = false;
            this.supllierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supllierView.Location = new System.Drawing.Point(60, 3);
            this.supllierView.Name = "supllierView";
            this.supllierView.ReadOnly = true;
            this.supllierView.RowHeadersWidth = 51;
            this.supllierView.RowTemplate.Height = 24;
            this.supllierView.Size = new System.Drawing.Size(649, 483);
            this.supllierView.TabIndex = 0;
            // 
            // updateSupinfo
            // 
            this.updateSupinfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSupinfo.Location = new System.Drawing.Point(289, 821);
            this.updateSupinfo.Name = "updateSupinfo";
            this.updateSupinfo.Size = new System.Drawing.Size(170, 52);
            this.updateSupinfo.TabIndex = 8;
            this.updateSupinfo.Text = "Change";
            this.updateSupinfo.UseVisualStyleBackColor = true;
            this.updateSupinfo.Click += new System.EventHandler(this.updateSupinfo_Click);
            // 
            // deleteSup
            // 
            this.deleteSup.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSup.Location = new System.Drawing.Point(289, 879);
            this.deleteSup.Name = "deleteSup";
            this.deleteSup.Size = new System.Drawing.Size(170, 52);
            this.deleteSup.TabIndex = 9;
            this.deleteSup.Text = "Delete";
            this.deleteSup.UseVisualStyleBackColor = true;
            this.deleteSup.Click += new System.EventHandler(this.deleteSup_Click);
            // 
            // addSup
            // 
            this.addSup.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSup.Location = new System.Drawing.Point(465, 820);
            this.addSup.Name = "addSup";
            this.addSup.Size = new System.Drawing.Size(68, 110);
            this.addSup.TabIndex = 10;
            this.addSup.Text = "Add";
            this.addSup.UseVisualStyleBackColor = true;
            this.addSup.Click += new System.EventHandler(this.addSup_Click);
            // 
            // addEmp
            // 
            this.addEmp.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.Location = new System.Drawing.Point(1397, 820);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(68, 110);
            this.addEmp.TabIndex = 13;
            this.addEmp.Text = "Add";
            this.addEmp.UseVisualStyleBackColor = true;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // deleteEmp
            // 
            this.deleteEmp.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmp.Location = new System.Drawing.Point(1471, 878);
            this.deleteEmp.Name = "deleteEmp";
            this.deleteEmp.Size = new System.Drawing.Size(170, 52);
            this.deleteEmp.TabIndex = 12;
            this.deleteEmp.Text = "Delete";
            this.deleteEmp.UseVisualStyleBackColor = true;
            this.deleteEmp.Click += new System.EventHandler(this.deleteEmp_Click);
            // 
            // updateEmpInfo
            // 
            this.updateEmpInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmpInfo.Location = new System.Drawing.Point(1471, 820);
            this.updateEmpInfo.Name = "updateEmpInfo";
            this.updateEmpInfo.Size = new System.Drawing.Size(170, 52);
            this.updateEmpInfo.TabIndex = 11;
            this.updateEmpInfo.Text = "Change";
            this.updateEmpInfo.UseVisualStyleBackColor = true;
            this.updateEmpInfo.Click += new System.EventHandler(this.updateEmpInfo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EmployeeView);
            this.panel3.Location = new System.Drawing.Point(1093, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 489);
            this.panel3.TabIndex = 8;
            // 
            // EmployeeView
            // 
            this.EmployeeView.AllowUserToAddRows = false;
            this.EmployeeView.AllowUserToDeleteRows = false;
            this.EmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeView.Location = new System.Drawing.Point(3, 3);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.ReadOnly = true;
            this.EmployeeView.RowHeadersWidth = 51;
            this.EmployeeView.RowTemplate.Height = 24;
            this.EmployeeView.Size = new System.Drawing.Size(766, 483);
            this.EmployeeView.TabIndex = 1;
            // 
            // BackDash
            // 
            this.BackDash.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackDash.Location = new System.Drawing.Point(2, 13);
            this.BackDash.Name = "BackDash";
            this.BackDash.Size = new System.Drawing.Size(178, 127);
            this.BackDash.TabIndex = 14;
            this.BackDash.Text = "Go to Dashboard";
            this.BackDash.UseVisualStyleBackColor = true;
            this.BackDash.Click += new System.EventHandler(this.BackDash_Click);
            // 
            // empSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.BackDash);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.addEmp);
            this.Controls.Add(this.deleteEmp);
            this.Controls.Add(this.updateEmpInfo);
            this.Controls.Add(this.addSup);
            this.Controls.Add(this.deleteSup);
            this.Controls.Add(this.updateSupinfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchSupp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "empSup";
            this.Text = "empSup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supllierView)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchSupp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchEmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updateSupinfo;
        private System.Windows.Forms.Button deleteSup;
        private System.Windows.Forms.Button addSup;
        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.Button deleteEmp;
        private System.Windows.Forms.Button updateEmpInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BackDash;
        private System.Windows.Forms.DataGridView supllierView;
        private System.Windows.Forms.DataGridView EmployeeView;
    }
}