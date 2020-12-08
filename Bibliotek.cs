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
        public List<Laaner> laanerList = new List<Laaner>();

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
            laanerList.Add( new Laaner(laanerNummber, laanerNavn));
        }
        public string HentLaaner( Laaner laaner)
        {
            return $"Lånernummer: {laaner.LaanerNummber} - Navn: {laaner.Navn} er låner hos: {biblioteksNavn}";
        }
        public string HentAlleLaanere()
        {
            string allelaanere = "";

            foreach (Laaner laaner in laanerList)
            {
                allelaanere += $"{HentLaaner(laaner)} \n";
            }

            return allelaanere;
        }
    }
}
