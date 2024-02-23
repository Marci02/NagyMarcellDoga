using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyMarcellDoga
{
    internal class Tabor
    {
        public int KezdHo { get; set; }
        public int KezdNap { get; set; }
        public int VegHo { get; set; }
        public int VegNap { get; set; }
        public string Kezdobetuk { get; set; }
        public string Tema { get; set; }

        public Tabor(string v)
        {
            string[] adatok = v.Split('\t');
            KezdHo = int.Parse(adatok[0]);
            KezdNap = int.Parse(adatok[1]);
            VegHo = int.Parse(adatok[2]);
            VegNap = int.Parse(adatok[3]);
            Kezdobetuk = adatok[4];
            Tema = adatok[5];
        }
    }
}
