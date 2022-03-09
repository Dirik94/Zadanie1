using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal interface ImaszynaLosujaca
{
    public void dodajNowyKupon(string value);

    public List<string> wszystkieKupony();

    public string wylowsowanyKupon();

    public bool listaKuponowPusta();
}

namespace Zadanie1
{
    class Class1 : ImaszynaLosujaca
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
            return !(kupony?.Any() ?? false);
        }
    }
}
