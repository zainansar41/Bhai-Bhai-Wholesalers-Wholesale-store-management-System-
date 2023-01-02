using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wholesalers
{  
    public partial class orderInfoForm : Form
    {
        public int OID;
        public orderInfoForm()
        {
            InitializeComponent();
            initializeOrderInfoTBL();
            CountOrders.Text = (OrderInfoView.RowCount).ToString();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void Goback_Click(object sender, EventArgs e)
        {
            dashboard ds= new dashboard();
            ds.Show();
            this.Close();
        }
        private void initializeOrderInfoTBL()
        {
            try
            {
                String Query = "select * from OrderInfoTbl";
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                OrderInfoView.DataSource = dt;
                conn.Close();
                countDebt();
            }
            catch(Exception ex) 
            {
                    MessageBox.Show(ex.Message);
            }
        }

        private void OrderInfoView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                OID = int.Parse(OrderInfoView.CurrentRow.Cells[0].Value.ToString());
                initializeOrderDetailsInfo();
                totalPrice();


            }
        }
        private void initializeOrderDetailsInfo()
        {
            try
            {
                conn.Open();
                String Query = "select product_name,unitPrice,retailPrice,quantity,Total_Price from OrderDetailsView where Order_id = " + OID ;
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                OrderDetailsView.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message); 
            }
        }
        private void totalPrice()
        {
            float sum = 0;
            for(int i= 0; i< OrderDetailsView.RowCount; i++)
            {
                sum += float.Parse(OrderDetailsView.Rows[i].Cells[4].Value.ToString());
            }
            totalPriceOfOrder.Text = sum.ToString();
        }

        private void shopSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = shopSearch.Text + "%";
            string sqlQuery = "select * from OrderInfoTbl where [Shop_name] like '" + q + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderInfoView.DataSource = dt;
            conn.Close();
            CountOrders.Text = OrderInfoView.RowCount.ToString();
            countDebt();
        }

        private void ViewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int Q = int.Parse(IDorder.Text.ToString());
                conn.Open();
                string query = "select product_name,retailPrice,unitPrice,quantity,Total_Price from OrderDetailsView where Order_id = "+Q;
                SqlDataAdapter cd = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                cd.Fill(dt);
                OrderDetailsView.DataSource = dt;
                conn.Close();
                totalPrice();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void countDebt()
        {
            int checkedCount = 0;
            foreach (DataGridViewRow row in OrderInfoView.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[5].Value);
                if (isChecked)
                {
                    checkedCount++;
                }
            }
            countDebtOrders.Text = checkedCount.ToString();
        }

        private void orderInfoFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void orderInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            String Query = "select * from OrderInfoTbl where OrderDate = '"+ dateTimePicker1.Value.ToString("d")+ "'";
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                OrderInfoView.DataSource = dt;
                conn.Close();
                CountOrders.Text = (OrderInfoView.RowCount).ToString();
                countDebt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
