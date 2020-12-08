using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteket
{
    public class Laaner
    {
        private static int laanerCount = 0;
        private int laanerNummer;
        private string navn;
        /// <summary>
        /// Tager en string ind som parametor, hvor den der efter laver en låner med nummer og navn.
        /// </summary>
        /// <param name="_navn"></param>
        public Laaner(string _navn)
        {
            laanerNummer = laanerCount;
            navn = _navn;
            Console.WriteLine($"Der er blevet oprettet en låner med navn: {_navn} og nummer: {laanerNummer}");
            laanerCount++;
        }
        public int LaanerNummber
        {
            get
            {
                return laanerNummer;
            }
        }
        public string Navn
        { get { return navn; } }
    }
}
