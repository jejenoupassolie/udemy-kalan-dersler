using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboboksörneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] iller = { "Kastamonu", "Mersin", "Bursa" };
            comboBoxil.Items.AddRange(iller);
        }

        private void comboBoxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Kastamonu = { "Merkez", "Devrekani", "İnebolu", "Bozkurt" };
            string[] Mersin = { "Merkez", "Tarsus", "Silifke", "Anamur" };
            string[] Bursa = { "Merkez", "İnegöl", "Gemlik", "Mudanya" };

            comboBoxilce.Items.Clear();
            if (comboBoxil.Text == "Kastamonu")
                comboBoxilce.Items.AddRange(Kastamonu);
            else if (comboBoxil.Text == "Mersin")
                comboBoxilce.Items.AddRange(Mersin);
            else if (comboBoxil.Text == "Bursa")
                comboBoxilce.Items.AddRange(Bursa);

        }

        private void RADIOKaydet_CheckedChanged(object sender, EventArgs e)
        {
            LBLAdisoyadi.Text=txtadisoyadi.Text;
            LBLNufuskaydi.Text=comboBoxil.Text+ "/" +comboBoxilce.Text;
        }
    }
}
