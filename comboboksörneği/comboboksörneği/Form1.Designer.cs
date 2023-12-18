namespace comboboksörneği
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
            this.LBLAdisoyadi = new System.Windows.Forms.Label();
            this.LBLNufuskaydi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtadisoyadi = new System.Windows.Forms.TextBox();
            this.RADIOKaydet = new System.Windows.Forms.RadioButton();
            this.comboBoxilce = new System.Windows.Forms.ComboBox();
            this.comboBoxil = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "İl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adı Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nüfus Kaydı";
            // 
            // LBLAdisoyadi
            // 
            this.LBLAdisoyadi.AutoSize = true;
            this.LBLAdisoyadi.Location = new System.Drawing.Point(152, 45);
            this.LBLAdisoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLAdisoyadi.Name = "LBLAdisoyadi";
            this.LBLAdisoyadi.Size = new System.Drawing.Size(188, 25);
            this.LBLAdisoyadi.TabIndex = 5;
            this.LBLAdisoyadi.Text = "________________";
            // 
            // LBLNufuskaydi
            // 
            this.LBLNufuskaydi.AutoSize = true;
            this.LBLNufuskaydi.Location = new System.Drawing.Point(152, 110);
            this.LBLNufuskaydi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLNufuskaydi.Name = "LBLNufuskaydi";
            this.LBLNufuskaydi.Size = new System.Drawing.Size(188, 25);
            this.LBLNufuskaydi.TabIndex = 6;
            this.LBLNufuskaydi.Text = "________________";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxilce);
            this.groupBox1.Controls.Add(this.comboBoxil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(376, 156);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nüfusa Kayıtlı Olduğu Yer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBLNufuskaydi);
            this.groupBox2.Controls.Add(this.LBLAdisoyadi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(43, 364);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(365, 156);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kimlik Bilgileri";
            // 
            // txtadisoyadi
            // 
            this.txtadisoyadi.Location = new System.Drawing.Point(142, 26);
            this.txtadisoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadisoyadi.Name = "txtadisoyadi";
            this.txtadisoyadi.Size = new System.Drawing.Size(266, 30);
            this.txtadisoyadi.TabIndex = 0;
            // 
            // RADIOKaydet
            // 
            this.RADIOKaydet.Appearance = System.Windows.Forms.Appearance.Button;
            this.RADIOKaydet.AutoSize = true;
            this.RADIOKaydet.Location = new System.Drawing.Point(324, 266);
            this.RADIOKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RADIOKaydet.Name = "RADIOKaydet";
            this.RADIOKaydet.Size = new System.Drawing.Size(84, 35);
            this.RADIOKaydet.TabIndex = 1;
            this.RADIOKaydet.TabStop = true;
            this.RADIOKaydet.Text = "Kaydet";
            this.RADIOKaydet.UseVisualStyleBackColor = true;
            this.RADIOKaydet.CheckedChanged += new System.EventHandler(this.RADIOKaydet_CheckedChanged);
            // 
            // comboBoxilce
            // 
            this.comboBoxilce.FormattingEnabled = true;
            this.comboBoxilce.Location = new System.Drawing.Point(144, 92);
            this.comboBoxilce.Name = "comboBoxilce";
            this.comboBoxilce.Size = new System.Drawing.Size(198, 33);
            this.comboBoxilce.TabIndex = 8;
            // 
            // comboBoxil
            // 
            this.comboBoxil.FormattingEnabled = true;
            this.comboBoxil.Location = new System.Drawing.Point(144, 38);
            this.comboBoxil.Name = "comboBoxil";
            this.comboBoxil.Size = new System.Drawing.Size(198, 33);
            this.comboBoxil.TabIndex = 9;
            this.comboBoxil.SelectedIndexChanged += new System.EventHandler(this.comboBoxil_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 567);
            this.Controls.Add(this.RADIOKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtadisoyadi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLAdisoyadi;
        private System.Windows.Forms.Label LBLNufuskaydi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtadisoyadi;
        private System.Windows.Forms.RadioButton RADIOKaydet;
        private System.Windows.Forms.ComboBox comboBoxilce;
        private System.Windows.Forms.ComboBox comboBoxil;
    }
}

