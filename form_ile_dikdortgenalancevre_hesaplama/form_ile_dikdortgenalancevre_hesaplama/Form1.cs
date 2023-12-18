using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ile_dikdortgenalancevre_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kenar1 = 0, kenar2 = 0, alan = 0, cevre = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kenar1 = Convert.ToDouble(textBox1.Text);
                kenar2 = Convert.ToDouble(textBox2.Text);
                alan=kenar1*kenar2;
                cevre = 2 * (kenar1 + kenar2);
                label5.Text = alan.ToString();
                label6.Text = cevre.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Veriler sayısal olmalı ve boş bırakılmamalıdır.");
            }
        }
    }
}
