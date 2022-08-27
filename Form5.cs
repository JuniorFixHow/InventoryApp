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
using System.Net;
using System.Net.Mail;
using BCrypt.Net;
using XSystem.Security.Cryptography;

namespace InventoryApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void clear()
        {
            uname.Clear();
            upass.Clear();
            uemail.Clear();
            uphone.Clear();
            uaddress.Clear();
            uid.Clear();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static string randPass = RandomString(8);

        public static string Encrypt(string enc)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(enc);
            //MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return Convert.ToBase64String(data);

        }

        //private static string salt = BCrypt.Net.BCrypt.GenerateSalt(13);
        private static string passwordHash = Encrypt(randPass);

        private void sendEmail()
        {
            string fromEmail = "juniorfixhow@gmail.com";
            string password = "lfkcsjacgvxmzywu";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromEmail);
            message.Subject = "Welcome to JuniorFixHow";
            message.To.Add(new MailAddress(uemail.Text));
            message.Body = "<html> <body> <p>Hello! You are added as a user. You can login with: <p>Username: '"+uname.Text+"' </p> and <p>Password: '" + randPass + "' </p>  </p> </body> </html>";
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
            if(uname.Text!="" & uemail.Text!="" & uphone.Text!="" & uaddress.Text!="" & utype.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from users where uemail = '" + uemail.Text + "' or uname = '" + uname.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);

                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        errorLbl.Text = "Username or password alredy exists";
                        db.closeConnection();
                    }
                    else
                    {
                        string query = "insert into users(uname, uemail, upass, uphone, uaddress, utype) values('" + uname.Text + "', '" + uemail.Text + "', '" + passwordHash + "', '" + uphone.Text + "', '" + uaddress.Text + "', '" + utype.Text + "')";
                        command = new MySqlCommand(query, db.connection);
                        int data = command.ExecuteNonQuery();
                        db.closeConnection();
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "User created successfully";
                        clear();
                        sendEmail();
                    }
                }
                catch(Exception ex)
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
                errorLbl.Text = "Complete the required fields. \nNote: User ID is not required";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if (uid.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from users where uid = '" + uid.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if(count > 0)
                    {
                        db.openConnection();
                        string query = "delete from users where uid = '" + uid.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.Green;
                        errorLbl.Text = "User deleted successfully";
                        clear();
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        errorLbl.Text = "User does not exists";
                    }
                }
                catch(Exception ex)
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
                errorLbl.Text = "Enter the ID of the user you are deleting";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if (uid.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from users where uid = '" + uid.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        if(uname.Text=="" & uemail.Text=="" & upass.Text==""&uphone.Text==""&uaddress.Text==""& utype.Text == "")
                        {
                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                            errorLbl.Text = "You must at least enter something to update";
                        }
                        else if(upass.Text !="" & upass.Text.Length <8)
                        {
                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                            errorLbl.Text = "Password must at least be 8 characters";
                            upass.Focus();
                        }
                        else
                        {
                            if (uname.Text != "")
                            {
                                string query = "update users set uname = '" + uname.Text + "' where uid = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }

                            if (uemail.Text != "")
                            {
                                string query = "update users set uemail = '" + uemail.Text + "' where uid = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }

                            if (uphone.Text != "")
                            {
                                string query = "update users set uphone = '" + uphone.Text + "' where uid = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }

                            if (upass.Text != "")
                            {
                                string query = "update users set upass = '" + upass.Text + "' where uid = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }

                            if (uaddress.Text != "")
                            {
                                string query = "update users set uaddress = '" + uaddress.Text + "' where uid = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }
                            if (utype.Text != "")
                            {
                                string query = "update users set utype = '" + utype.Text + "' where uid = '" + uid.Text + "' ";
                                command = new MySqlCommand(query, db.connection);
                                db.closeConnection();
                            }

                            errorLbl.Visible = true;
                            errorLbl.ForeColor = Color.Green;
                            errorLbl.Text = "User updated successfully!";
                            clear();
                        }
                    }
                    else
                    {
                        errorLbl.Visible = true;
                        errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        errorLbl.Text = "User doesn't exist!";
                    }
                }
                catch(Exception ex)
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
                errorLbl.Text = "Enter the ID of the user you are updating";
            }
        }
    }
}
