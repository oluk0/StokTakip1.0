using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Satış : Form
    {
        public Satış()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();       
        private void Satış_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT adı FROM Stok", baglanti))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["adı"].ToString());
                        }
                    }
                }
            }                                                                            
            SqlDataAdapter kasiyer = new SqlDataAdapter("Select * From musteri ", bgl.baglanti());
            DataTable tb = new DataTable();
            kasiyer.Fill(tb);
            data_musteri.DataSource = tb;           
        }      
        private void data_musteri_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_adi.Text = data_musteri.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = data_musteri.CurrentRow.Cells[2].Value.ToString();
            txt_tc.Text = data_musteri.CurrentRow.Cells[3].Value.ToString();          
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                string secilenVeri = comboBox1.SelectedItem.ToString();
                using (SqlConnection baglanti = bgl.baglanti())
                {                   
                    using (SqlCommand cmd = new SqlCommand("SELECT fiyat,adet FROM Stok WHERE adı = @p1", baglanti))
                    {
                        cmd.Parameters.AddWithValue("@p1", secilenVeri);

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                 if (int.TryParse(rd["fiyat"].ToString(), out int fiyat) &&
                                        int.TryParse(rd["adet"].ToString(), out int adet))
                                 {
                                         int toplam = fiyat * adet;                              
                                         txt_sFiyat.Text = fiyat.ToString();
                                         textBox5.Text = adet.ToString();
                                         textBox7.Text = toplam.ToString();
                                 }
                            }
                            else
                            {                               
                                txt_sFiyat.Text = "";
                                textBox5.Text = "";
                                textBox7.Text = "";
                            }
                        }                       
                    }
                }                       
        }
        void Listele()
        {
            
        }
        private void btn_Satis_Click(object sender, EventArgs e)
        {
            using (SqlConnection con =bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Satislar(faturaNo,musteriAdi,musteriSoyadi,tcKimlik,urunAdi,satisFiyat,adet,toplamTutar,kasaNo,tarih)Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",con))
                {
                    cmd.Parameters.AddWithValue("@p1",textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", txt_adi.Text);
                    cmd.Parameters.AddWithValue("@p3", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("@p4", txt_tc.Text);
                    cmd.Parameters.AddWithValue("@p5", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@p6", txt_sFiyat.Text);
                    cmd.Parameters.AddWithValue("@p7", textBox5.Text);
                    cmd.Parameters.AddWithValue("@p8", textBox7.Text);
                    cmd.Parameters.AddWithValue("@p9", textBox8.Text);
                    cmd.Parameters.AddWithValue("@p10", dateTimePicker1.Value.Date.ToString());
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("?");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
        }
    }
}
