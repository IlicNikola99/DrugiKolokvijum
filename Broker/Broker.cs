using Biblioteka;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBazePodataka
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlCommand command;
       
        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProSoft-Januar2019;Integrated Security=True;");
        }
        public void OtvoriKonekciju()
        {
            connection.Open();
        }
        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public List<Igra> VratiSveIgre()
        {
            List<Igra> igre = new List<Igra>();
            command = connection.CreateCommand();
            command.CommandText = "select * from Igra";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Igra i = new Igra
                {
                    IgraId = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                };
                igre.Add(i);
            }
            return igre;
        }

        public List<Pitanje> VratiPitanjaZaIgru(Igra igra)
        {
            List<Pitanje> pitanja = new List<Pitanje>();
            command = connection.CreateCommand();
            command.CommandText = $"select * from Pitanje where IgraId = {igra.IgraId}";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Pitanje pitanje = new Pitanje
                {
                    IgraId = reader.GetInt32(0),
                    PitanjeId = reader.GetInt32(1),
                    TekstPitanja = reader.GetString(2),
                    TacanOdgovor = reader.GetString(3),
                    BrojPoena = reader.GetInt32(4),
                };
                pitanja.Add(pitanje);
            }
            return pitanja;
        }
    }
}
