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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if(uname.Text!="" & uemail.Text!="" & uphone.Text!="" & uaddress.Text!="" & utype.Text != "" &upass.Text!="")
            {
                try
                {
                    string countQuery = "select count(*) from users where uemail = '" + uemail.Text + "' or uname = '" + uname.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);

                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        errorLbl.Visible = true;
                        errorLbl.Text = "Username or password alredy exists";
                        db.closeConnection();
                    }
                    else
                    {
                        string query = "insert into users(uname, uemail, upass, uphone, uaddress, utype) values('" + uname.Text + "', '" + uemail.Text + "', '" + upass.Text + "', '" + uphone.Text + "', '" + uaddress.Text + "', '" + utype.Text + "')";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.White;
                        errorLbl.Text = "User created successfully";
                    }
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
                errorLbl.Text = "Complete the required fields. \nNote: User ID is not required";
            }
        }
    }
}
