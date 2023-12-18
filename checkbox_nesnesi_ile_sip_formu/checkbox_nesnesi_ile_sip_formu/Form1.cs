using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox_nesnesi_ile_sip_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        double tutar = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                tutar += 20; //tutar=tutar+20;
            else
                tutar -= 20;
            label5.Text = tutar.ToString();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                tutar += 6; //tutar=tutar+6;
            else
                tutar -= 6;
            label5.Text = tutar.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                tutar += 3; //tutar=tutar+3;
            else
                tutar -= 3;
            label5.Text = tutar.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                tutar += 4; //tutar=tutar+4;
            else
                tutar -= 4;
            label5.Text = tutar.ToString();
        }
    }
}
