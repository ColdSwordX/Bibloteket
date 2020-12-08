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
            OpretLaaner("Jens");
            OpretLaaner("Gerhard");
            OpretLaaner("Lucas");
            OpretLaaner("Benjamin");
            OpretLaaner("Mike");
        }

        public string HentBibliotek()//Henter biblioteks informaton.
        {
            string temp = "Velkommen til " + biblioteksNavn;
            return temp;
        }
        public void OpretLaaner(string laanerNavn)//Opretter en låner.
        {
            laanerList.Add( new Laaner(laanerNavn));
        }
        public string HentLaaner( Laaner laaner)//Udskriver alt information om en låner objeckt.
        {
            return $"Lånernummer: {laaner.LaanerNummber} - Navn: {laaner.Navn} er låner hos: {biblioteksNavn}";
        }
        public string HentAlleLaanere()//Henter alle lånere fra listen som er tilgængelig over alt i klassen.
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
