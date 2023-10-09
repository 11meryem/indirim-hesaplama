using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat=Convert.ToDouble(txtFiyat.Text);
            double odenecek = 0;

            if (rbYok.Checked)
            {
                odenecek = fiyat;
            }
            else if (rbindrim5.Checked)
            {
                odenecek = fiyat * 0.95;
            }
            else if (rbindirim30.Checked)
            {
                odenecek = fiyat * 0.70;
            }
            else
            {
                odenecek = fiyat * 0.60;
            }
            lblOdenecek.Text=odenecek.ToString();
        }
    }
}
