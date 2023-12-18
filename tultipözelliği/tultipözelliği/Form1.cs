using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tultipözelliği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TOOLTİP1 ÖZELLİKLERİ
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = "Uyarı";
            toolTip1.AutomaticDelay = 200;
            toolTip1.AutoPopDelay = 3000;

            //TOOLTİP2 ÖZELLİKLERİ
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Bilgilendirme";
            toolTip2.AutomaticDelay = 200;
            toolTip2.AutoPopDelay = 3000;

            //TOOLTİP3 ÖZELLİKLERİ
            toolTip3.ToolTipIcon = ToolTipIcon.Error;
            toolTip3.ToolTipTitle = "Hata";
            toolTip3.AutomaticDelay = 200;
            toolTip3.AutoPopDelay = 3000;

            //kontrollerin ipucu metinleri

            toolTip1.SetToolTip(this.textBox2, "Öğrenci no 3 karakterden oluşmalıdır.");
            toolTip1.SetToolTip(this.textBox3, "TC kimlik no 11 karakterden oluşmalıdır.");
            toolTip2.SetToolTip(this.textBox4, "Güçlü şifre için harf, sayı ve özel karakter kullanınız.");
            toolTip3.SetToolTip(this.textBox1, "Şifre tekrarı ile yazılan şifre aynı olmalıdır.");
            textBox3.MaxLength = 11;

            //error provider 1 özellikleri
            errorProvider1.BlinkRate = 400;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 11)
                errorProvider1.SetError(textBox3, "TC Kimlik no 11 karakter olmalı");
            else
                errorProvider1.Clear();
        }
    }
}
