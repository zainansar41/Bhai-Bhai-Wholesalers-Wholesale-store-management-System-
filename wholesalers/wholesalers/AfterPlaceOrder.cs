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
    public partial class AfterPlaceOrder : Form
    {
         public float totalPriceOrder;
        public AfterPlaceOrder()
        {
            InitializeComponent();
            fillEmployeeList();


        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void addCus_Click(object sender, EventArgs e)
        {
            AddCusAfterOrder cs = new AddCusAfterOrder();
            cs.Show();
        }

        [Obsolete]
        private void placeOrder_Click(object sender, EventArgs e)
        {
            int isdebt;
            if (isDEBTcheck.Checked){
                isdebt = 1;
            }
            else
            {
                isdebt = 0;
            }
            int ID = getCustomerIDFromDB();
            if (ID != 0)
            {
                placedOrder od = new placedOrder();
                od.CustomerID = ID;
                DataGridView targetGridView = od.saveData;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string productName = (string)row.Cells[0].Value;
                    int quantity = (int)row.Cells[1].Value;
                    float totalPrice = (float)row.Cells[2].Value;
                    int productId = (int)row.Cells[3].Value;
                    targetGridView.Rows.Add(new object[] { productName, quantity, totalPrice, productId });
                }
                if (EmpList.SelectedIndex != -1)
                {
                    od.employeeID = Int32.Parse((EmpList.SelectedItem.ToString()));
                    od.isDebtBit = isdebt;
                    od.Price = totalPriceOrder;
                    od.Show();
                }
                else
                {
                    MessageBox.Show("please select employeeID");
                }
            }
            else
            {
                MessageBox.Show("No Such Customer Found Try adding New Customer");
            }
            
        }
        void fillEmployeeList()
        {
            try
            {
                conn.Open();
                String Query = "SELECT Employee_id FROM employees WHERE Employee_id NOT IN (SELECT employee_id FROM cashiers)";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    object id = dr.GetValue(0);
                    EmpList.Items.Add(id);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error in Getting Id's");
            }
        }

        [Obsolete]
        int getCustomerIDFromDB()
        {
            int customerID;
            conn.Open();

            try
            {
                using (SqlCommand command = new SqlCommand("select dbo.getCustomerID(@contactNumber)", conn))
                {
                    SqlParameter param = new SqlParameter("@contactNumber", SqlDbType.NVarChar, 12);
                    command.Parameters.Add("@contactNumber", CusContactNO.Text.ToString());

                    object result = command.ExecuteScalar();
                    customerID = (int)result;
                    return customerID;
                }
            }
            catch
            {
                AddCusAfterOrder cs = new AddCusAfterOrder();
                cs.Show();
            }
            conn.Close();
            return 0;

        }

        private void AfterPlaceOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
