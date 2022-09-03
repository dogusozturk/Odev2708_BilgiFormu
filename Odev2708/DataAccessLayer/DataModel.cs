using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }

        public List<Kullanicilar> GetIsim()
        {
            try
            {
                cmd.CommandText = "SELECT ID,Isim,Soyisim FROM Kullanicilar";
                con.Open();
                List<Kullanicilar> kullanici = new List<Kullanicilar>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kullanici.Add(new Kullanicilar { ID = reader.GetInt32(0), Isim = reader.GetString(1), Soyisim = reader.GetString(2) });
                }
                return kullanici;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
}   }
