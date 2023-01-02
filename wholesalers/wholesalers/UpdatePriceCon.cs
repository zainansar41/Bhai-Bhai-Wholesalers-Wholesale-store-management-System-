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
    public partial class UpdatePriceCon : Form
    {
        public int PID;
        public float Uprice, RPrice;
        public UpdatePriceCon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void yes_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String Query = "update products set unitPrice = @UNIT, retailPrice=@RETAIL where product_id =@procID";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@UNIT", Uprice);
                cmd.Parameters.AddWithValue("@RETAIL", RPrice);
                cmd.Parameters.AddWithValue("@ProcID", PID);
                cmd.ExecuteNonQuery();
                conn.Close();
                Application.OpenForms["viewStocks"].Close();
                viewStocks vs = new viewStocks();
                vs.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
