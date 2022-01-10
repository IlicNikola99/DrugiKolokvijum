using Biblioteka;
using BrokerBazePodataka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Kontroler
    {
        private static Kontroler instance;
        private Broker broker = new Broker();
        private Kontroler() { }
        public static Kontroler Instance
        {
            get
            {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }

        public List<Igra> VratiSveIgre()
        {
            try
            {
                broker.OtvoriKonekciju();
                return broker.VratiSveIgre();
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

        internal List<Pitanje> VratiPitanjaZaIgru(Igra igra)
        {
            try
            {
                broker.OtvoriKonekciju();
                return broker.VratiPitanjaZaIgru(igra);
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

        internal void AzurirajPobednika(Igra igra)
        {
           // throw new NotImplementedException();
        }

        internal void AzurirajDatumVremePocetka(Igra igra)
        {
            //throw new NotImplementedException();
        }
    }
}
