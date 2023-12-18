using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ile_sinema_bileti_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXTBiletfiyati.Text = "0";
            RADIONormal.Checked = true;
        }

        private void TXTBiletfiyati_TextChanged(object sender, EventArgs e)
        {
            double bilet_fiyati = 0, kdv_tutari = 0, toplam_tutar = 0, odenecek_tutar = 0;
            if (TXTBiletfiyati.Text == "")
            {
                LBLKDVtutari.Text = "0";
                LBLToplamtutar.Text = "0";
                LBLOdenecektutar.Text = "0";
            }
            try
            {
                bilet_fiyati = Convert.ToDouble(TXTBiletfiyati.Text);
            }
            catch {;}
            kdv_tutari = bilet_fiyati * 0.18;
            toplam_tutar = bilet_fiyati + kdv_tutari;
            odenecek_tutar = toplam_tutar;
            if (RADIONormal.Checked == true)
                odenecek_tutar = toplam_tutar;
            else if (RADIOOgrenci.Checked == true)
                odenecek_tutar = toplam_tutar * 0.5;
            else if (RADIOOgretmen.Checked == true)
                odenecek_tutar = toplam_tutar * 0.9;
            else if (RADIOSaglıkcı.Checked == true)
                odenecek_tutar = toplam_tutar * 0.6;
            LBLKDVtutari.Text=kdv_tutari.ToString();
            LBLToplamtutar.Text=toplam_tutar.ToString();
            LBLOdenecektutar.Text = odenecek_tutar.ToString();

        }
    }
}
