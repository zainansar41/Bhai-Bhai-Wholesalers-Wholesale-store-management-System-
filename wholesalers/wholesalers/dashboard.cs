using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace wholesalers
{
    public partial class dashboard : Form
    {
        float salaries;
        public dashboard()
        {
            InitializeComponent();
            DisplayDashStock();
            DisplayDebt();
            FillChart();
            prevDate.Value = DateTime.Now.AddMonths(-1);
            monthlySales();
            monthlyProfit();
            findExpense();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void viewCostomer_Click(object sender, EventArgs e)
        {
            
            viewCustomersForm Cs = new viewCustomersForm();
            Cs.Show();
            this.Hide();
        }

        private void viewEmployee_Click(object sender, EventArgs e)
        {
            empSup s = new empSup();
            s.Show();
            this.Hide();
        }

        private void sellPoint_Click(object sender, EventArgs e)
        {
            SellPoint sp=new SellPoint();
            sp.Show();
            this.Hide();
        }

        private void debt_Click(object sender, EventArgs e)
        {
            DebtForm df = new DebtForm();
            df.Show();
            this.Hide();
        }

        private void orderscom_Click(object sender, EventArgs e)
        {
            orderInfoForm orderF= new orderInfoForm();
            orderF.Show();
            this.Close();
        }

        private void updateStock_Click(object sender, EventArgs e)
        {
            viewStocks vs = new viewStocks();
            vs.Show();
            this.Close();
        }

        private void goTodebtPage_Click(object sender, EventArgs e)
        {
            DebtForm df = new DebtForm();
            df.Show();
            this.Close();
        }
        private void monthlySales()
        {
            try
            {
                String Query = "SELECT SUM(Total_Bill) AS total FROM orders WHERE OrderDate BETWEEN @last AND @latest";
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@last", prevDate.Value.ToString("d"));
                cmd.Parameters.AddWithValue("@latest", CurrentDate.Value.ToString("d"));
                object result = cmd.ExecuteScalar();
                salesOfMonth.Text = result.ToString();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void monthlyProfit()
        {
            try
            {
                String Query = "select SUM((o.retailPrice-o.unitPrice)*o.quantity) as total from [order details] o where o.Order_id in (select Order_id from Orders WHERE OrderDate BETWEEN @last AND @latest)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@last", prevDate.Value.ToString("d"));
                cmd.Parameters.AddWithValue("@latest", CurrentDate.Value.ToString("d"));
                object result = cmd.ExecuteScalar();
                MProfit.Text = result.ToString();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PaySalary_Click(object sender, EventArgs e)
        {
            try
            {
                String Query = "select sum(salary) from Employees";
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);
                object result = cmd.ExecuteScalar();
                salaries = float.Parse(result.ToString());
                conn.Close();
                MProfit.Text = (float.Parse(MProfit.Text) - salaries).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SeeProfit_Click(object sender, EventArgs e)
        {
            monthlyProfit();
        }

        private void updateall_Click(object sender, EventArgs e)
        {
            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("UpdateStockswithPreOrder", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
            dashboard dash = new dashboard();
            dash.Show();
            this.Close();
        }
        private void DisplayDashStock()
        {
            try
            {
                conn.Open();
                string query = "select * from ViewStocksOndash where preOrder >0";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ViewStockDash.DataSource = dt;
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayDebt()
        {
            try
            {
                conn.Open();
                string query = "select * from DebtShow";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DebtDash.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            float debtAmount = 0;
            try
            {
                conn.Open();
                string query = "select SUM((o.retailPrice-o.unitPrice)*o.quantity) as total from [order details] o where o.Order_id in (select Order_id from Orders where isDebt = 1)";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                debtAmount = float.Parse(result.ToString());
                conn.Close();
                MProfit.Text = (float.Parse(MProfit.Text) - debtAmount).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void gostocks_Click(object sender, EventArgs e)
        {
            viewStocks vs = new viewStocks();
            vs.Show();
            this.Close();
        }
        private void FillChart()
        {
            string Query = "select sum(Total_Bill) as total,OrderDate from Orders WHERE OrderDate >= DATEADD(week, -1, GETDATE()) group by OrderDate";
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter ada = new SqlDataAdapter(Query, conn);
                ada.Fill(ds);
                ChartWeekSales.DataSource = ds;
                ChartWeekSales.Series["Sales"].XValueMember = "OrderDate";
                ChartWeekSales.Series["Sales"].YValueMembers = "total";
                ChartWeekSales.Titles.Add("Sales in Week");
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void prevDate_ValueChanged(object sender, EventArgs e)
        {
            findExpense();
        }

        private void CurrentDate_ValueChanged(object sender, EventArgs e)
        {
            findExpense();
        }
        private void findExpense()
        {
            monthlyProfit();
            monthlySales();
            String Query = "SELECT Sum(Amount) as total FROM expenses WHERE [Date] BETWEEN @last AND @latest";
            try
            {
                if (CurrentDate.Value > prevDate.Value)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@last", prevDate.Value.ToString("d"));
                    cmd.Parameters.AddWithValue("@latest", CurrentDate.Value.ToString("d"));
                    object result = cmd.ExecuteScalar();
                    float expenses = float.Parse(result.ToString());
                    MProfit.Text = (float.Parse(MProfit.Text) - expenses).ToString();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("select Valid Date");
                    CurrentDate.Value = DateTime.Today;
                    prevDate.Value = DateTime.Now.AddMonths(-1);
                }
            }
            catch(Exception es) {
                MessageBox.Show(es.Message);
            }

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
