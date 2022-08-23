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
    public partial class Form6 : Form
    {
        Thread thread;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openApp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
