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
    public partial class Form8 : Form
    {
        Thread thread;
        public Form8()
        {
            InitializeComponent();
        }
        private void openApp(object form)
        {
            Application.Run(new Form6());
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openApp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if(pwdemail.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from users where uemail = '" + pwdemail.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "insert into pwdreq (dat, email) values ('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + pwdemail.Text + "')";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        errorLbl.Visible = true;
                        markIcon.Visible = true;
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        markIcon.Visible = false;
                        errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        errorLbl.Text = "User email doesn't exist";
                    }
                }
                catch(Exception ex)
                {
                    errorLbl.Visible = true;
                    markIcon.Visible = false;
                    errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                    errorLbl.Text = ex.Message;
                }
            }
            else
            {
                markIcon.Visible = false;
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                markIcon.Visible = false;
            }
        }
    }
}
