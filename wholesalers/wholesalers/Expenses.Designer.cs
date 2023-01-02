namespace wholesalers
{
    partial class Expenses
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
            this.ExpenseName = new System.Windows.Forms.ComboBox();
            this.PAY = new System.Windows.Forms.Button();
            this.AddExpense = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.AmountExpens = new System.Windows.Forms.TextBox();
            this.CashierIDcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenseView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseName
            // 
            this.ExpenseName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseName.FormattingEnabled = true;
            this.ExpenseName.Items.AddRange(new object[] {
            "No Expense",
            "Salaries",
            "Electricity Bill",
            "Lunch/Dinner",
            "Other Bills",
            "Other Expenses"});
            this.ExpenseName.Location = new System.Drawing.Point(239, 255);
            this.ExpenseName.Name = "ExpenseName";
            this.ExpenseName.Size = new System.Drawing.Size(244, 38);
            this.ExpenseName.TabIndex = 0;
            this.ExpenseName.SelectedIndexChanged += new System.EventHandler(this.ExpenseName_SelectedIndexChanged);
            // 
            // PAY
            // 
            this.PAY.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAY.Location = new System.Drawing.Point(484, 349);
            this.PAY.Name = "PAY";
            this.PAY.Size = new System.Drawing.Size(141, 37);
            this.PAY.TabIndex = 1;
            this.PAY.Text = "Pay salaries";
            this.PAY.UseVisualStyleBackColor = true;
            this.PAY.Visible = false;
            this.PAY.Click += new System.EventHandler(this.PAY_Click);
            // 
            // AddExpense
            // 
            this.AddExpense.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpense.Location = new System.Drawing.Point(217, 533);
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Size = new System.Drawing.Size(177, 51);
            this.AddExpense.TabIndex = 2;
            this.AddExpense.Text = "Add Expense";
            this.AddExpense.UseVisualStyleBackColor = true;
            this.AddExpense.Click += new System.EventHandler(this.AddExpense_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(1085, 20);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(79, 30);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "label1";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(400, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AmountExpens
            // 
            this.AmountExpens.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountExpens.Location = new System.Drawing.Point(267, 349);
            this.AmountExpens.Name = "AmountExpens";
            this.AmountExpens.Size = new System.Drawing.Size(186, 37);
            this.AmountExpens.TabIndex = 5;
            // 
            // CashierIDcombo
            // 
            this.CashierIDcombo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierIDcombo.FormattingEnabled = true;
            this.CashierIDcombo.Location = new System.Drawing.Point(307, 436);
            this.CashierIDcombo.Name = "CashierIDcombo";
            this.CashierIDcombo.Size = new System.Drawing.Size(112, 38);
            this.CashierIDcombo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cashiers ID";
            // 
            // ExpenseView
            // 
            this.ExpenseView.AllowUserToAddRows = false;
            this.ExpenseView.AllowUserToDeleteRows = false;
            this.ExpenseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenseView.Location = new System.Drawing.Point(704, 167);
            this.ExpenseView.Name = "ExpenseView";
            this.ExpenseView.ReadOnly = true;
            this.ExpenseView.RowHeadersWidth = 51;
            this.ExpenseView.RowTemplate.Height = 24;
            this.ExpenseView.Size = new System.Drawing.Size(675, 589);
            this.ExpenseView.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expense Info";
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 798);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpenseView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CashierIDcombo);
            this.Controls.Add(this.AmountExpens);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddExpense);
            this.Controls.Add(this.PAY);
            this.Controls.Add(this.ExpenseName);
            this.Name = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ExpenseName;
        private System.Windows.Forms.Button PAY;
        private System.Windows.Forms.Button AddExpense;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox AmountExpens;
        private System.Windows.Forms.ComboBox CashierIDcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ExpenseView;
        private System.Windows.Forms.Label label3;
    }
}