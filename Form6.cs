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
using XSystem.Security.Cryptography;

namespace InventoryApp
{
    public partial class Form6 : Form
    {
        Thread thread;
        public static string utype;
        public Form6()
        {
            InitializeComponent();
        }

        private void openApp(object form)
        {
            Application.Run(new Form1());
        }

        private void openPass(object form)
        {
            Application.Run(new Form8());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openPass);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static string Decrypt(string dec)
        {
            var decode = Convert.FromBase64String(dec);
            return Encoding.UTF8.GetString(decode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            db.openConnection();
             MySqlCommand command;
             if(useTxt.Text!="" & passTxt.Text != "")
             {

                try
                {
                    string countQuery = "select * from users where uname = '" + useTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count > 0)
                    {
                        db.openConnection();
                        string query = "select upass from users where uname =  '" + useTxt.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        MySqlDataReader read = command.ExecuteReader();
                        read.Read();
                        string data = read.GetValue(0).ToString();
                        //MessageBox.Show(data);
                        db.closeConnection();

                        db.openConnection();
                        string typeQuery = "select utype from users where uname =  '" + useTxt.Text + "' ";
                        command = new MySqlCommand(typeQuery, db.connection);
                        MySqlDataReader rd = command.ExecuteReader();
                        rd.Read();
                        //Form1.instance.tb1.Text = rd.GetValue(0).ToString();
                        utype = rd.GetValue(0).ToString();
                        //MessageBox.Show(utype);
                        db.closeConnection();
                        try
                        {
                            bool verified = Decrypt(data) == passTxt.Text;
                            if (verified)
                            {
                                this.Close();
                                thread = new Thread(openApp);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();

                               
                            }
                            else
                            {
                                errorLbl.Visible = true;
                                errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                                errorLbl.Text = "Incorrect email or password!";
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
                        errorLbl.Text = "Incorrect email or password!";
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
                 errorLbl.Text = "Username and password are required!";
             }
             
            
           /* this.Close();
            thread = new Thread(openApp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
