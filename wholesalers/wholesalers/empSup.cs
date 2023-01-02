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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace wholesalers
{
    public partial class empSup : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        public empSup()
        {
            InitializeComponent();
            try
            {
                conn.Open();
                String Query = "select * from Employees";
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                EmployeeView.DataSource= dt;
                conn.Close();
                conn.Open();
                String sQuery = "select * from Suppliers";
                SqlDataAdapter sdr = new SqlDataAdapter(sQuery, conn);
                DataTable dtA = new DataTable();
                sdr.Fill(dtA);
                supllierView.DataSource = dtA;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void BackDash_Click(object sender, EventArgs e)
        {
            dashboard ds= new dashboard();
            ds.Show();
            this.Hide();
        }

        private void addSup_Click(object sender, EventArgs e)
        {
            addSupplierform sf=new addSupplierform();
            sf.Show();
        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            addEmployeform ef = new addEmployeform();
            ef.Show();
        }

        private void deleteEmp_Click(object sender, EventArgs e)
        {
            if (EmployeeView.SelectedRows.Count > 0)
            {
                comfirmdelEmployee cde = new comfirmdelEmployee();
                cde.EMP_id = (int)EmployeeView.CurrentRow.Cells[0].Value;
                cde.Show();
            }
            else
            {
                MessageBox.Show("Error in Deleting");
            }
            
        }

        private void deleteSup_Click(object sender, EventArgs e)
        {
            if (supllierView.SelectedRows.Count > 0)
            {
                confrimdelSupp cms = new confrimdelSupp();
                cms.SUP_id = (int)supllierView.CurrentRow.Cells[0].Value;
                cms.Show();
            }
            else
            {
                MessageBox.Show("Error in Deleting");
            }
        }

        private void updateSupinfo_Click(object sender, EventArgs e)
        {
            updateSupinfo us=new updateSupinfo();
            us.Sup_id = (int)supllierView.CurrentRow.Cells[0].Value;
            us.companyName.Text = supllierView.CurrentRow.Cells[1].Value.ToString();
            us.ContactSup.Text = supllierView.CurrentRow.Cells[3].Value.ToString();
            us.Address.Text = supllierView.CurrentRow.Cells[2].Value.ToString();
            us.Show();
        }

        private void updateEmpInfo_Click(object sender, EventArgs e)
        {
            updateEmpInfo em=new updateEmpInfo();
            em.empID = (int)EmployeeView.CurrentRow.Cells[0].Value;
            em.EmployeeName.Text = EmployeeView.CurrentRow.Cells[1].Value.ToString();
            em.empContactNo.Text = EmployeeView.CurrentRow.Cells[3].Value.ToString();
            em.empCNICNo.Text = EmployeeView.CurrentRow.Cells[4].Value.ToString();
            em.salary.Text = EmployeeView.CurrentRow.Cells[5].Value.ToString();
            em.empAddress.Text = EmployeeView.CurrentRow.Cells[2].Value.ToString();
            em.Show();
            
        }

        private void searchEmp_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = searchEmp.Text + "%";
            string sqlQuery = "select * from Employees where [Name] like '"+q+"'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmployeeView.DataSource = dt;
            conn.Close();
        }

        private void searchSupp_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = searchSupp.Text + "%";
            string sqlQuery = "select * from Suppliers where [Name] like '" + q + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            supllierView.DataSource = dt;
            conn.Close();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
