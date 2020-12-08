using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteket
{
    public class Laaner
    {
        private int laanerNummer;
        private string navn;

        public Laaner(int _laanerNummer, string _navn)
        {
            laanerNummer = _laanerNummer;
            navn = _navn;
            Console.WriteLine($"Der er blevet oprettet en låner med navn: {_navn} og nummer: {_laanerNummer}");
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
