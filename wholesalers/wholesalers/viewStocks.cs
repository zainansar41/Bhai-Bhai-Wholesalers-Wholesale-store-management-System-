using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wholesalers
{
    public partial class viewStocks : Form
    {
        private String ProcID;
        public viewStocks()
        {
            InitializeComponent();
            filterProducts.SelectedIndex= 0;

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");
        
        private void initializeViewStock(String Query)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                productViewasStock.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {
            addProductform apf= new addProductform();
            apf.Show();
        }

        private void UpdateStock_Click(object sender, EventArgs e)
        {
            if (Quantity.Text != "" && PreOrder.Text != "")
            {
                updateStockCon cs = new updateStockCon();
                cs.PID = int.Parse(ProcID);
                cs.Stocks = int.Parse(Quantity.Text);
                cs.OrderedQuantity = int.Parse(PreOrder.Text);
                cs.Show();
            }
            else
            {
                MessageBox.Show("please select any product from table");
            }
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            dashboard ds=new dashboard();
            ds.Show();
            this.Close();
        }

        private void SearchProduct_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string q = SearchProduct.Text + "%";
            string sqlQuery = "select * from StocksView where product_name like '" + q + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            productViewasStock.DataSource = dt;
            conn.Close();
        }

        private void productViewasStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = productViewasStock.Rows[e.RowIndex];
                NameProduct.Text = productViewasStock.CurrentRow.Cells[0].Value.ToString();
                NameCompany.Text = productViewasStock.CurrentRow.Cells[1].Value.ToString();
                ContackNoCom.Text = productViewasStock.CurrentRow.Cells[2].Value.ToString();
                PriceRetail.Text = productViewasStock.CurrentRow.Cells[3].Value.ToString();
                priceUnit.Text = productViewasStock.CurrentRow.Cells[4].Value.ToString();
                Quantity.Text = productViewasStock.CurrentRow.Cells[5].Value.ToString();
                PreOrder.Text = productViewasStock.CurrentRow.Cells[6].Value.ToString();
                ProcID = productViewasStock.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void updatePrice_Click(object sender, EventArgs e)
        {
            if (PriceRetail.Text != "" && priceUnit.Text != "")
            {
                UpdatePriceCon cp = new UpdatePriceCon();
                cp.RPrice = float.Parse(PriceRetail.Text);
                cp.Uprice = float.Parse(priceUnit.Text);
                cp.PID = int.Parse(ProcID);
                cp.Show();
            }
            else
            {
                MessageBox.Show("please select Product from table");
            }
        }

        private void addInOrder_Click(object sender, EventArgs e)
        {
            if(NameProduct.Text !="" && NameCompany.Text != "" && ContackNoCom.Text != "" && PriceRetail.Text!="" && priceUnit.Text !="" && PreOrder.Text != "" && PreOrder.Text!= "")
            {
                if((int.Parse(PreOrder.Text)) >0)
                {
                    int quantity = int.Parse(PreOrder.Text);
                    float price = float.Parse(priceUnit.Text);
                    float total = quantity * price;
                    orderListView.Rows.Add(NameProduct.Text, NameCompany.Text, ContackNoCom.Text, price, quantity, total,int.Parse(ProcID));
                }
                else
                {
                    MessageBox.Show("Please Enter Something!");
                }
            }
            else
            {
                MessageBox.Show("please select product first!");
            }
        }

        private void PrintO_Click(object sender, EventArgs e)
        {
            if (orderListView.Rows.Count != 0)
            {

                Document doc = new Document();

                // Set the page size and margins
                doc.SetPageSize(PageSize.A4);
                doc.SetMargins(36, 36, 36, 36);

                // Create a new PDF writer that will save the PDF to a memory stream
                using (var ms = new MemoryStream())
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, ms);

                    // Open the PDF document
                    doc.Open();

                    // Add a header to the PDF
                    iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24);
                    Paragraph header = new Paragraph("Bhai Bhai Wholesaler", font);
                    header.Alignment = Element.ALIGN_CENTER;
                    doc.Add(header);

                    // Add an empty line
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("\n"));

                    // Add a table to the PDF with some sample data
                    PdfPTable table = new PdfPTable(6);
                    table.AddCell("Product Name");
                    table.AddCell("Company Name");
                    table.AddCell("Contact No");
                    table.AddCell("Price");
                    table.AddCell("Quantity");
                    table.AddCell("Total Price");
                    table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    table.AddCell("\n");
                    table.AddCell("\n");
                    table.AddCell("\n");
                    table.AddCell("\n");
                    table.AddCell("\n");
                    table.AddCell("\n");


                    // Set the total width of the table and the width of each column
                    table.TotalWidth = 800;
                    table.LockedWidth = true;
                    table.SetTotalWidth(new float[] { 100, 100, 100, 90, 70, 80 });

                    // Add rows to the table from the data grid view
                    foreach (DataGridViewRow row in orderListView.Rows)
                    {
                        table.AddCell(row.Cells[0].Value.ToString());
                        table.AddCell(row.Cells[1].Value.ToString());
                        table.AddCell(row.Cells[2].Value.ToString());
                        table.AddCell(row.Cells[3].Value.ToString());
                        table.AddCell(row.Cells[4].Value.ToString());
                        table.AddCell(row.Cells[5].Value.ToString());
                        table.AddCell("\n");
                        table.AddCell("\n");
                        table.AddCell("\n");
                        table.AddCell("\n");
                        table.AddCell("\n");
                        table.AddCell("\n");
                        preorderAdd(int.Parse(row.Cells[6].Value.ToString()), int.Parse(row.Cells[4].Value.ToString()));
                    }
                    doc.Add(table);
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("\n"));
                    // Add a footer to the PDF with the total price
                    Paragraph footer = new Paragraph("Regards");
                    footer.Alignment = Element.ALIGN_RIGHT;

                    doc.Add(footer);

                    // Close the PDF document
                    doc.Close();

                    // Write the PDF to a byte array
                    byte[] pdfBytes = ms.ToArray();

                    // You can now save the PDF to a file or send it to the client for download
                    File.WriteAllBytes("C:\\Users\\HP\\Desktop\\projectgeneratedFile\\Supplierreceipt.pdf", pdfBytes);
                }
                viewStocks vsa = new viewStocks();
                vsa.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("the is nothing for order to be placed");
            }
        }
        private void preorderAdd(int ID, int quantity)
        {
            try
            {
                conn.Open();
                String Query = "update products set preOrder = preOrder + @ordered where product_id = @PROCID";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@ordered", quantity);
                cmd.Parameters.AddWithValue("@PROCID", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Query = "";
            if(filterProducts.SelectedIndex == 0)
            {
                Query = "select * from StocksView";
            }
            else if(filterProducts.SelectedIndex == 1)
            {
                Query = "select * from StocksView where quantity <30";
            }
            else if(filterProducts.SelectedIndex == 2)
            {
                Query = "select * from StocksView where retailPrice >5000";
            }

            initializeViewStock(Query);
        }
        private void closeButton_Click(object sender, EventArgs e)
{
    Application.Exit();
}
    }
}
