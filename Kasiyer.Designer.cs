namespace StokTakip
{
    partial class Kasiyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.mask_bittarih = new System.Windows.Forms.MaskedTextBox();
            this.mask_tarih = new System.Windows.Forms.MaskedTextBox();
            this.mask_tc = new System.Windows.Forms.MaskedTextBox();
            this.mask_maas = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_kasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data_kasiyer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_kasiyer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mask_bittarih);
            this.panel1.Controls.Add(this.mask_tarih);
            this.panel1.Controls.Add(this.mask_tc);
            this.panel1.Controls.Add(this.mask_maas);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_kasa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_adi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_kaydet);
            this.panel1.Controls.Add(this.txt_adres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_soyad);
            this.panel1.Controls.Add(this.txt_tel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(55, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 290);
            this.panel1.TabIndex = 0;
            // 
            // mask_bittarih
            // 
            this.mask_bittarih.Location = new System.Drawing.Point(102, 238);
            this.mask_bittarih.Mask = "00/00/0000";
            this.mask_bittarih.Name = "mask_bittarih";
            this.mask_bittarih.Size = new System.Drawing.Size(103, 20);
            this.mask_bittarih.TabIndex = 37;
            this.mask_bittarih.ValidatingType = typeof(System.DateTime);
            // 
            // mask_tarih
            // 
            this.mask_tarih.Location = new System.Drawing.Point(105, 215);
            this.mask_tarih.Mask = "00/00/0000";
            this.mask_tarih.Name = "mask_tarih";
            this.mask_tarih.Size = new System.Drawing.Size(100, 20);
            this.mask_tarih.TabIndex = 36;
            this.mask_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // mask_tc
            // 
            this.mask_tc.Location = new System.Drawing.Point(102, 79);
            this.mask_tc.Mask = "00000000000000";
            this.mask_tc.Name = "mask_tc";
            this.mask_tc.Size = new System.Drawing.Size(100, 20);
            this.mask_tc.TabIndex = 35;
            // 
            // mask_maas
            // 
            this.mask_maas.Location = new System.Drawing.Point(105, 164);
            this.mask_maas.Mask = "00000";
            this.mask_maas.Name = "mask_maas";
            this.mask_maas.Size = new System.Drawing.Size(100, 20);
            this.mask_maas.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Görev Bit. Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Görev Baş. Tarihi";
            // 
            // txt_kasa
            // 
            this.txt_kasa.Location = new System.Drawing.Point(102, 190);
            this.txt_kasa.Name = "txt_kasa";
            this.txt_kasa.Size = new System.Drawing.Size(121, 20);
            this.txt_kasa.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Görevli old. Kasa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Maaş:";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(102, 15);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(121, 20);
            this.txt_adi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adres";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(87, 263);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(98, 23);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(102, 134);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(121, 20);
            this.txt_adres.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = " Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefon:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(102, 41);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(121, 20);
            this.txt_soyad.TabIndex = 18;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(102, 108);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(121, 20);
            this.txt_tel.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tc Kimlik";
            // 
            // data_kasiyer
            // 
            this.data_kasiyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_kasiyer.Location = new System.Drawing.Point(-4, 308);
            this.data_kasiyer.Name = "data_kasiyer";
            this.data_kasiyer.Size = new System.Drawing.Size(826, 225);
            this.data_kasiyer.TabIndex = 1;
            this.data_kasiyer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_kasiyer_CellEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(735, 285);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Verileri Gör";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 22);
            this.button4.TabIndex = 21;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 533);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_kasiyer);
            this.Controls.Add(this.panel1);
            this.Name = "Kasiyer";
            this.Text = "Kasiyer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_kasiyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.DataGridView data_kasiyer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_kasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mask_bittarih;
        private System.Windows.Forms.MaskedTextBox mask_tarih;
        private System.Windows.Forms.MaskedTextBox mask_tc;
        private System.Windows.Forms.MaskedTextBox mask_maas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
    }
}