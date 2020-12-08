using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteket
{
    public class Bibliotek
    {
        public string biblioteksNavn;
        public Laaner laaner;

        public Bibliotek(string navn)
        {
            biblioteksNavn = navn;
        }

        public string HentBibliotek()
        {
            string temp = "Velkommen til " + biblioteksNavn;
            return temp;
        }
        public void OpretLaaner(int laanerNummber, string laanerNavn)
        {
            laaner = new Laaner(laanerNummber, laanerNavn);
        }
        public string HentLaaner()
        {
            return $"Lånernummer: {laaner.LaanerNummber} - Navn: {laaner.Navn} er låner hos: {biblioteksNavn}";
        }
    }
}
