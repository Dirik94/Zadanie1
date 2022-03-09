using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class MaszynaLosujaca
    {
        private List<string> kupony = new();
        private Random random = new();

        public void dodajNowyKupon(string value)
        {
            kupony.Add(value);
        }

        public List<string> wszystkieKupony() 
        {
            return kupony;
        }

        public string wylowsowanyKupon()
        {
            int numerKuponu = random.Next(kupony.Count);
            string wylosowanyKupon = kupony[numerKuponu];
            kupony.RemoveAt(numerKuponu);
            return wylosowanyKupon;
        }

        public bool listaKuponowPusta()
        {
            return kupony.Count == 0;
        }
    }
}
