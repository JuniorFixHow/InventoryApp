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
                }
                catch(Exception ex)
                {
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
    }
}
