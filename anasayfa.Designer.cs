namespace StokTakip
{
    partial class anasayfa
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.data_satislar = new System.Windows.Forms.DataGridView();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_satislar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ürün İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kasiyer İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(345, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stok İşlemleri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(443, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "Satış İşlemleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(541, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 65);
            this.button6.TabIndex = 5;
            this.button6.Text = "ÇIKIŞ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // data_satislar
            // 
            this.data_satislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_satislar.Location = new System.Drawing.Point(0, 253);
            this.data_satislar.Name = "data_satislar";
            this.data_satislar.Size = new System.Drawing.Size(748, 156);
            this.data_satislar.TabIndex = 6;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(660, 13);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(0, 13);
            this.lbl_isim.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(553, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(195, 65);
            this.button7.TabIndex = 9;
            this.button7.Text = "Satışları Göster";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 409);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.data_satislar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_satislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView data_satislar;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Button button7;
    }
}