using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane_uygulaması
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ISU7V0R\\SQLEXPRESS03;Initial Catalog=kutuphaneGiris;Integrated Security=True");
            baglan.Open();
            return baglan;
            
        }
      
    }
}
