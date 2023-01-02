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
    public partial class paySomethingForm : Form
    {
        public int ID;
        public float Due,paid,lastPaid;
        public paySomethingForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void payBtn_Click(object sender, EventArgs e)
        {
            if(pay.Text!= "")
            {
                try
                {
                    paid = float.Parse(pay.Text.ToString());
                    Due -= paid;
                    getLastPaid();
                    paid += lastPaid;
                    string Query = "Update Debt set Due = @DueAnount,Paid = @paidAmount where Order_id = @IDorder";
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DueAnount", Due);
                        cmd.Parameters.AddWithValue("@paidAmount", paid);
                        cmd.Parameters.AddWithValue("@IDorder", ID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();

                }
                catch
                {
                    MessageBox.Show("Error in updating Due");
                }
                this.Close();
                Application.OpenForms["DebtForm"].Close();
                DebtForm df = new DebtForm();
                df.Show();
            }
        }
        private void getLastPaid()
        {
            try
            {
                string query = "select Paid from Debt where Order_id = @OrderID";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@OrderID", ID);
                object result = cmd.ExecuteScalar();
                lastPaid = (float)result;
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Error in getting last paid");
            }

        }
    }
}
