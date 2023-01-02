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
    public partial class updateStockCon : Form
    {
        public int PID, OrderedQuantity, Stocks;
        public updateStockCon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Stocks += OrderedQuantity;
                conn.Open();
                String Query = "update products set quantity = @QuantityInStocks, preOrder = 0 where product_id = @ProcID";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@QuantityInStocks", Stocks);
                cmd.Parameters.AddWithValue("@ProcID", PID);
                cmd.ExecuteNonQuery();
                conn.Close();
                Application.OpenForms["viewStocks"].Close();
                viewStocks vs = new viewStocks();
                vs.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
