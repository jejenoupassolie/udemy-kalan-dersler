using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesiformile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1, sayi2, sonuc;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hoşgeldiniz...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sonuc = sayi1 + sayi2;
                sonuc = Math.Round(sonuc, 2);
                label4.Text = sonuc.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("veriler sayısal olmalı ve boş bırakılmamalıdır!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sonuc = sayi1 - sayi2;
                sonuc = Math.Round(sonuc, 2);
                label4.Text = sonuc.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("veriler sayısal olmalı ve boş bırakılmamalıdır!");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sonuc = sayi1 * sayi2;
                sonuc = Math.Round(sonuc, 2);
                label4.Text = sonuc.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("veriler sayısal olmalı ve boş bırakılmamalıdır!");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
                sonuc = sayi1 / sayi2;
                sonuc = Math.Round(sonuc, 2);
                label4.Text = sonuc.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("veriler sayısal olmalı ve boş bırakılmamalıdır!");
            }
            

        }
        
    }
}
