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
            OpretLaaner("Jens","jens@jens.email");
            OpretLaaner("Gerhard", "Gerhard@Gerhard.email");
            OpretLaaner("Lucas", "Lucas@Lucas.email");
            OpretLaaner("Benjamin", "Benjamin@Benjamin.email");
            OpretLaaner("Mike", "Mike@Mike.email");
        }

        public string HentBibliotek()//Henter biblioteks informaton.
        {
            string temp = "Velkommen til " + biblioteksNavn;
            return temp;
        }
        /// <summary>
        /// Bruges når der skal oprette en låner i systemet.
        /// Låner bliver automatisk givet et lånernummer.
        /// </summary>
        /// <param name="laanerNavn"></param>
        /// <param name="email"></param>
        public void OpretLaaner(string laanerNavn, string email)//Opretter en låner.
        {
            laanerList.Add( new Laaner(laanerNavn,email));
        }
        public string HentLaaner( Laaner laaner)//Udskriver alt information om en låner objeckt.
        {
            return $"Lånernummer: {laaner.LaanerNummber} - Navn: {laaner.Navn} & email {laaner.Email}\t er låner hos: {biblioteksNavn}";
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
