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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wholesalers
{
    public partial class DebtForm : Form
    {
        public DebtForm()
        {
            InitializeComponent();
            conn.Open();
            String Query = "select * from DebtShow";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DebtView.DataSource = dt;
            conn.Close();
            FindTotalDebt();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        private void SellPointBtn_Click(object sender, EventArgs e)
        {
            SellPoint sp= new SellPoint();
            sp.Show();
            this.Close();
        }

        private void Something_Click(object sender, EventArgs e)
        {
            if(IDorder.Text != "" && Due.Text != "")
            {
                paySomethingForm psf = new paySomethingForm();
                psf.ID = int.Parse(IDorder.Text.ToString());
                psf.Due = float.Parse(Due.Text.ToString());
                psf.Show();
            }
            else
            {
                MessageBox.Show("Please first select Order from table");
            }
        }

        private void AllPayButton_Click(object sender, EventArgs e)
        {
            if(DebtView.SelectedRows.Count > 0)
            {
                paidAfterForm paf = new paidAfterForm();
                paf.ID = int.Parse(IDorder.Text.ToString());
                paf.Show();
            }
            else
            {
                MessageBox.Show("please select something from table");
            }
        }

        private void totalDebt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = SearchBox.Text + "%";
            string sqlQuery = "select * from DebtShow where ContactNumber like '" + q + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DebtView.DataSource = dt;
            conn.Close();
            FindTotalDebt();
        }

        private void DebtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DebtView.Rows[e.RowIndex];
                IDorder.Text = DebtView.CurrentRow.Cells[0].Value.ToString();
                DateOrder.Text = DebtView.CurrentRow.Cells[5].Value.ToString();
                ContactNo.Text = DebtView.CurrentRow.Cells[2].Value.ToString();
                NameShop.Text = DebtView.CurrentRow.Cells[1].Value.ToString();
                Due.Text = DebtView.CurrentRow.Cells[3].Value.ToString();
                Paid.Text = DebtView.CurrentRow.Cells[4].Value.ToString();
            }
        }
        private void FindTotalDebt()
        {
            float total = 0;
            for (int i = 0; i < DebtView.Rows.Count; i++)
            {
                total += int.Parse(DebtView.Rows[i].Cells[3].Value.ToString());
            }

            totalDebt.Text = total.ToString();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
