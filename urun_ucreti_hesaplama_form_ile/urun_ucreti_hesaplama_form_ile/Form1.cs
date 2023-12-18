using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urun_ucreti_hesaplama_form_ile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txturunfiyati.Text = "0";
            TXTurunadeti.Text = "1";
            radıobeyaz_esya.Checked = true;

        }

        private void txturunfiyati_TextChanged(object sender, EventArgs e)
        {
            double fiyat = 0, adet = 0, tutar = 0, kdv_orani = 0, kdv_tutari = 0, toplam = 0;
            try
            {
                fiyat = Convert.ToDouble(txturunfiyati.Text);
                adet = Convert.ToDouble(TXTurunadeti.Text);
            }
            catch{ }
            tutar = fiyat * adet;
            if (radıobeyaz_esya.Checked == true)
                kdv_orani = 0.25;
            else if (radiokirtasiye.Checked == true)
                kdv_orani = 0.18;
            else if (radiogida.Checked == true)
                kdv_orani = 0.8;
            kdv_tutari = tutar * kdv_orani;
            toplam = tutar + kdv_tutari;

            LBLTutar.Text = tutar.ToString();
            LBLKdv.Text = kdv_tutari.ToString();
            LBLToplam.Text=toplam.ToString();
            
        }


    }
}
