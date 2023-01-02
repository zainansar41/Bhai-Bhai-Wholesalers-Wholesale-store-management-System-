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
    public partial class confrimdelSupp : Form
    {
        public int SUP_id;
        public confrimdelSupp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query = "delete from Suppliers where Supplier_id = " + SUP_id;
            SqlCommand sc = new SqlCommand(Query, conn);
            sc.ExecuteNonQuery();
            conn.Close();
            Application.OpenForms["empSup"].Close();
            empSup em = new empSup();
            em.Show();
            this.Close();
        }
    }
}
