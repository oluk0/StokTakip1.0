using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakip
{
    public partial class Kasiyer : Form
    {
        public Kasiyer()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("Insert Into Kasiyer(ad,soyad,tc,tel,adres,maas,gorevkasa,basTarih,bitTarih)Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",con))
                {
                    cmd.Parameters.AddWithValue("@p1", txt_adi.Text);
                    cmd.Parameters.AddWithValue("@p2",txt_soyad.Text);  
                    cmd.Parameters.AddWithValue("@p3",mask_tc.Text);
                    cmd.Parameters.AddWithValue("@p4", txt_tel.Text);
                    cmd.Parameters.AddWithValue("@p5",txt_adres.Text);
                    cmd.Parameters.AddWithValue("@p6",mask_maas.Text);  
                    cmd.Parameters.AddWithValue("@p7",txt_kasa.Text);
                    cmd.Parameters.AddWithValue("@p8",mask_tarih.Text);
                    cmd.Parameters.AddWithValue("@p9", mask_bittarih.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("EKLENDİ");
                        Listele();
                        panel1.Visible = false;
                    }
                    catch ( Exception h)
                    {
                        MessageBox.Show(h.Message);
                    }

                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            SqlDataAdapter kasiyer = new SqlDataAdapter("Select * From Kasiyer ",bgl.baglanti());
            DataTable tb = new DataTable(); 
            kasiyer.Fill(tb);
            data_kasiyer.DataSource=tb;
        }
        private void data_kasiyer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_adi.Text = data_kasiyer.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = data_kasiyer.CurrentRow.Cells[2].Value.ToString();
            mask_tc.Text = data_kasiyer.CurrentRow.Cells[3].Value.ToString();
            txt_tel.Text = data_kasiyer.CurrentRow.Cells[4].Value.ToString();
            txt_adres.Text = data_kasiyer.CurrentRow.Cells[5].Value.ToString();
            mask_maas.Text = data_kasiyer.CurrentRow.Cells[6].Value.ToString();
            txt_kasa.Text = data_kasiyer.CurrentRow.Cells[7].Value.ToString();
            mask_tarih.Text = data_kasiyer.CurrentRow.Cells[8].Value.ToString();
            mask_bittarih.Text = data_kasiyer.CurrentRow.Cells[9].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Kasiyer where tc=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", mask_tc.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kasiyer Silindi Tekrar Geri Alınamaz");
            Listele();
        }
        void Listele()
        {
            SqlDataAdapter list = new SqlDataAdapter("Select * From Kasiyer",bgl.baglanti());
            DataTable tb = new DataTable();
            list.Fill(tb);
            data_kasiyer.DataSource= tb;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Kasiyer Set  ad=@p1,soyad=@p2,tel=@p3,adres=@p4,maas=@p5,gorevkasa=@p6 where tc=@pos", connect))
                {
                    cmd.Parameters.AddWithValue("@p1", txt_adi.Text);
                    cmd.Parameters.AddWithValue("@p2", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("@p3", txt_tel.Text);
                    cmd.Parameters.AddWithValue("@p4", txt_adres.Text);
                    cmd.Parameters.AddWithValue("@p5", mask_maas.Text);
                    cmd.Parameters.AddWithValue("@p6", txt_kasa.Text);
                    cmd.Parameters.AddWithValue("@pos", mask_tc.Text); 
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kasiyer Güncel Keke");
                        Listele();
                    }
                    catch (Exception h)
                    {
                      MessageBox.Show(h.Message);   
                    }
                }
            }
        }
    }
}
