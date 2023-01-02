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
    public partial class confirmAddProc : Form
    {
        public String Pname;
        public int Quantity,SID;
        public float Uprice, Rprice;
        public confirmAddProc()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into products (product_name,unitPrice,retailPrice,quantity,preOrder,supplier_id)values(@name,@UNIT,@RETAIL,@QUAN,0,@SUPP)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name",Pname);
                cmd.Parameters.AddWithValue("@UNIT", Uprice);
                cmd.Parameters.AddWithValue("@RETAIL", Rprice);
                cmd.Parameters.AddWithValue("@QUAN", Quantity);
                cmd.Parameters.AddWithValue("@SUPP", SID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
            Application.OpenForms["addProductform"].Close();
            Application.OpenForms["viewStocks"].Close();
            viewStocks vs = new viewStocks();
            vs.Show();
        }
    }
}
