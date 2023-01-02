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
    public partial class comfirmdelEmployee : Form
    {
        public int EMP_id;
        public comfirmdelEmployee()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");


        private void confirmBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Query= "delete from Employees where Employee_id = "+EMP_id;
            SqlCommand sc = new SqlCommand(Query, conn);
            sc.ExecuteNonQuery();
            conn.Close();
            Application.OpenForms["empSup"].Close();
            empSup em=new empSup();
            em.Show();
            this.Close();
        }
    }
}
