using System;
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
    public partial class SellPoint : Form
    {
        public SellPoint()
        {
            InitializeComponent();
            conn.Open();
            String Query = "select * from ShowProcductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ProductView.DataSource = dt;
            conn.Close();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        private void placeorder_Click(object sender, EventArgs e)
        {
            if (OrderView.Rows.Count > 0)
            {
                AfterPlaceOrder aps = new AfterPlaceOrder();
                DataGridView targetGridView = aps.dataGridView1;

                foreach (DataGridViewRow row in OrderView.Rows)
                {
                    string productName = row.Cells[0].Value.ToString();
                    int quantity = (int)row.Cells[1].Value;
                    float totalPrice = (float)row.Cells[2].Value;
                    int productId = (int)row.Cells[3].Value;

                    targetGridView.Rows.Add(new object[] { productName, quantity, totalPrice, productId });
                }
                aps.totalPriceOrder = Int32.Parse(OrderTotalPrice.Text);
                aps.Show();
            }
            else
            {
                MessageBox.Show("please place Something as An Order");
            }
        }

        private void DebtBtn_Click(object sender, EventArgs e)
        {
            DebtForm df = new DebtForm();
            df.Show();
            this.Close();
        }

        private void ADDinOrder_Click(object sender, EventArgs e)
        {
            if(ProductView.SelectedRows.Count == 1)
            {
                String name = ProductView.CurrentRow.Cells[1].Value.ToString();
                float price = float.Parse(ProductView.CurrentRow.Cells[2].Value.ToString());
                int quantity = int.Parse(ProcQuantity.Text.ToString());
                int stocks = int.Parse(ProductView.CurrentRow.Cells[3].Value.ToString());
                int PID = int.Parse(ProductView.CurrentRow.Cells[0].Value.ToString());
                float result = price * quantity;
                if(quantity > 0 && quantity < stocks)
                {
                    OrderView.Rows.Add(name, quantity, result,PID);
                }
                else
                {
                    MessageBox.Show("Please enter valid quantity");
                }

            }
            else
            {
                MessageBox.Show("please select any Product");
            }
            float sum=0;
            foreach (DataGridViewRow row in OrderView.Rows)
            {
                float price = (float)row.Cells[2].Value;
                sum = price + sum;
            }
            OrderTotalPrice.Text = sum.ToString();
        }

        private void SeacrhProc_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = SeacrhProc.Text + "%";
            string sqlQuery = "select * from products where [product_name] like '" + q + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ProductView.DataSource = dt;
            conn.Close();
        }

        private void ProcQuantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void ProductView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // Select the previous row
                if (ProductView.CurrentCell.RowIndex > 0)
                {
                    ProductView.CurrentCell = ProductView[0, ProductView.CurrentCell.RowIndex - 1];
                    ProductView.CurrentCell = ProductView.Rows[ProductView.CurrentCell.RowIndex].Cells[ProductView.CurrentCell.ColumnIndex];
                    ProductView.CurrentCell.Selected = true;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                // Select the next row
                if (ProductView.CurrentCell.RowIndex < ProductView.Rows.Count - 1) { 
                    ProductView.CurrentCell = ProductView[0, ProductView.CurrentCell.RowIndex + 1];
                    ProductView.CurrentCell = ProductView.Rows[ProductView.CurrentCell.RowIndex].Cells[ProductView.CurrentCell.ColumnIndex];
                     ProductView.CurrentCell.Selected = true;
                }
            }
        }

        private void OrderView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (OrderView.SelectedRows.Count > 0)
                {
                    OrderView.Rows.Remove(OrderView.SelectedRows[0]);
                    UpdateTotal();
                }
            }
        }
        private void UpdateTotal()
        {
            float sum = 0;
            foreach (DataGridViewRow row in OrderView.Rows)
            {
                float price = (float)row.Cells[2].Value;
                sum = price + sum;
            }
            OrderTotalPrice.Text = sum.ToString();
        }

        private void Expensebtn_Click(object sender, EventArgs e)
        {
            Expenses ex = new Expenses();
            ex.Show();
        }

        private void ProcQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ADDinOrder_Click(sender, e);
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
    }
}
