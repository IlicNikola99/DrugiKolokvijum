using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket osluskujuciSoket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();


        public Server()
        {
            osluskujuciSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            osluskujuciSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090));
            osluskujuciSoket.Listen(5);
        }

        public List<ClientHandler> Klijenti { get => klijenti; set => klijenti = value; }

        public bool PokreniIgru(Igra igra, int brojIgraca)//3
        {

            while (brojIgraca > 0)
            {
                Socket socket = osluskujuciSoket.Accept();
                ClientHandler igrac = new ClientHandler(socket, klijenti);
                if (igrac.PrijaviIgraca())
                {
                    klijenti.Add(igrac);
                    brojIgraca--;
                }
            }
            
            //igra pocinje!
            igra.Pitanja = Kontroler.Instance.VratiPitanjaZaIgru(igra);
            List<Thread> niti = new List<Thread>();
            foreach (ClientHandler igrac in klijenti)
            {
                Thread nit = new Thread(() => { igrac.PokreniIgruZaIgraca(igra); });
                niti.Add(nit);
                nit.Start();
            }
            foreach (Thread nit in niti)
            {
                nit.Join();
            }
            ProglasiPobednika();
            return true;
        }

        private void ProglasiPobednika()
        {
            klijenti = klijenti.OrderByDescending(k => k.Ukupno).ToList();

            ClientHandler pobednik  = klijenti.First();

            foreach(ClientHandler h in klijenti)
            {
                h.ObjaviPobednika(pobednik.ImeIgraca, pobednik.Ukupno);
            }

        }
    }
}
