using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class OdgovorOdServera
    {
        public Signal Signal { get; set; }
        public double Poeni { get; set; }
        public string PorukaOdServera { get; set; }
        public string TekstPitanja { get; set; }
        public string Pobednik { get; set; }
    }

    public enum Signal
    {
        Ok, ImeZauzeto
    }
}
