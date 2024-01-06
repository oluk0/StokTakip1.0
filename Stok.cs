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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("Insert Into Stok(adı,fiyat,kdv,adet)Values(@p1,@p2,@p3,@p4)", con))
                {
                    cmd.Parameters.AddWithValue("@p1", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@p3", textBox3.Text);
                    cmd.Parameters.AddWithValue("@p4", textBox4.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eklendi");
                        Listele();

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }
            }           
         }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        void Listele()
        {
            SqlDataAdapter list = new SqlDataAdapter("Select * From Stok", bgl.baglanti());
            DataTable tb = new DataTable();
            list.Fill(tb);
            data_stok.DataSource = tb;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            SqlDataAdapter kasiyer = new SqlDataAdapter("Select * From Stok ", bgl.baglanti());
            DataTable tb = new DataTable();
            kasiyer.Fill(tb);
            data_stok.DataSource = tb;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Stok where fiyat=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Stok  Silindi Tekrar Geri Alınamaz");
            Listele();
        }
        private void Stok_Load(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT urunadi FROM Urunislemleri", baglanti))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["urunadi"].ToString());
                        }
                    }
                }
            }
        }
    }
}
