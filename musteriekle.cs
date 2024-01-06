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
    public partial class musteriekle : Form
    {
        public musteriekle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = bgl.baglanti())
            {
                using (SqlCommand cmd = new SqlCommand("Insert Into musteri(ad,soyad,tc,tel)values(@p1,@p2,@p3,@p4)",con))
                {
                    cmd.Parameters.AddWithValue("@p1",textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@p3", textBox3.Text);
                    cmd.Parameters.AddWithValue("@p4", textBox4.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri Eklendi"); 
                        musteriekle c = new musteriekle();
                        
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);                       
                    }
                }
            }
        }
    }
}
