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
    public partial class AddCusAfterOrder : Form
    {
        public AddCusAfterOrder()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        private void AddCus_Click(object sender, EventArgs e)
        {
            if (ShopName.Text !="" || AddressBar.Text!="" || ContactNo.Text!="" || CNIC.Text!="")
            {
                try
                {
                    conn.Open();
                    string Query = "insert into Customers (Shop_name, [Address], ContactNumber, CNIC_OF_OWNER)values(@Sname, @Saddress, @Scontact, @SCNIC)";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@Sname", ShopName.Text);
                    cmd.Parameters.AddWithValue("@Saddress", AddressBar.Text);
                    cmd.Parameters.AddWithValue("@Scontact", ContactNo.Text);
                    cmd.Parameters.AddWithValue("@SCNIC", CNIC.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch(Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }

            this.Close();
        }
    }
}
