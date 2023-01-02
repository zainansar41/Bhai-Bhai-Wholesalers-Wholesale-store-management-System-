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
    public partial class paidAfterForm : Form
    {
        public int ID;
        public paidAfterForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        private void Continue_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update Orders set isDebt = 0 where Order_id = @IDorder";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDorder", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                deleteFromDebt();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
            Application.OpenForms["DebtForm"].Close();
            DebtForm df = new DebtForm();
            df.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void deleteFromDebt()
        {
            try
            {
                string query = "delete from Debt where Order_id  = @IDorder";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IDorder", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
