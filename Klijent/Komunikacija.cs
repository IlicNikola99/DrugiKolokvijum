using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();
        private Komunikacija()
        {
            
        }
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }

        public void PrijaviSe(string ime)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9090);
            stream = new NetworkStream(socket);
            ZahtevOdKlijenta zahtevOdKlijenta = new ZahtevOdKlijenta { KorisnickoIme = ime };
            formatter.Serialize(stream, zahtevOdKlijenta);
            OdgovorOdServera odg = (OdgovorOdServera)formatter.Deserialize(stream);
            if(odg.Signal == Signal.ImeZauzeto)
            {
                socket.Close();
                throw new Exception("Ime je zauzeto! Veza sa serverom je prekinuta! Pokusaj ponovo da se povezes!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Uspesno povezan sa serverom! Dalja prijava je onemogucena!");
            }
        }

        public void PosaljiPoruku(ZahtevOdKlijenta z)
        {
            formatter.Serialize(stream, z);
        }

        public OdgovorOdServera ProcitajPorukuOdServera()
        {
            return (OdgovorOdServera)formatter.Deserialize(stream);
        }
    }
}
