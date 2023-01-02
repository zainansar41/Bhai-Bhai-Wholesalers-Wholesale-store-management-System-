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
using System.Collections;

namespace wholesalers
{
    public partial class givePassword : Form
    {
        public String Contact_search;
        public givePassword()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void addinCashier_Click(object sender, EventArgs e)
        {
            try
            {
                if (password.Text != "")
                {
                    conn.Open();
                    string sqlQuery = "select Employee_id from Employees where ContactNumber = '" + Contact_search + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    int emp_id = int.Parse(dr["Employee_id"].ToString());
                    conn.Close();

                    conn.Open();
                    string Query = "insert into cashiers values (" + emp_id + ",@password )";
                    SqlCommand sc = new SqlCommand(Query, conn);
                    sc.Parameters.AddWithValue("@password", password.Text);
                    sc.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                    Application.OpenForms["addEmployeform"].Close();
                }
                else
                {
                    MessageBox.Show("Something you Miss");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
