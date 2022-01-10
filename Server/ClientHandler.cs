using Biblioteka;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private NetworkStream stream;
        private BinaryFormatter formatter;

        private readonly Socket socket;
        private readonly List<ClientHandler> klijenti;
        private string imeIgraca;
        public double Ukupno { get; set; } = 0;
        public string ImeIgraca { get => imeIgraca; }
        public int BrojTacnihOdgovora { get; set; } = 0;
        public int BrojNetacnihOdgovora { get; set; } = 0;

        public ClientHandler(Socket socket, List<ClientHandler> klijenti)
        {
            this.socket = socket;
            this.klijenti = klijenti;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        internal bool PrijaviIgraca()
        {
            ZahtevOdKlijenta zahtev = (ZahtevOdKlijenta)formatter.Deserialize(stream);
            OdgovorOdServera odgovor = new OdgovorOdServera();

            if (klijenti.Any(k => k.imeIgraca == zahtev.KorisnickoIme))
            {
                odgovor.Signal = Signal.ImeZauzeto;
                formatter.Serialize(stream, odgovor);
                return false;
            }
            odgovor.Signal = Signal.Ok;
            formatter.Serialize(stream, odgovor);
            imeIgraca = zahtev.KorisnickoIme;
            return true;

        }

        internal void PokreniIgruZaIgraca(Igra igra)
        {
            try
            {
                foreach (Pitanje p in igra.Pitanja)
                {
                    OdgovorOdServera novoPitanje = new OdgovorOdServera();
                    novoPitanje.TekstPitanja = p.TekstPitanja;
                    formatter.Serialize(stream, novoPitanje);
                    ZahtevOdKlijenta zahtev = (ZahtevOdKlijenta)formatter.Deserialize(stream);

                    OdgovorOdServera brojPoena = IzracunajPoene(p, zahtev.Odgovor);
                    formatter.Serialize(stream, brojPoena);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        internal void ObjaviPobednika(string imeIgraca, double ukupno)
        {
            OdgovorOdServera pobednik = new OdgovorOdServera();
            pobednik.Pobednik = imeIgraca;
            pobednik.Poeni = ukupno;
            pobednik.TekstPitanja = $"Pobedio je {pobednik.Poeni} {pobednik.Pobednik}";

            formatter.Serialize(stream, pobednik);
        }

        private OdgovorOdServera IzracunajPoene(Pitanje p, string odgovor)
        {
            OdgovorOdServera odgovorOdServera = new OdgovorOdServera();
            if (p.TacanOdgovor == odgovor && !p.Odgovoreno)
            {
                p.Odgovoreno = true;
                p.Odgovorio = imeIgraca;
                odgovorOdServera.Poeni = p.BrojPoena;
                odgovorOdServera.PorukaOdServera = "Tacan odgovor";
                BrojTacnihOdgovora++;
            }
            else if(p.TacanOdgovor == odgovor && p.Odgovoreno)
            {
                odgovorOdServera.Poeni = 0;
                odgovorOdServera.PorukaOdServera = $"Tacan odgovor, ali na njega je vec odgovorio {p.Odgovorio}";
                BrojTacnihOdgovora++;
            }
            else /*if (p.TacanOdgovor != odgovor)*/
            {
                odgovorOdServera.Poeni = -0.1 * p.BrojPoena;
                odgovorOdServera.PorukaOdServera = $"Netacan odgovor";
                BrojNetacnihOdgovora++;
            }
            Ukupno += odgovorOdServera.Poeni;
            return odgovorOdServera;
        }
    }
}
