using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyścigi
{
    class Zaklad
    {
        public int Stawka;
        public int NrPsa;
        public Facet Obstawiajacy;

        public string PobierzZaklad()
        {
            if (Stawka>0)
            {
                return Obstawiajacy + " postawił " + Stawka + " zł na psa numer " + NrPsa;
            }
            else
            {
                return Obstawiajacy + " nie zawarł zakładu.";
            }
        }
        public int Wyplac ( int Zwyciesca)
        {
            if (Zwyciesca==this.NrPsa)
            {
                return this.Stawka;
            }
            else
            {
                return -(this.Stawka);
            }
        }
        
    }
}
