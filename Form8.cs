using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        private void sendEmail()
        {
            string fromEmail = "juniorfixhow@gmail.com";
            string password = "lfkcsjacgvxmzywu";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(pwdemail.Text);
            message.Subject = "Welcome to JuniorFixHow";
            message.To.Add(new MailAddress(fromEmail));
            message.Body = "<html> <body> <p>The user with email '"+pwdemail.Text+"' has requested for a password reset</p> </body> </html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, password),
                EnableSsl = true,
            };
            smtpClient.Send(message);
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
