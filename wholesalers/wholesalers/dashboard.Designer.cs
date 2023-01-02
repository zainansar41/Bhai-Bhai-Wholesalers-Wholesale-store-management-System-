namespace wholesalers
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewEmployee = new System.Windows.Forms.Button();
            this.viewCostomer = new System.Windows.Forms.Button();
            this.orderscom = new System.Windows.Forms.Button();
            this.debt = new System.Windows.Forms.Button();
            this.updateStock = new System.Windows.Forms.Button();
            this.sellPoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MProfit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ViewStockDash = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gostocks = new System.Windows.Forms.Button();
            this.updateall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.salesOfMonth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DebtDash = new System.Windows.Forms.DataGridView();
            this.goTodebtPage = new System.Windows.Forms.Button();
            this.ChartWeekSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prevDate = new System.Windows.Forms.DateTimePicker();
            this.CurrentDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStockDash)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DebtDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartWeekSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(289, 262);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewEmployee);
            this.panel1.Controls.Add(this.viewCostomer);
            this.panel1.Controls.Add(this.orderscom);
            this.panel1.Controls.Add(this.debt);
            this.panel1.Controls.Add(this.updateStock);
            this.panel1.Controls.Add(this.sellPoint);
            this.panel1.Location = new System.Drawing.Point(2, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 751);
            this.panel1.TabIndex = 15;
            // 
            // viewEmployee
            // 
            this.viewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmployee.Location = new System.Drawing.Point(41, 596);
            this.viewEmployee.Name = "viewEmployee";
            this.viewEmployee.Size = new System.Drawing.Size(190, 77);
            this.viewEmployee.TabIndex = 21;
            this.viewEmployee.Text = "Employees     /Suppliers";
            this.viewEmployee.UseVisualStyleBackColor = true;
            this.viewEmployee.Click += new System.EventHandler(this.viewEmployee_Click);
            // 
            // viewCostomer
            // 
            this.viewCostomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCostomer.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCostomer.Location = new System.Drawing.Point(41, 470);
            this.viewCostomer.Name = "viewCostomer";
            this.viewCostomer.Size = new System.Drawing.Size(190, 77);
            this.viewCostomer.TabIndex = 20;
            this.viewCostomer.Text = "Customers";
            this.viewCostomer.UseVisualStyleBackColor = true;
            this.viewCostomer.Click += new System.EventHandler(this.viewCostomer_Click);
            // 
            // orderscom
            // 
            this.orderscom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderscom.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderscom.Location = new System.Drawing.Point(41, 358);
            this.orderscom.Name = "orderscom";
            this.orderscom.Size = new System.Drawing.Size(190, 77);
            this.orderscom.TabIndex = 19;
            this.orderscom.Text = "Orders Info";
            this.orderscom.UseVisualStyleBackColor = true;
            this.orderscom.Click += new System.EventHandler(this.orderscom_Click);
            // 
            // debt
            // 
            this.debt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.debt.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debt.Location = new System.Drawing.Point(41, 246);
            this.debt.Name = "debt";
            this.debt.Size = new System.Drawing.Size(190, 77);
            this.debt.TabIndex = 18;
            this.debt.Text = "Debt";
            this.debt.UseVisualStyleBackColor = true;
            this.debt.Click += new System.EventHandler(this.debt_Click);
            // 
            // updateStock
            // 
            this.updateStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateStock.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStock.Location = new System.Drawing.Point(41, 134);
            this.updateStock.Name = "updateStock";
            this.updateStock.Size = new System.Drawing.Size(190, 77);
            this.updateStock.TabIndex = 17;
            this.updateStock.Text = "View Stocks";
            this.updateStock.UseVisualStyleBackColor = true;
            this.updateStock.Click += new System.EventHandler(this.updateStock_Click);
            // 
            // sellPoint
            // 
            this.sellPoint.BackColor = System.Drawing.Color.Transparent;
            this.sellPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellPoint.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPoint.Location = new System.Drawing.Point(41, 25);
            this.sellPoint.Name = "sellPoint";
            this.sellPoint.Size = new System.Drawing.Size(190, 77);
            this.sellPoint.TabIndex = 16;
            this.sellPoint.Text = "Sell Point";
            this.sellPoint.UseVisualStyleBackColor = false;
            this.sellPoint.Click += new System.EventHandler(this.sellPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(804, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome to Abdul Aleem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(814, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 5);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.MProfit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(713, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 186);
            this.panel3.TabIndex = 18;
            // 
            // MProfit
            // 
            this.MProfit.AutoSize = true;
            this.MProfit.BackColor = System.Drawing.Color.SkyBlue;
            this.MProfit.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MProfit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MProfit.Location = new System.Drawing.Point(71, 104);
            this.MProfit.MinimumSize = new System.Drawing.Size(70, 31);
            this.MProfit.Name = "MProfit";
            this.MProfit.Size = new System.Drawing.Size(70, 31);
            this.MProfit.TabIndex = 1;
            this.MProfit.Text = "4532";
            this.MProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(82, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Profit";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ViewStockDash);
            this.panel4.Location = new System.Drawing.Point(1500, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 469);
            this.panel4.TabIndex = 19;
            // 
            // ViewStockDash
            // 
            this.ViewStockDash.AllowUserToAddRows = false;
            this.ViewStockDash.AllowUserToDeleteRows = false;
            this.ViewStockDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewStockDash.Location = new System.Drawing.Point(0, 0);
            this.ViewStockDash.Name = "ViewStockDash";
            this.ViewStockDash.ReadOnly = true;
            this.ViewStockDash.RowHeadersWidth = 51;
            this.ViewStockDash.RowTemplate.Height = 24;
            this.ViewStockDash.Size = new System.Drawing.Size(409, 469);
            this.ViewStockDash.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gostocks);
            this.panel5.Controls.Add(this.updateall);
            this.panel5.Location = new System.Drawing.Point(1503, 648);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(409, 91);
            this.panel5.TabIndex = 0;
            // 
            // gostocks
            // 
            this.gostocks.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gostocks.Location = new System.Drawing.Point(226, 25);
            this.gostocks.Name = "gostocks";
            this.gostocks.Size = new System.Drawing.Size(149, 43);
            this.gostocks.TabIndex = 1;
            this.gostocks.Text = "Go to Stocks";
            this.gostocks.UseVisualStyleBackColor = true;
            this.gostocks.Click += new System.EventHandler(this.gostocks_Click);
            // 
            // updateall
            // 
            this.updateall.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateall.Location = new System.Drawing.Point(36, 25);
            this.updateall.Name = "updateall";
            this.updateall.Size = new System.Drawing.Size(149, 43);
            this.updateall.TabIndex = 0;
            this.updateall.Text = "Update All";
            this.updateall.UseVisualStyleBackColor = true;
            this.updateall.Click += new System.EventHandler(this.updateall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(1641, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stocks Info";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.Controls.Add(this.salesOfMonth);
            this.panel6.Controls.Add(this.label5);
            this.panel6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Location = new System.Drawing.Point(358, 136);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 186);
            this.panel6.TabIndex = 19;
            // 
            // salesOfMonth
            // 
            this.salesOfMonth.AutoSize = true;
            this.salesOfMonth.BackColor = System.Drawing.Color.SkyBlue;
            this.salesOfMonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesOfMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesOfMonth.Location = new System.Drawing.Point(65, 104);
            this.salesOfMonth.MinimumSize = new System.Drawing.Size(70, 31);
            this.salesOfMonth.Name = "salesOfMonth";
            this.salesOfMonth.Size = new System.Drawing.Size(70, 31);
            this.salesOfMonth.TabIndex = 1;
            this.salesOfMonth.Text = "4532";
            this.salesOfMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(78, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sales";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DebtDash);
            this.panel7.Controls.Add(this.goTodebtPage);
            this.panel7.Location = new System.Drawing.Point(581, 758);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1021, 240);
            this.panel7.TabIndex = 23;
            // 
            // DebtDash
            // 
            this.DebtDash.AllowUserToAddRows = false;
            this.DebtDash.AllowUserToDeleteRows = false;
            this.DebtDash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebtDash.Location = new System.Drawing.Point(54, 0);
            this.DebtDash.Name = "DebtDash";
            this.DebtDash.ReadOnly = true;
            this.DebtDash.RowHeadersWidth = 51;
            this.DebtDash.RowTemplate.Height = 24;
            this.DebtDash.Size = new System.Drawing.Size(831, 246);
            this.DebtDash.TabIndex = 0;
            // 
            // goTodebtPage
            // 
            this.goTodebtPage.Font = new System.Drawing.Font("Microsoft YaHei Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goTodebtPage.Location = new System.Drawing.Point(903, 3);
            this.goTodebtPage.Name = "goTodebtPage";
            this.goTodebtPage.Size = new System.Drawing.Size(103, 228);
            this.goTodebtPage.TabIndex = 24;
            this.goTodebtPage.Text = "Go To debt Page";
            this.goTodebtPage.UseVisualStyleBackColor = true;
            this.goTodebtPage.Click += new System.EventHandler(this.goTodebtPage_Click);
            // 
            // ChartWeekSales
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartWeekSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartWeekSales.Legends.Add(legend1);
            this.ChartWeekSales.Location = new System.Drawing.Point(338, 350);
            this.ChartWeekSales.Name = "ChartWeekSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.ChartWeekSales.Series.Add(series1);
            this.ChartWeekSales.Size = new System.Drawing.Size(1145, 343);
            this.ChartWeekSales.TabIndex = 28;
            this.ChartWeekSales.Text = "ChartSales";
            // 
            // prevDate
            // 
            this.prevDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevDate.Location = new System.Drawing.Point(1153, 157);
            this.prevDate.Name = "prevDate";
            this.prevDate.Size = new System.Drawing.Size(253, 22);
            this.prevDate.TabIndex = 29;
            this.prevDate.ValueChanged += new System.EventHandler(this.prevDate_ValueChanged);
            // 
            // CurrentDate
            // 
            this.CurrentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(1153, 228);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(253, 22);
            this.CurrentDate.TabIndex = 30;
            this.CurrentDate.ValueChanged += new System.EventHandler(this.CurrentDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1085, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1085, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "To:";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.prevDate);
            this.Controls.Add(this.ChartWeekSales);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "dashboard";
            this.Text = "                 ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewStockDash)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DebtDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartWeekSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewEmployee;
        private System.Windows.Forms.Button viewCostomer;
        private System.Windows.Forms.Button orderscom;
        private System.Windows.Forms.Button debt;
        private System.Windows.Forms.Button updateStock;
        private System.Windows.Forms.Button sellPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label MProfit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button gostocks;
        private System.Windows.Forms.Button updateall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label salesOfMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button goTodebtPage;
        private System.Windows.Forms.DataGridView ViewStockDash;
        private System.Windows.Forms.DataGridView DebtDash;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartWeekSales;
        private System.Windows.Forms.DateTimePicker prevDate;
        private System.Windows.Forms.DateTimePicker CurrentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}