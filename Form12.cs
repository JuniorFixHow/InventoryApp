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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        public void print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Stock Report";
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
        private void fetchData()
        {
            string query = "select id as StockID, dat as Date, category as Category, product as Product, quantity as Quantity from stock";
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

        private void Form12_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
