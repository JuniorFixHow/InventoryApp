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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            db.openConnection();
            string query = "select id, name from category";
            MySqlCommand command = new MySqlCommand(query, db.connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            //DataRow item = dt.NewRow();
            //item[1] = "categories";
            //dt.Rows.InsertAt(item, 0);

            sCat.DataSource = dt;
            sCat.DisplayMember = "name";
            sCat.ValueMember = "id";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if (catTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from category where name = '" + catTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();   
                    if(count > 0)
                    {
                        db.openConnection();
                        titleLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        titleLbl.Text = "Category already exists";
                        errorLbl.Visible = false;
                        db.closeConnection();
                    }
                    else
                    {
                        db.openConnection();
                        string query = "insert into category(dat, name) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + catTxt.Text + "') ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        markIcon.Visible = true;
                        errorLbl.Visible = false;
                        titleLbl.ForeColor = Color.FromArgb(185, 138, 233);
                        titleLbl.Text = "Add New Category";
                        
                    }
                }
                catch(Exception ex)
                {
                    titleLbl.ForeColor = Color.FromArgb(192, 64, 0);
                    titleLbl.Text = ex.Message;
                }
            }
            else
            {
                errorLbl.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if (catTxt.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from category where name = '" + catTxt.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    db.closeConnection();
                    if (count < 1)
                    {
                        db.openConnection();
                        titleLbl.ForeColor = Color.FromArgb(192, 64, 0);
                        titleLbl.Text = "Category doesn't exist";
                        errorLbl.Visible = false;
                        db.closeConnection();
                    }
                    else
                    {
                        db.openConnection();
                        string query = "delete from category where name = '" + catTxt.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        db.closeConnection();
                        markIcon.Visible = true;
                        errorLbl.Visible = false;
                        titleLbl.ForeColor = Color.FromArgb(185, 138, 233);
                        titleLbl.Text = "Add New Category";
                        
                    }
                }
                catch (Exception ex)
                {
                    titleLbl.ForeColor = Color.FromArgb(192, 64, 0);
                    titleLbl.Text = ex.Message;
                }
            }
            else
            {
                errorLbl.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            db.openConnection();
            if(sPrice.Text!="" & sProd.Text!="" & sCat.Text!="" & sQuant.Text != "")
            {
                string query = "insert into stock(dat, product, category, quantity, price) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + sProd.Text + "', '" + sCat.Text + "', '" + sQuant.Text + "', '" + sPrice.Text + "')";
                command = new MySqlCommand(query, db.connection);
                command.ExecuteNonQuery();
                errorLb.Visible = true;
                errorLb.ForeColor = Color.Green;
                errorLb.Text = "Stocks loaded successfully";
            }
            else
            {
                errorLb.Visible = true;
                errorLb.ForeColor = Color.FromArgb(192, 64, 0);
                errorLb.Text = "Complete the required fields";
            }
        }
    }
}
