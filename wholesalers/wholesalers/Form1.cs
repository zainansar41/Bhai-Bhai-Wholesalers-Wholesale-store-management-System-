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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJDPC5\SQLEXPRESS;Initial Catalog=BhaiBhaiWholesalers;Integrated Security=True");

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void namefield_Enter(object sender, EventArgs e)
        {
            if(namefield.Text== "Enter Name")
            {
                namefield.Text = "";
            }
        }

        private void namefield_Leave(object sender, EventArgs e)
        {
            if (namefield.Text == "")
            {
                namefield.Text = "Enter Name";
            }
        }

        private void passwordfield_Enter(object sender, EventArgs e)
        {
            if(passwordfield.Text== "password")
            {
                passwordfield.Text = "";
            }
        }

        private void passwordfield_Leave(object sender, EventArgs e)
        {
            if (passwordfield.Text == "")
            {
                passwordfield.Text = "password";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Show")
            {
                label1.Text = "Hide";
                label1.ForeColor = Color.DodgerBlue;
                passwordfield.UseSystemPasswordChar = false;
            }
            else if (label1.Text == "Hide")
            {
                label1.Text = "Show";
                label1.ForeColor = Color.Crimson;
                passwordfield.UseSystemPasswordChar = true;
            }

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            nameError.Text = "";
            pwdError.Text = "";
            String username,password;
            username = namefield.Text;
            password= passwordfield.Text;
            if (namefield.Text == "" || namefield.Text == "Enter Name")
            {
                nameError.Text = "Username field can not be empty";
            }
            else if (passwordfield.Text == "" || passwordfield.Text == "password")
            {
                pwdError.Text = "password field can not be empty";
            }

            try
            {
                conn.Open();
                String Query = "select * from LoginTbl where [name]= '" + namefield.Text + "' AND [password]= '" + passwordfield.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (username== "AbdulAleem")
                    {
                        dashboard d = new dashboard();
                        d.Show();
                        this.Hide();
                    }
                    else
                    {
                        SellPoint sp = new SellPoint();
                        sp.Show();
                        this.Hide();
                    }

                }
                else
                {
                    pwdError.Text = "Name or Password is incorrect";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void passwordfield_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter) {
                Loginbtn_Click(sender, e);
             }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
