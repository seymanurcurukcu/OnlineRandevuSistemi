using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OnlineRandevuSistemi
{
    class sqlBaglantisi
    {

        public SqlCommand komut { get; set; }
        public SqlConnection baglanti { get; private set; }
        public SqlDataAdapter da { get; set; }
        public SqlDataReader sqlDataReader { get; set; }
        public string Sorgu { get; set; }
      
      
        public sqlBaglantisi()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-CM13FC9\\SQLEXPRESS;Initial Catalog=OnlineRandevuSistemi;Integrated Security=True");
        }

    }
}
