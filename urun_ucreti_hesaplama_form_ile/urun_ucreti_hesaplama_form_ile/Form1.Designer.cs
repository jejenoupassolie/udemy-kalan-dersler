namespace urun_ucreti_hesaplama_form_ile
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radıobeyaz_esya = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBLTutar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLKdv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLToplam = new System.Windows.Forms.Label();
            this.txturunfiyati = new System.Windows.Forms.TextBox();
            this.TXTurunadeti = new System.Windows.Forms.TextBox();
            this.radiokirtasiye = new System.Windows.Forms.RadioButton();
            this.radiogida = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // radıobeyaz_esya
            // 
            this.radıobeyaz_esya.AutoSize = true;
            this.radıobeyaz_esya.Location = new System.Drawing.Point(9, 20);
            this.radıobeyaz_esya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radıobeyaz_esya.Name = "radıobeyaz_esya";
            this.radıobeyaz_esya.Size = new System.Drawing.Size(179, 24);
            this.radıobeyaz_esya.TabIndex = 1;
            this.radıobeyaz_esya.TabStop = true;
            this.radıobeyaz_esya.Text = "Beyaz Eşya(%25)";
            this.radıobeyaz_esya.UseVisualStyleBackColor = true;
            this.radıobeyaz_esya.CheckedChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            this.radıobeyaz_esya.TextChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiogida);
            this.groupBox1.Controls.Add(this.radiokirtasiye);
            this.groupBox1.Controls.Add(this.radıobeyaz_esya);
            this.groupBox1.Location = new System.Drawing.Point(277, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(194, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tutar";
            // 
            // LBLTutar
            // 
            this.LBLTutar.AutoSize = true;
            this.LBLTutar.Location = new System.Drawing.Point(102, 210);
            this.LBLTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTutar.Name = "LBLTutar";
            this.LBLTutar.Size = new System.Drawing.Size(59, 20);
            this.LBLTutar.TabIndex = 7;
            this.LBLTutar.Text = "_____";
            this.LBLTutar.Click += new System.EventHandler(this.Form1_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "KDV";
            // 
            // LBLKdv
            // 
            this.LBLKdv.AutoSize = true;
            this.LBLKdv.Location = new System.Drawing.Point(288, 210);
            this.LBLKdv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLKdv.Name = "LBLKdv";
            this.LBLKdv.Size = new System.Drawing.Size(59, 20);
            this.LBLKdv.TabIndex = 9;
            this.LBLKdv.Text = "_____";
            this.LBLKdv.Click += new System.EventHandler(this.txturunfiyati_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam";
            // 
            // LBLToplam
            // 
            this.LBLToplam.AutoSize = true;
            this.LBLToplam.Location = new System.Drawing.Point(473, 210);
            this.LBLToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLToplam.Name = "LBLToplam";
            this.LBLToplam.Size = new System.Drawing.Size(59, 20);
            this.LBLToplam.TabIndex = 11;
            this.LBLToplam.Text = "_____";
            this.LBLToplam.Click += new System.EventHandler(this.txturunfiyati_TextChanged);
            // 
            // txturunfiyati
            // 
            this.txturunfiyati.Location = new System.Drawing.Point(109, 82);
            this.txturunfiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txturunfiyati.Name = "txturunfiyati";
            this.txturunfiyati.Size = new System.Drawing.Size(136, 26);
            this.txturunfiyati.TabIndex = 12;
            this.txturunfiyati.TextChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            // 
            // TXTurunadeti
            // 
            this.TXTurunadeti.Location = new System.Drawing.Point(109, 118);
            this.TXTurunadeti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXTurunadeti.Name = "TXTurunadeti";
            this.TXTurunadeti.Size = new System.Drawing.Size(136, 26);
            this.TXTurunadeti.TabIndex = 13;
            this.TXTurunadeti.TextChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            // 
            // radiokirtasiye
            // 
            this.radiokirtasiye.AutoSize = true;
            this.radiokirtasiye.Location = new System.Drawing.Point(9, 64);
            this.radiokirtasiye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiokirtasiye.Name = "radiokirtasiye";
            this.radiokirtasiye.Size = new System.Drawing.Size(154, 24);
            this.radiokirtasiye.TabIndex = 14;
            this.radiokirtasiye.TabStop = true;
            this.radiokirtasiye.Text = "Kırtasiye(%18)";
            this.radiokirtasiye.UseVisualStyleBackColor = true;
            this.radiokirtasiye.CheckedChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            this.radiokirtasiye.TextChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            // 
            // radiogida
            // 
            this.radiogida.AutoSize = true;
            this.radiogida.Location = new System.Drawing.Point(9, 109);
            this.radiogida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiogida.Name = "radiogida";
            this.radiogida.Size = new System.Drawing.Size(109, 24);
            this.radiogida.TabIndex = 15;
            this.radiogida.TabStop = true;
            this.radiogida.Text = "Gıda(%8)";
            this.radiogida.UseVisualStyleBackColor = true;
            this.radiogida.CheckedChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            this.radiogida.TextChanged += new System.EventHandler(this.txturunfiyati_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 322);
            this.Controls.Add(this.TXTurunadeti);
            this.Controls.Add(this.txturunfiyati);
            this.Controls.Add(this.LBLToplam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBLKdv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBLTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radıobeyaz_esya;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiogida;
        private System.Windows.Forms.RadioButton radiokirtasiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBLTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBLKdv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBLToplam;
        private System.Windows.Forms.TextBox txturunfiyati;
        private System.Windows.Forms.TextBox TXTurunadeti;
    }
}

