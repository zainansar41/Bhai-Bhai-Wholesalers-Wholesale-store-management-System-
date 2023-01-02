using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wholesalers
{
    public partial class Expenses : Form
    {
        String ExpenseNametxt;
        public Expenses()
        {
            InitializeComponent();
            ExpenseName.SelectedIndex = 0;
            FillCashiersID();
            CashierIDcombo.SelectedIndex = 0;
            DateLabel.Text = DateTime.Now.Date.ToString("d");
            FillExpenseView();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void AddExpense_Click(object sender, EventArgs e)
        {
            if(ExpenseName.SelectedIndex == 0 || AmountExpens.Text == "")
            {
                MessageBox.Show("please select expense Type or add something as amount");
            }
            else
            {
                try
                {
                    conn.Open();
                    String Query = "insert into expenses (ExpenseName,Amount,[Date],employee_ID)values(@Name,@amount,@date,@ID)";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@Name",ExpenseNametxt);
                    cmd.Parameters.AddWithValue("@amount", float.Parse(AmountExpens.Text.ToString()));
                    cmd.Parameters.AddWithValue("@date", DateLabel.Text);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(CashierIDcombo.SelectedItem.ToString()));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch(Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                this.Close();
            }
        }
        
        private void FillCashiersID()
        {
            try
            {
                conn.Open();
                String Query = "select Employee_id from cashiers";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    object id = dr.GetValue(0);
                    CashierIDcombo.Items.Add(id);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error in Getting Id's");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExpenseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ExpenseName.SelectedIndex == 1)
            {
                PAY.Visible = true;
            }
            ExpenseNametxt = ExpenseName.SelectedItem.ToString();
            
        }

        private void PAY_Click(object sender, EventArgs e)
        {
            String Query = "select sum(salary)as total from Employees";
            conn.Open();
            SqlCommand cmd = new SqlCommand(Query, conn);
            object result = cmd.ExecuteScalar();
            float salaries = float.Parse(result.ToString());
            conn.Close();
            AmountExpens.Text = salaries.ToString();
        }
        private void FillExpenseView()
        {
            try
            {
                conn.Open();
                string query = "select * from expenses ORDER BY expense_ID DESC";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ExpenseView.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
