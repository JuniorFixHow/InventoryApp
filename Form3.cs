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
using System.Data.SqlClient;
using USB_Barcode_Scanner;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;

namespace InventoryApp
{
    public partial class Form3 : Form
    {
        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        public Form3()
        {
            InitializeComponent();
            tCat.Region = new Region(new Rectangle(3, 3, tCat.Width - 3, tCat.Height - 7));
        }

        private void clear()
        {
            textBox1.Clear();
            tPrice.Clear();
            tQuant.Clear();
            tCust.Clear();
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filter)
                barcodeCombo.Items.Add(filterInfo.Name);
            barcodeCombo.SelectedIndex = 0;

            try
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

                tCat.DataSource = dt;
                tCat.DisplayMember = "name";
                tCat.ValueMember = "id";
                tPrice.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receipt()
        {
            rDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            rCust.Text = tCust.Text;
            rProd.Text = tProd.Text;
            rQuant.Text = tQuant.Text;
            rPrice.Text = "GHC "+tPrice.Text;
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
                string query = "insert into trans(dat, cust, category, product, quantity, price, barcode) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + tCust.Text + "', '" + tCat.Text + "', '" + tProd.Text + "', '" + tQuant.Text + "', '" + tPrice.Text + "', '"+barcodeLbl.Text+"' )";
                command = new MySqlCommand(query, db.connection);
                command.ExecuteNonQuery();
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.Green;
                errorLbl.Text = "Transaction posted";
                receipt();
                clear();
            }
            else
            {
                errorLbl.Visible = true;
                errorLbl.ForeColor = Color.FromArgb(192, 64, 0);
                errorLbl.Text = "Complete the required fields";
            }
        }


        private void tProd_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                db.openConnection();
                string query = "select id, product from stock where category = '" + tCat.Text + "' ";
                MySqlCommand command = new MySqlCommand(query, db.connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tProd.DataSource = dt;
                tProd.DisplayMember = "product";
                tProd.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tQuant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                tQuant.Text = "";
                e.Handled = true;
            }
        }
        private void tQuant_TextChanged(object sender, EventArgs e)
        {
            int val;
            bool result = int.TryParse(tQuant.Text, out val);
            if (!result)
            {
                tQuant.Text = null;
            }
            else
            {
                if (tQuant.Text != null & Convert.ToDouble(tQuant.Text) > 0)
                {
                    db.openConnection();
                    MySqlCommand command;
                    try
                    {
                        string query = "select price from stock where product = '" + tProd.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        MySqlDataReader price = command.ExecuteReader();
                        price.Read();
                        double setPrice = Convert.ToDouble(price.GetValue(0).ToString()) * Convert.ToDouble(tQuant.Text);
                        tPrice.Text = setPrice.ToString();
                        db.closeConnection();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //tPrice.Text = price.GetValue(0).ToString();
                }

                else
                {
                    tPrice.Text = "0.00";
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BarcodeScanner scanner = new BarcodeScanner(barcodeLbl);
            //scanner.BarcodeScanned += Scanner_BarcodeScanned;
            captureDevice = new VideoCaptureDevice(filter[barcodeCombo.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                BarcodeReader bar = new BarcodeReader();
                Result result = bar.Decode((Bitmap)pictureBox1.Image);
                if(result!= null)
                {
                    barcodeLbl.Text = result.ToString();
                    //MessageBox.Show(result.ToString());
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.openConnection();
            MySqlCommand command;
            if (textBox1.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from trans where id = '" + textBox1.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from trans where id = '" + textBox1.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        clear();
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
                errorLbl.Text = "Provide ID to delete a transaction";
            }
        }
    }
}
