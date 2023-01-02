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
    public partial class addEmployeform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        public addEmployeform()
        {
            InitializeComponent();
        }
         
        private void NewEnployeebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeName.Text != "" && empAddress.Text!="" && empContactNo.Text!= "" && empCNICNo.Text != "")
                {
                    conn.Open();
                    string Query = "insert into Employees ([name],[Address],ContactNumber,CNIC,salary)values( @Newname, @NewAddress, @NewContact, @NewCNIC,@NewSalary)";
                    SqlCommand sc = new SqlCommand(Query, conn);
                    sc.Parameters.AddWithValue("@Newname", EmployeeName.Text);
                    sc.Parameters.AddWithValue("@NewAddress", empAddress.Text);
                    sc.Parameters.AddWithValue("@NewContact", empContactNo.Text);
                    sc.Parameters.AddWithValue("@NewCNIC", empCNICNo.Text);
                    sc.Parameters.AddWithValue("@NewSalary", float.Parse(salary.Text));
                    sc.ExecuteNonQuery();
                    conn.Close();

                    if (checkBox1.Checked)
                    {
                        givePassword gp = new givePassword();
                        gp.Contact_search = (string)empContactNo.Text;
                        gp.Show();
                    }
                    else
                    {
                        Application.OpenForms["empSup"].Close();
                        empSup es = new empSup();
                        es.Show();
                        this.Close();
                    }
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
