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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if (uuname.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from users where uname = '" + uuname.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        if ( uuemail.Text == "" & uuphone.Text == "" & uuaddress.Text == "" )
                        {
                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                            errorLbl.Text = "You must at least enter something to update";
                        }
                        else
                        {

                            if (uuphone.Text != "")
                            {
                                string query = "update users set uphone = '" + uuphone.Text + "' where uname = '" + uuname.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }

                            

                            if (uuaddress.Text != "")
                            {
                                string query = "update users set uaddress = '" + uuaddress.Text + "' where uname = '" + uuname.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }
                            if (uuemail.Text != "")
                            {
                                string query = "update users set uemail = '" + uuemail.Text + "' where uname = '" + uuname.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }

                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Green;
                            errorLbl.Text = "Account updated successfully!";
                        }
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        errorLbl.Text = "Account doesn't exist!";
                    }
                }
                catch (Exception ex)
                {
                    errorLbl.Visible = true;
                    errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                    errorLbl.Text = ex.Message;
                }
            }
            else
            {
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                errorLbl.Text = "Enter your username to update";
            }
        }
    }
}
