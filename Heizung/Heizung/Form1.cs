using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Heizung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trkB_1_Scroll(object sender, EventArgs e)
        {

            label1.Text = trkB_1.Value.ToString();

            if (Convert.ToInt32(label1.Text) <= Convert.ToInt32(txtb_min1.Text))
            {
                lbl_hei1.Text = "Es wird in Wohnung 1 geheizt";
            }
            if (Convert.ToInt32(label1.Text) >= Convert.ToInt32(txtb_max1.Text))
            {
                lbl_hei1.Text = "Heizung ist ausgeschalten haha";
            }
        }

        private void trkB_2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trkB_2.Value.ToString();
            if (Convert.ToInt32(label2.Text) <= Convert.ToInt32(txtB_min2.Text))
            {
                lbl_hei2.Text = "Es wird in Wohnung 2 geheizt";
            }
            if (Convert.ToInt32(label2.Text) >= Convert.ToInt32(txtB_max2.Text))
            {
                lbl_hei2.Text = "Heizung ist ausgeschalten";
            }
        }

        private void trkB_3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trkB_3.Value.ToString();
            if (Convert.ToInt32(label3.Text) <= Convert.ToInt32(txtB_min3.Text))
            {
                lbl_heiz.Text = "Es wird in Wohnung 3 geheizt";
            }
            if (Convert.ToInt32(label3.Text) >= Convert.ToInt32(txtB_max3.Text))
            {
                lbl_heiz.Text = "Heizung ist ausgeschalten";
            }
        }

    }
}
