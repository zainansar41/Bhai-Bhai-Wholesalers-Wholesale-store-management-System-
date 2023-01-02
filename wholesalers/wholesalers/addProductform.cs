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
    public partial class addProductform : Form
    {
        public addProductform()
        {
            InitializeComponent();
            fillSupplierList();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void Addproc_Click(object sender, EventArgs e)
        {
            confirmAddProc cap=new confirmAddProc();
            cap.Pname = nameProc.Text;
            cap.Quantity = int.Parse(QuantityProc.Text);
            cap.SID = int.Parse(SuppID.SelectedItem.ToString());
            cap.Uprice = int.Parse(UnitPriceproc.Text);
            cap.Rprice = int.Parse(salePriceProc.Text);
            cap.Show();
        }
        void fillSupplierList()
        {
            try
            {
                conn.Open();
                String Query = "select Supplier_id from Suppliers";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    object id = dr.GetValue(0);
                    SuppID.Items.Add(id);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error in Getting Id's");
            }
        }

        private void SuppID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
