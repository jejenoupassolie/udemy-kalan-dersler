using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton_listbox_ve_panel_kullanımı
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
        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad = "", medenihal = "", cinsiyeti = "";
            adsoyad = textBox1.Text;
            if (radioButton1.Checked == true)
                cinsiyeti = "Erkek";
            else if (radioButton2.Checked == true)
                cinsiyeti = "Kadın";
            if(radioButton3.Checked == true)
                medenihal=radioButton3.Text;
            else if(radioButton4.Checked == true)
                medenihal=radioButton4.Text;
            listBox1.Items.Add("Adı Soyadı:" + adsoyad + "Cinsiyeti:" + cinsiyeti + "Medeni Hali:" + medenihal);
        }

    }
}
