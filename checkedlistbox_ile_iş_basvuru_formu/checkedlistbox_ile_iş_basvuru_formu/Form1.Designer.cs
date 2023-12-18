namespace checkedlistbox_ile_iş_basvuru_formu
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
            this.txtadisoyadi = new System.Windows.Forms.TextBox();
            this.buttondilekle = new System.Windows.Forms.RadioButton();
            this.buttondilsil = new System.Windows.Forms.RadioButton();
            this.buttonsecimlerikaldır = new System.Windows.Forms.RadioButton();
            this.txtyenidil = new System.Windows.Forms.TextBox();
            this.radioilkogretim = new System.Windows.Forms.RadioButton();
            this.radioortaogretim = new System.Windows.Forms.RadioButton();
            this.radiolisans = new System.Windows.Forms.RadioButton();
            this.radioyükseklisans = new System.Windows.Forms.RadioButton();
            this.radiokaydet = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbladisoyadi = new System.Windows.Forms.Label();
            this.lbldiller = new System.Windows.Forms.Label();
            this.lblmezuniyet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yabancı Diller";
            // 
            // txtadisoyadi
            // 
            this.txtadisoyadi.Location = new System.Drawing.Point(125, 14);
            this.txtadisoyadi.Name = "txtadisoyadi";
            this.txtadisoyadi.Size = new System.Drawing.Size(236, 30);
            this.txtadisoyadi.TabIndex = 2;
            // 
            // buttondilekle
            // 
            this.buttondilekle.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttondilekle.AutoSize = true;
            this.buttondilekle.Location = new System.Drawing.Point(229, 325);
            this.buttondilekle.Name = "buttondilekle";
            this.buttondilekle.Size = new System.Drawing.Size(131, 35);
            this.buttondilekle.TabIndex = 3;
            this.buttondilekle.TabStop = true;
            this.buttondilekle.Text = "Yeni Dil Ekle";
            this.buttondilekle.UseVisualStyleBackColor = true;
            this.buttondilekle.CheckedChanged += new System.EventHandler(this.buttondilekle_CheckedChanged);
            // 
            // buttondilsil
            // 
            this.buttondilsil.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttondilsil.AutoSize = true;
            this.buttondilsil.Location = new System.Drawing.Point(17, 384);
            this.buttondilsil.Name = "buttondilsil";
            this.buttondilsil.Size = new System.Drawing.Size(127, 35);
            this.buttondilsil.TabIndex = 4;
            this.buttondilsil.TabStop = true;
            this.buttondilsil.Text = "Seçili Dili Sil";
            this.buttondilsil.UseVisualStyleBackColor = true;
            this.buttondilsil.CheckedChanged += new System.EventHandler(this.buttondilsil_CheckedChanged);
            // 
            // buttonsecimlerikaldır
            // 
            this.buttonsecimlerikaldır.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonsecimlerikaldır.AutoSize = true;
            this.buttonsecimlerikaldır.Location = new System.Drawing.Point(229, 384);
            this.buttonsecimlerikaldır.Name = "buttonsecimlerikaldır";
            this.buttonsecimlerikaldır.Size = new System.Drawing.Size(157, 35);
            this.buttonsecimlerikaldır.TabIndex = 5;
            this.buttonsecimlerikaldır.TabStop = true;
            this.buttonsecimlerikaldır.Text = "Seçimleri Kaldır";
            this.buttonsecimlerikaldır.UseVisualStyleBackColor = true;
            this.buttonsecimlerikaldır.CheckedChanged += new System.EventHandler(this.buttonsecimlerikaldır_CheckedChanged);
            // 
            // txtyenidil
            // 
            this.txtyenidil.Location = new System.Drawing.Point(17, 327);
            this.txtyenidil.Name = "txtyenidil";
            this.txtyenidil.Size = new System.Drawing.Size(132, 30);
            this.txtyenidil.TabIndex = 6;
            this.txtyenidil.TextChanged += new System.EventHandler(this.txtyenidil_TextChanged);
            // 
            // radioilkogretim
            // 
            this.radioilkogretim.AutoSize = true;
            this.radioilkogretim.Location = new System.Drawing.Point(6, 29);
            this.radioilkogretim.Name = "radioilkogretim";
            this.radioilkogretim.Size = new System.Drawing.Size(116, 29);
            this.radioilkogretim.TabIndex = 7;
            this.radioilkogretim.TabStop = true;
            this.radioilkogretim.Text = "İlköğretim";
            this.radioilkogretim.UseVisualStyleBackColor = true;
            // 
            // radioortaogretim
            // 
            this.radioortaogretim.AutoSize = true;
            this.radioortaogretim.Location = new System.Drawing.Point(211, 27);
            this.radioortaogretim.Name = "radioortaogretim";
            this.radioortaogretim.Size = new System.Drawing.Size(135, 29);
            this.radioortaogretim.TabIndex = 8;
            this.radioortaogretim.TabStop = true;
            this.radioortaogretim.Text = "Ortaöğretim";
            this.radioortaogretim.UseVisualStyleBackColor = true;
            // 
            // radiolisans
            // 
            this.radiolisans.AutoSize = true;
            this.radiolisans.Location = new System.Drawing.Point(6, 64);
            this.radiolisans.Name = "radiolisans";
            this.radiolisans.Size = new System.Drawing.Size(90, 29);
            this.radiolisans.TabIndex = 9;
            this.radiolisans.TabStop = true;
            this.radiolisans.Text = "Lisans";
            this.radiolisans.UseVisualStyleBackColor = true;
            // 
            // radioyükseklisans
            // 
            this.radioyükseklisans.AutoSize = true;
            this.radioyükseklisans.Location = new System.Drawing.Point(211, 62);
            this.radioyükseklisans.Name = "radioyükseklisans";
            this.radioyükseklisans.Size = new System.Drawing.Size(148, 29);
            this.radioyükseklisans.TabIndex = 10;
            this.radioyükseklisans.TabStop = true;
            this.radioyükseklisans.Text = "Yükseklisans";
            this.radioyükseklisans.UseVisualStyleBackColor = true;
            // 
            // radiokaydet
            // 
            this.radiokaydet.Appearance = System.Windows.Forms.Appearance.Button;
            this.radiokaydet.AutoSize = true;
            this.radiokaydet.Location = new System.Drawing.Point(634, 132);
            this.radiokaydet.Name = "radiokaydet";
            this.radiokaydet.Size = new System.Drawing.Size(84, 35);
            this.radiokaydet.TabIndex = 11;
            this.radiokaydet.TabStop = true;
            this.radiokaydet.Text = "Kaydet";
            this.radiokaydet.UseVisualStyleBackColor = true;
            this.radiokaydet.CheckedChanged += new System.EventHandler(this.radiokaydet_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adı Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Diller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mezuniyeti";
            // 
            // lbladisoyadi
            // 
            this.lbladisoyadi.AutoSize = true;
            this.lbladisoyadi.Location = new System.Drawing.Point(142, 40);
            this.lbladisoyadi.Name = "lbladisoyadi";
            this.lbladisoyadi.Size = new System.Drawing.Size(210, 25);
            this.lbladisoyadi.TabIndex = 15;
            this.lbladisoyadi.Text = "__________________";
            // 
            // lbldiller
            // 
            this.lbldiller.AutoSize = true;
            this.lbldiller.Location = new System.Drawing.Point(142, 89);
            this.lbldiller.Name = "lbldiller";
            this.lbldiller.Size = new System.Drawing.Size(210, 25);
            this.lbldiller.TabIndex = 16;
            this.lbldiller.Text = "__________________";
            // 
            // lblmezuniyet
            // 
            this.lblmezuniyet.AutoSize = true;
            this.lblmezuniyet.Location = new System.Drawing.Point(142, 145);
            this.lblmezuniyet.Name = "lblmezuniyet";
            this.lblmezuniyet.Size = new System.Drawing.Size(210, 25);
            this.lblmezuniyet.TabIndex = 17;
            this.lblmezuniyet.Text = "__________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioilkogretim);
            this.groupBox1.Controls.Add(this.radioortaogretim);
            this.groupBox1.Controls.Add(this.radiolisans);
            this.groupBox1.Controls.Add(this.radioyükseklisans);
            this.groupBox1.Location = new System.Drawing.Point(384, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 114);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mezuniyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblmezuniyet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbldiller);
            this.groupBox2.Controls.Add(this.lbladisoyadi);
            this.groupBox2.Location = new System.Drawing.Point(566, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 247);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Bilgileri";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 100);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(349, 204);
            this.checkedListBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 480);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radiokaydet);
            this.Controls.Add(this.txtyenidil);
            this.Controls.Add(this.buttonsecimlerikaldır);
            this.Controls.Add(this.buttondilsil);
            this.Controls.Add(this.buttondilekle);
            this.Controls.Add(this.txtadisoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "İş Başvuru Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadisoyadi;
        private System.Windows.Forms.RadioButton buttondilekle;
        private System.Windows.Forms.RadioButton buttondilsil;
        private System.Windows.Forms.RadioButton buttonsecimlerikaldır;
        private System.Windows.Forms.TextBox txtyenidil;
        private System.Windows.Forms.RadioButton radioilkogretim;
        private System.Windows.Forms.RadioButton radioortaogretim;
        private System.Windows.Forms.RadioButton radiolisans;
        private System.Windows.Forms.RadioButton radioyükseklisans;
        private System.Windows.Forms.RadioButton radiokaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbladisoyadi;
        private System.Windows.Forms.Label lbldiller;
        private System.Windows.Forms.Label lblmezuniyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

