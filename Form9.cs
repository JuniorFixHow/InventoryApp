using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void fetchData()
        {
            string query = "select id as OrderID, dat as Date, product as Product, quantity as Quantity from orders";
            DataSet ds = new DataSet();
            DataView dv;
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                db.openConnection();
                MySqlCommand command = new MySqlCommand(query, db.connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                db.closeConnection();

                dv = ds.Tables[0].DefaultView;
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            oId.Clear();
            odQuant.Clear();
            odProd.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if(odProd.Text!="" & odQuant.Text != "")
            {
                try
                {
                    string query = "insert into orders (dat, product, quantity) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + odProd.Text + "', '" + odQuant.Text + "' )";
                    command = new MySqlCommand(query, db.connection);
                    command.ExecuteNonQuery();
                    db.closeConnection();
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.Green;
                    errorLbl.Text = "Product ordered";
                    clear();
                    fetchData();
                }
                catch(Exception ex)
                {
                    errorLbl.Visible = true;
                    errorLbl.Text = ex.Message;
                }
            }
            else
            {
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                errorLbl.Text = "Product name and quantity are required";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if (oId.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from orders where id =  '" + oId.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "delete from orders where id = '" + oId.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "Order reclined successfully";
                        clear();
                        fetchData();
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        errorLbl.Text = "No order matches the provided ID";
                    }
                }
                catch (Exception ex)
                {
                    errorLbl.Text = ex.Message;
                }
            }
            else
            {
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                errorLbl.Text = "Enter order ID";
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        public void print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Stock Requested";
            printer.SubTitle = string.Format("Date {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "JuniorFixHow";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
