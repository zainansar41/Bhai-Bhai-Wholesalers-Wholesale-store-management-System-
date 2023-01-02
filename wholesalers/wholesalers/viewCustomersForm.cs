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

    public partial class viewCustomersForm : Form
    {
        public viewCustomersForm()
        {
            InitializeComponent();
            filters.SelectedIndex = 0;

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }

        private void AddCus_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShopName.Text != "" && AddressBar.Text != "" && ContactNo.Text!= "" && CNIC.Text !="")
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
                    viewCustomersForm vcf = new viewCustomersForm();
                    vcf.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You didn't add something");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String Query = "select * from Customers where ContactNumber = '" + searchbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                CustomerView.DataSource = dt;
                conn.Close();
                if (CustomerView.Rows.Count != 0)
                {
                    ShopName.Text = CustomerView.Rows[0].Cells[1].Value.ToString();
                    AddressBar.Text = CustomerView.Rows[0].Cells[2].Value.ToString();
                    ContactNo.Text = CustomerView.Rows[0].Cells[3].Value.ToString();
                    CNIC.Text = CustomerView.Rows[0].Cells[4].Value.ToString();
                    Clear.Visible = true;
                    AddCus.Visible = false;
                }
                else
                {
                    MessageBox.Show("No such Customer Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ShopName.Text = "";
            AddressBar.Text = "";
            ContactNo.Text = "";
            CNIC.Text = "";
            Clear.Visible = false;
            AddCus.Visible = true;
        }

        private void filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Query = "";
            if(filters.SelectedIndex == 0)
            {
                Query = "select * from Customers";
            }
            else if(filters.SelectedIndex == 1)
            {
                Query = "SELECT c.[Customer_id], c.[Shop_name], c.[ContactNumber], c.[CNIC_OF_OWNER],c.[Address] ,COUNT(o.customer_id) AS num_orders FROM customers c JOIN orders o ON c.Customer_id = o.customer_id GROUP BY c.Customer_id, c.Shop_name, c.ContactNumber, c.CNIC_OF_OWNER, c.[Address] ORDER BY num_orders DESC";
            }
            else if(filters.SelectedIndex == 2)
            {
                Query = "SELECT c.[Customer_id], c.[Shop_name], c.[ContactNumber], c.[CNIC_OF_OWNER],c.[Address] ,COUNT(o.customer_id) AS num_debt_orders FROM customers c JOIN orders o ON c.Customer_id= o.customer_id WHERE o.isDebt = 1 GROUP BY c.Customer_id, c.Shop_name, c.ContactNumber, c.CNIC_OF_OWNER, c.[Address] ORDER BY num_debt_orders DESC";
            }
            else if(filters.SelectedIndex == 3)
            {
                Query = "SELECT c.[Customer_id], c.[Shop_name], c.[ContactNumber], c.[CNIC_OF_OWNER],c.[Address] ,COUNT(o.customer_id) AS num_orders FROM customers c JOIN orders o ON c.Customer_id = o.customer_id GROUP BY c.Customer_id, c.Shop_name, c.ContactNumber, c.CNIC_OF_OWNER, c.[Address] ORDER BY num_orders";
            }
            else if(filters.SelectedIndex == 4)
            {
                Query = "SELECT c.[Customer_id], c.[Shop_name], c.[ContactNumber], c.[CNIC_OF_OWNER],c.[Address] ,COUNT(o.customer_id) AS num_debt_orders FROM customers c JOIN orders o ON c.Customer_id= o.customer_id WHERE o.isDebt = 1 GROUP BY c.Customer_id, c.Shop_name, c.ContactNumber, c.CNIC_OF_OWNER, c.[Address] ORDER BY num_debt_orders";
            }
            Apply_filters(Query);
        }
        private void Apply_filters(String Query)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                CustomerView.DataSource = dt;
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                search_Click(sender, e);
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
