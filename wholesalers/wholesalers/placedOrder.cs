using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = System.Drawing.Font;

namespace wholesalers
{
    public partial class placedOrder : Form
    {
        public int isDebtBit,employeeID,CustomerID;
        public float Price, unitPrice, retailPrice;
        int orderId;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        [Obsolete]
        public placedOrder()
        {
            InitializeComponent();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            placed_in_order();
            GetLastOrderID();
            AddInOrderDetails();
            PrintOrder();
            if(isDebtBit== 1)
            {
                PlaceInDebt();
            }

            this.Close();
            Application.OpenForms["AfterPlaceOrder"].Close();
            Application.OpenForms["SellPoint"].Close();
            SellPoint sp = new SellPoint();
            sp.Show();
        }

        private void placed_in_order()
        {
            conn.Open();
            try
            {
                string Query = "insert into Orders (Customer_id, Employee_id, Total_Bill, OrderDate, isDebt)values(@CusID, @EmpID, @TBill, @Date, @IsDEBT)";
                SqlCommand sc = new SqlCommand(Query, conn);
                sc.Parameters.AddWithValue("@CusID", CustomerID);
                sc.Parameters.AddWithValue("@EmpID", employeeID);
                sc.Parameters.AddWithValue("@TBill", Price);
                sc.Parameters.AddWithValue("@Date", DateTime.Today);
                sc.Parameters.AddWithValue("@IsDEBT", isDebtBit);
                sc.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error in insrtion in orders table");
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetLastOrderID()
        {
            conn.Open();
            try
            {
                string query = "SELECT TOP 1 order_id FROM orders ORDER BY order_id DESC";
                SqlCommand command = new SqlCommand(query, conn);
                object result = command.ExecuteScalar();
                orderId = (int)result;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("error in getting order ID");
            }
        }

        
        private void getUnitPrice(int ID)
        {
            conn.Open();
            try
            {
                string query = "select unitPrice from Products where product_id = @IDProc";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDProc", ID);
                object result = command.ExecuteScalar();
                unitPrice = (float)result;
            }
            catch
            {
                MessageBox.Show("error in getting order ID");
            }
            finally
            {
                conn.Close();
            }
        }

        private void getRetailPrice(int ID)
        {
            conn.Open();
            try
            {
                string query = "select retailPrice from Products where product_id = @IDProc";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDProc", ID);
                object result = command.ExecuteScalar();
                retailPrice = (float)result;
            }
            catch
            {
                MessageBox.Show("error in getting order ID");
            }
            finally
            {
                conn.Close();
            }
        }

        private void AddInOrderDetails()
        {
            foreach (DataGridViewRow row in saveData.Rows)
            {
                try
                {                    
                    getUnitPrice((int)row.Cells["ProductID"].Value);
                    getRetailPrice((int)row.Cells["ProductID"].Value);
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO [order details] (Order_id, product_id, quantity, unitPrice, retailPrice, Total_Price) VALUES (@order_id, @product_id, @quantity, @UNIT, @RETAIL, @TOTAL)", conn))
                    {
                        command.Parameters.AddWithValue("@order_id", orderId);
                        command.Parameters.AddWithValue("@product_id", (int)row.Cells[3].Value);
                        command.Parameters.AddWithValue("@quantity", (int)row.Cells[1].Value);
                        command.Parameters.AddWithValue("@UNIT", unitPrice);
                        command.Parameters.AddWithValue("@RETAIL", retailPrice);
                        command.Parameters.AddWithValue("@TOTAL", (float)row.Cells[2].Value);
                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void PlaceInDebt()
        {
            try
            {
                conn.Open();
                string Query = "Insert into Debt values(@orderID, @PAID, @DUE)";
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderId);
                    cmd.Parameters.AddWithValue("@PAID", float.Parse("0"));
                    cmd.Parameters.AddWithValue("@DUE", Price);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void PrintOrder()
        {

            // Create a new PDF document
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
                doc.Add(new Paragraph("Order ID = " + orderId.ToString()));
                doc.Add(new Paragraph("\n"));

                // Add a table to the PDF with some sample data
                PdfPTable table = new PdfPTable(3);
                table.AddCell("Product Name");
                table.AddCell("Quantity");
                table.AddCell("Total Price");
                table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                table.AddCell("\n");
                table.AddCell("\n");
                table.AddCell("\n");


                // Set the total width of the table and the width of each column
                table.TotalWidth = 500;
                table.LockedWidth = true;
                table.SetTotalWidth(new float[] { 100, 100, 100 });

                // Add rows to the table from the data grid view
                foreach (DataGridViewRow row in saveData.Rows)
                {
                    table.AddCell(row.Cells[0].Value.ToString());
                    table.AddCell(row.Cells[1].Value.ToString());
                    table.AddCell(row.Cells[2].Value.ToString());
                    table.AddCell("\n");
                    table.AddCell("\n");
                    table.AddCell("\n");
                }
                doc.Add(table);

                // Add a footer to the PDF with the total price
                Paragraph footer = new Paragraph("Total = " + Price.ToString());
                footer.Alignment = Element.ALIGN_RIGHT;
            
                doc.Add(footer);

                // Close the PDF document
                doc.Close();

                // Write the PDF to a byte array
                byte[] pdfBytes = ms.ToArray();

                // You can now save the PDF to a file or send it to the client for download
                File.WriteAllBytes("C:\\Users\\HP\\Desktop\\projectgeneratedFile\\receipt.pdf", pdfBytes);
            }

        }
    }
}
