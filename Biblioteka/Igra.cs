using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class Igra
    {
        public int IgraId { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumVremePocetka { get; set; }
        public DateTime DatumVremeKraja { get; set; }
        public string Pobednik { get; set; }
        public List<Pitanje> Pitanja { get; set; }

    }
}
