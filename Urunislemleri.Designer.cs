namespace StokTakip
{
    partial class Urunislemleri
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
            this.txt_urunadi = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_urunkodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_alısfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_satısfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_firmaadi = new System.Windows.Forms.ComboBox();
            this.cmb_kategori = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_urunadi
            // 
            this.txt_urunadi.Location = new System.Drawing.Point(178, 56);
            this.txt_urunadi.Name = "txt_urunadi";
            this.txt_urunadi.Size = new System.Drawing.Size(121, 20);
            this.txt_urunadi.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(167, 238);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Kodu:";
            // 
            // txt_urunkodu
            // 
            this.txt_urunkodu.Location = new System.Drawing.Point(178, 92);
            this.txt_urunkodu.Name = "txt_urunkodu";
            this.txt_urunkodu.Size = new System.Drawing.Size(121, 20);
            this.txt_urunkodu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Firma Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alış Fiyatı:";
            // 
            // txt_alısfiyat
            // 
            this.txt_alısfiyat.Location = new System.Drawing.Point(178, 156);
            this.txt_alısfiyat.Name = "txt_alısfiyat";
            this.txt_alısfiyat.Size = new System.Drawing.Size(121, 20);
            this.txt_alısfiyat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // txt_satısfiyat
            // 
            this.txt_satısfiyat.Location = new System.Drawing.Point(178, 182);
            this.txt_satısfiyat.Name = "txt_satısfiyat";
            this.txt_satısfiyat.Size = new System.Drawing.Size(121, 20);
            this.txt_satısfiyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kategori";
            // 
            // cmb_firmaadi
            // 
            this.cmb_firmaadi.FormattingEnabled = true;
            this.cmb_firmaadi.Items.AddRange(new object[] {
            "S",
            "E"});
            this.cmb_firmaadi.Location = new System.Drawing.Point(178, 119);
            this.cmb_firmaadi.Name = "cmb_firmaadi";
            this.cmb_firmaadi.Size = new System.Drawing.Size(121, 21);
            this.cmb_firmaadi.TabIndex = 13;
            // 
            // cmb_kategori
            // 
            this.cmb_kategori.FormattingEnabled = true;
            this.cmb_kategori.Items.AddRange(new object[] {
            "s",
            "E"});
            this.cmb_kategori.Location = new System.Drawing.Point(178, 209);
            this.cmb_kategori.Name = "cmb_kategori";
            this.cmb_kategori.Size = new System.Drawing.Size(121, 21);
            this.cmb_kategori.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(475, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 107);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yeni Firma Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(475, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 107);
            this.panel2.TabIndex = 18;
            this.panel2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Yeni Kategori Adı:";
            // 
            // Urunislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_kategori);
            this.Controls.Add(this.cmb_firmaadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_urunadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_satısfiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_urunkodu);
            this.Controls.Add(this.txt_alısfiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Urunislemleri";
            this.Text = "Urunislemleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_satısfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_alısfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_urunkodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.ComboBox cmb_kategori;
        private System.Windows.Forms.ComboBox cmb_firmaadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
    }
}