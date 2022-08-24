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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tCat.Region = new Region(new Rectangle(3, 3, tCat.Width - 3, tCat.Height - 7));
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if(tCat.Text!="" & tCust.Text!="" & tPrice.Text!="" & tQuant.Text!="" &tProd.Text!="")
            {
                //
                string query = "insert into trans(dat, cust, category, product, quantity, price) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + tCust.Text + "', '" + tCat.Text + "', '" + tProd.Text + "', '" + tQuant.Text + "', '" + tPrice.Text + "' )";
                command = new MySqlCommand(query, db.connection);
                command.ExecuteNonQuery();
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.Green;
                errorLbl.Text = "Transaction posted";
            }
            else
            {
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                errorLbl.Text = "Complete the required fields";
            }
        }
    }
}
