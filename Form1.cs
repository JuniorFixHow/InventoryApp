namespace InventoryApp
{
    public partial class Form1 : Form
    {
        bool transCollapse;
        bool stockCollapse;
        bool repCollapse;
        bool accCollapse;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            showForm(new Form2());
        }
        private void openApp(object form)
        {
            Application.Run(new Form6());
        }

        private void showForm(object form)
        {
            panel4.Controls.Clear();
            Form currentForm = form as Form;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            panel4.Tag = currentForm;
            panel4.Controls.Add(currentForm);
            currentForm.Show();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (transCollapse)
            {
                panel5.Height += 10;
                if(panel5.Height == panel5.MaximumSize.Height)
                {
                    transCollapse = false;
                    timer1.Stop();
                    panel6.SendToBack();
                    panel8.SendToBack();
                    panel9.SendToBack();
                }
                
            }
            else
            {
                panel5.Height -= 10;
                if(panel5.Height == panel5.MinimumSize.Height)
                {
                    transCollapse = true;
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (stockCollapse)
            {
                panel6.Height += 10;
                if (panel6.Height == panel6.MaximumSize.Height)
                {
                    stockCollapse = false;
                    timer2.Stop();
                    //panel5.Visible = false;
                    panel8.SendToBack();
                    panel9.SendToBack();
                }

            }
            else
            {
                panel6.Height -= 10;
                if (panel6.Height == panel6.MinimumSize.Height)
                {
                    stockCollapse = true;
                    //panel5.Visible = true;
                    timer2.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (repCollapse)
            {
                panel8.Height += 10;
                if (panel8.Height == panel8.MaximumSize.Height)
                {
                    repCollapse = false;
                    timer3.Stop();
                    //panel6.Visible = false;
                    //panel8.SendToBack();
                    panel9.SendToBack();
                }

            }
            else
            {
                panel8.Height -= 10;
                if (panel8.Height == panel8.MinimumSize.Height)
                {
                    repCollapse = true;
                    //panel6.Visible = true;
                    timer3.Stop();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (accCollapse)
            {
                panel9.Height += 10;
                if (panel9.Height == panel9.MaximumSize.Height)
                {
                    accCollapse = false;
                    timer4.Stop();
                    //panel5.Visible = false;
                    //panel8.SendToBack();
                    //panel9.SendToBack();
                }

            }
            else
            {
                panel9.Height -= 10;
                if (panel9.Height == panel9.MinimumSize.Height)
                {
                    accCollapse = true;
                    //panel5.Visible = true;
                    timer4.Stop();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showForm(new Form2());
            label2.Text = "Home";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showForm(new Form3());
            label2.Text = "Transactions";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showForm(new Form11());
            label2.Text = "Today's Report";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showForm(new Form9());
            label2.Text = "Stock Request";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showForm(new Form4());
            label2.Text = "Stock Management";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showForm(new Form15());
            label2.Text = "Stock Orders";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showForm(new Form12());
            label2.Text = "Stock Report";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            showForm(new Form13());
            label2.Text = "Sales Report (Over all)";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            showForm(new Form14());
            label2.Text = "Product Categories";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            showForm(new Form16());
            label2.Text = "Password Requests";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            showForm(new Form7());
            label2.Text = "Update Account";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            showForm(new Form5());
            label2.Text = "User Account Management";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showForm(new Form10());
            label2.Text = "Users Report";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openApp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}