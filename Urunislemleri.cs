using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakip
{
    public partial class Urunislemleri : Form
    {
        public Urunislemleri()
        {
            InitializeComponent();
        }      
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("Insert Into Urunislemleri(urunadi,urunkodu,firmaadi,alısfiyati,satısfiyati,kategori)values(@p1,@p2,@p3,@p4,@p5,@p6)", con))
                {
                    cmd.Parameters.AddWithValue("@p1", txt_urunadi.Text);
                    cmd.Parameters.AddWithValue("@p2", txt_urunkodu.Text);
                    cmd.Parameters.AddWithValue("@p3", cmb_firmaadi.SelectedItem);
                    cmd.Parameters.AddWithValue("@p4", txt_alısfiyat.Text);
                    cmd.Parameters.AddWithValue("@p5", txt_satısfiyat.Text);
                    cmd.Parameters.AddWithValue("@p6", cmb_kategori.SelectedItem);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eklendi");                                                  
                    }
                    catch (Exception h )
                    {
                        MessageBox.Show("Allah İle Alakalı Olay Bizimle Değil" +h.Message);                     
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string yeniVeri = textBox1.Text;           
            if (!string.IsNullOrEmpty(yeniVeri) && !cmb_firmaadi.Items.Contains(yeniVeri))
            {
                cmb_firmaadi.Items.Add(yeniVeri);
                MessageBox.Show("Yeni veri başarıyla eklendi.");
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Bu Firma Adı Zaten Var");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string yenikategori = textBox2.Text;
            if (!cmb_kategori.Items.Contains(yenikategori))
            {
                cmb_kategori.Items.Add(yenikategori);
                MessageBox.Show("Eklendi");
            }
            else MessageBox.Show("Eklenemedi");
        }
    }
}
