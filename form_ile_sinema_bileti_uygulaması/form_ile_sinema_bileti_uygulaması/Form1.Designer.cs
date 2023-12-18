namespace form_ile_sinema_bileti_uygulaması
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLKDVtutari = new System.Windows.Forms.Label();
            this.LBLToplamtutar = new System.Windows.Forms.Label();
            this.LBLOdenecektutar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TXTBiletfiyati = new System.Windows.Forms.TextBox();
            this.RADIONormal = new System.Windows.Forms.RadioButton();
            this.RADIOOgrenci = new System.Windows.Forms.RadioButton();
            this.RADIOSaglıkcı = new System.Windows.Forms.RadioButton();
            this.RADIOOgretmen = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilet Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "KDV Tutarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödenecek Tutar";
            // 
            // LBLKDVtutari
            // 
            this.LBLKDVtutari.AutoSize = true;
            this.LBLKDVtutari.Location = new System.Drawing.Point(173, 202);
            this.LBLKDVtutari.Name = "LBLKDVtutari";
            this.LBLKDVtutari.Size = new System.Drawing.Size(79, 20);
            this.LBLKDVtutari.TabIndex = 5;
            this.LBLKDVtutari.Text = "_______";
            // 
            // LBLToplamtutar
            // 
            this.LBLToplamtutar.AutoSize = true;
            this.LBLToplamtutar.Location = new System.Drawing.Point(173, 242);
            this.LBLToplamtutar.Name = "LBLToplamtutar";
            this.LBLToplamtutar.Size = new System.Drawing.Size(79, 20);
            this.LBLToplamtutar.TabIndex = 6;
            this.LBLToplamtutar.Text = "_______";
            // 
            // LBLOdenecektutar
            // 
            this.LBLOdenecektutar.AutoSize = true;
            this.LBLOdenecektutar.Location = new System.Drawing.Point(173, 286);
            this.LBLOdenecektutar.Name = "LBLOdenecektutar";
            this.LBLOdenecektutar.Size = new System.Drawing.Size(79, 20);
            this.LBLOdenecektutar.TabIndex = 7;
            this.LBLOdenecektutar.Text = "_______";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 8;
            // 
            // TXTBiletfiyati
            // 
            this.TXTBiletfiyati.Location = new System.Drawing.Point(126, 86);
            this.TXTBiletfiyati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTBiletfiyati.Name = "TXTBiletfiyati";
            this.TXTBiletfiyati.Size = new System.Drawing.Size(136, 26);
            this.TXTBiletfiyati.TabIndex = 9;
            this.TXTBiletfiyati.TextChanged += new System.EventHandler(this.TXTBiletfiyati_TextChanged);
            // 
            // RADIONormal
            // 
            this.RADIONormal.AutoSize = true;
            this.RADIONormal.Location = new System.Drawing.Point(30, 47);
            this.RADIONormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIONormal.Name = "RADIONormal";
            this.RADIONormal.Size = new System.Drawing.Size(90, 24);
            this.RADIONormal.TabIndex = 10;
            this.RADIONormal.TabStop = true;
            this.RADIONormal.Text = "Normal";
            this.RADIONormal.UseVisualStyleBackColor = true;
            this.RADIONormal.CheckedChanged += new System.EventHandler(this.TXTBiletfiyati_TextChanged);
            // 
            // RADIOOgrenci
            // 
            this.RADIOOgrenci.AutoSize = true;
            this.RADIOOgrenci.Location = new System.Drawing.Point(30, 95);
            this.RADIOOgrenci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIOOgrenci.Name = "RADIOOgrenci";
            this.RADIOOgrenci.Size = new System.Drawing.Size(96, 24);
            this.RADIOOgrenci.TabIndex = 11;
            this.RADIOOgrenci.TabStop = true;
            this.RADIOOgrenci.Text = "Öğrenci";
            this.RADIOOgrenci.UseVisualStyleBackColor = true;
            this.RADIOOgrenci.CheckedChanged += new System.EventHandler(this.TXTBiletfiyati_TextChanged);
            // 
            // RADIOSaglıkcı
            // 
            this.RADIOSaglıkcı.AutoSize = true;
            this.RADIOSaglıkcı.Location = new System.Drawing.Point(30, 142);
            this.RADIOSaglıkcı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIOSaglıkcı.Name = "RADIOSaglıkcı";
            this.RADIOSaglıkcı.Size = new System.Drawing.Size(96, 24);
            this.RADIOSaglıkcı.TabIndex = 12;
            this.RADIOSaglıkcı.TabStop = true;
            this.RADIOSaglıkcı.Text = "Sağlıkçı";
            this.RADIOSaglıkcı.UseVisualStyleBackColor = true;
            this.RADIOSaglıkcı.CheckedChanged += new System.EventHandler(this.TXTBiletfiyati_TextChanged);
            // 
            // RADIOOgretmen
            // 
            this.RADIOOgretmen.AutoSize = true;
            this.RADIOOgretmen.Location = new System.Drawing.Point(30, 191);
            this.RADIOOgretmen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RADIOOgretmen.Name = "RADIOOgretmen";
            this.RADIOOgretmen.Size = new System.Drawing.Size(112, 24);
            this.RADIOOgretmen.TabIndex = 13;
            this.RADIOOgretmen.TabStop = true;
            this.RADIOOgretmen.Text = "Öğretmen";
            this.RADIOOgretmen.UseVisualStyleBackColor = true;
            this.RADIOOgretmen.CheckedChanged += new System.EventHandler(this.TXTBiletfiyati_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RADIONormal);
            this.groupBox1.Controls.Add(this.RADIOOgretmen);
            this.groupBox1.Controls.Add(this.RADIOOgrenci);
            this.groupBox1.Controls.Add(this.RADIOSaglıkcı);
            this.groupBox1.Location = new System.Drawing.Point(284, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(205, 223);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Türü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXTBiletfiyati);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LBLOdenecektutar);
            this.Controls.Add(this.LBLToplamtutar);
            this.Controls.Add(this.LBLKDVtutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "sinema bileti uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLKDVtutari;
        private System.Windows.Forms.Label LBLToplamtutar;
        private System.Windows.Forms.Label LBLOdenecektutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TXTBiletfiyati;
        private System.Windows.Forms.RadioButton RADIONormal;
        private System.Windows.Forms.RadioButton RADIOOgrenci;
        private System.Windows.Forms.RadioButton RADIOSaglıkcı;
        private System.Windows.Forms.RadioButton RADIOOgretmen;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

