using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkedlistbox_ile_iş_basvuru_formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] diller = new string []{ "Türkçe", "İngilizce", "Almanca", "Arapça", "Azerice", "Fransızca", "Çince", "Osmanlıca", "İtalyanca","portekizce" };
            checkedListBox1.Items.AddRange(diller);  //Sets up the initial objects in the CheckedListBox;
            checkedListBox1.MultiColumn = true; //multicolumn=çok sütunlu;
            checkedListBox1.CheckOnClick= true; //Specifies that the check box does not open with a single click when an item is selected. 
            buttondilekle.Enabled = false;


        }

        private void txtyenidil_TextChanged(object sender, EventArgs e)
        {
            if(txtyenidil.Text =="")
                buttondilekle.Enabled=false;
            else
                buttondilekle.Enabled=true;
        }
        private void buttondilekle_CheckedChanged(object sender, EventArgs e)
        {
            if (txtyenidil.Text != "")
                if (checkedListBox1.Items.Contains(txtyenidil.Text) == false) //contains=içeriyor;
                    checkedListBox1.Items.Add(txtyenidil.Text);
                else
                    MessageBox.Show("Belirtilen dil zaten yüklüdür");
            txtyenidil.Text = "";

        }

        private void buttondilsil_CheckedChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void buttonsecimlerikaldır_CheckedChanged(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count > 0)
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);

        }

        private void radiokaydet_CheckedChanged(object sender, EventArgs e)
        {
            lbladisoyadi.Text = txtadisoyadi.Text;
            string diller = "", mezuniyeti = "";
            for(int i=0;i<checkedListBox1.CheckedItems.Count;i++)
            {
                diller += ", " + checkedListBox1.CheckedItems[i];
            }
            diller = diller.Substring(2);
            lbldiller.Text = diller;
            if (radioilkogretim.Checked == true)
                mezuniyeti = radioilkogretim.Text;
            else if (radioortaogretim.Checked == true)
                mezuniyeti = radioortaogretim.Text;
            else if (radiolisans.Checked == true)
                mezuniyeti = radiolisans.Text;
            else if (radioyükseklisans.Checked == true)
                mezuniyeti = radioyükseklisans.Text;
            lblmezuniyet.Text = mezuniyeti;
            txtadisoyadi.Text = ""; txtyenidil.Text= "";

        }
    }
}
