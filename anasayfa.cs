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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle open = new musteriekle();
            open.Show();
        }
        public string isim;
        private void button2_Click(object sender, EventArgs e)
        {
            Urunislemleri open = new Urunislemleri();
            open.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kasiyer open = new Kasiyer();
            open.Show();
        }
        public DataTable tabloSatis = new DataTable();
        private void anasayfa_Load(object sender, EventArgs e)
        {
        }
        void Listele()
        {
            SqlDataAdapter list = new SqlDataAdapter("Select * From Satislar", bgl.baglanti());
            DataTable tb = new DataTable();
            list.Fill(tb);
            data_satislar.DataSource = tb;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Stok open = new Stok();
            open.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
            Satış open = new Satış();
            open.Show();
        }       
        private void button7_Click(object sender, EventArgs e)
        {
            Listele();       
        }           
    }
}
