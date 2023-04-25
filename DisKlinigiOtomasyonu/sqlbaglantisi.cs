using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DisKlinigiOtomasyonu
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-GU5O2G4\SQLEXPRESS;Initial Catalog=Dbo_Dental;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
