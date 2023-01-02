using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wholesalers
{

    public partial class addSupplierform : Form
    {
        public addSupplierform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        private void AddSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (companyName.Text != "" && Address.Text != "" && ContactSup.Text != "")
                {
                    conn.Open();
                    string Query = "insert into Suppliers ([name],[Address],ContactNumber)values( @Newname, @NewAddress, @NewContact)";
                    SqlCommand sc = new SqlCommand(Query, conn);
                    sc.Parameters.AddWithValue("@Newname", companyName.Text);
                    sc.Parameters.AddWithValue("@NewAddress", Address.Text);
                    sc.Parameters.AddWithValue("@NewContact", ContactSup.Text);
                    sc.ExecuteNonQuery();
                    conn.Close();
                    Application.OpenForms["empSup"].Close();
                    empSup es = new empSup();
                    es.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Somthing you Misses");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
