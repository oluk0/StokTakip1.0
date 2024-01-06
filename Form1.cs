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

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlbaglantisi baglanti = new sqlbaglantisi();
        public string isim;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Boş Alanları Doldur");
                return;
            }
            using (SqlConnection con = baglanti.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("Select * From Giris where Kul_Adi=@p1 and Sifre=@p2 ",con))
                {
                    cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    try
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                MessageBox.Show("Başarılı İle Giriş Yapıldı");
                                anasayfa open = new anasayfa();
                                open.isim = textBox2.Text;
                                open.Show();
                                this.Hide();
                            }
                            else MessageBox.Show("Kullanıcı Adı Veya Şifre Bulunamadı");
                        }                    
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);                        
                    }
                }
            }
        }
    }
}
