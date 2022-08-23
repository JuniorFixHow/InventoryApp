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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Region = new Region(new Rectangle(3, 3, comboBox1.Width - 3, comboBox1.Height - 7));
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
