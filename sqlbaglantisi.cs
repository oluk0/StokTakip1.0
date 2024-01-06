using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StokTakip
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-92KS1\\SQLEXPRESS01;Initial Catalog=Stok_Takip;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
