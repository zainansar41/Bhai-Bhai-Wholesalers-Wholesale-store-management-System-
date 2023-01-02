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
    public partial class updateSupinfo : Form
    {
        public int Sup_id;
        public updateSupinfo()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void UpdateSup_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String Query = "update Suppliers set [name] = @Sname , [Address] = @Saddress , ContactNumber = @ScontactNo where Supplier_id = @spID";
                SqlCommand sc = new SqlCommand(Query, conn);
                sc.Parameters.AddWithValue("@spID", Sup_id);
                sc.Parameters.AddWithValue("@Sname", companyName.Text);
                sc.Parameters.AddWithValue("@Saddress", Address.Text);
                sc.Parameters.AddWithValue("@ScontactNo", ContactSup.Text);
                sc.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {

                conn.Close();
                Application.OpenForms["empSup"].Close();
                empSup es = new empSup();
                es.Show();
                this.Close();
            }
        }
    }
}
