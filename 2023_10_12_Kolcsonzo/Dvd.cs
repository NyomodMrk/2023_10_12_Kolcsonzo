using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_12_Kolcsonzo
{
    internal class Dvd : IKolcsonozheto, IComparable<Dvd>
    {

        private string cim;
        private int hossz;

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public int CompareTo(Dvd other)
        {
            return this.hossz - other.hossz;
        }

        public int MeddigKolcsonozheto()
        {
            return 7;
        }

        public string MegjelenitendoNev()
        {
            return $"{this.cim} ({this.hossz} perc)";
        }
    }
}
