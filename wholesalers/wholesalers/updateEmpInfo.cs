using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wholesalers
{
    public partial class updateEmpInfo : Form
    {
        public int empID;
        string Ename, Eaddress, EcontactNo, ECnic;
        float Esalary;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void empCNICNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void empAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void empContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        public updateEmpInfo()
        {
            InitializeComponent();
        }


        private void updateInfo_Click(object sender, EventArgs e)
        {
            Ename = EmployeeName.Text;
            Eaddress = empAddress.Text;
            EcontactNo=empContactNo.Text;
            ECnic = empCNICNo.Text;
            Esalary = float.Parse(salary.Text);
            try
            {
                conn.Open();
                String Query = "update Employees set [name] = @Ename , [Address] = @Eaddress , ContactNumber = @EcontactNo, CNIC = @ECnic, salary = @Esalary where Employee_id = @empID";
                SqlCommand sc= new SqlCommand(Query, conn);
                sc.Parameters.AddWithValue("@empID", empID);
                sc.Parameters.AddWithValue("@Ename", EmployeeName.Text);
                sc.Parameters.AddWithValue("@Eaddress", empAddress.Text);
                sc.Parameters.AddWithValue("@EcontactNo", empContactNo.Text);
                sc.Parameters.AddWithValue("@ECnic", empCNICNo.Text);
                sc.Parameters.AddWithValue("@Esalary", float.Parse(salary.Text));
                sc.ExecuteNonQuery();
                
            }
            catch(Exception err)
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
