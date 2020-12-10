using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteket
{
    public class Laaner : Person
    {
        private static int laanerCount = 0;
        private int laanerNummer;
        /// <summary>
        /// Tager en string ind som parametor, hvor den der efter laver en låner med nummer og navn.
        /// </summary>
        /// <param name="_navn"></param>
        public Laaner(string _navn, string _email)
        {
            laanerNummer = laanerCount;
            Navn = _navn;
            Email = _email;
            Console.WriteLine($"Der er blevet oprettet en låner med nummer: {laanerNummer} og navn: {Navn} samt en email: {Email}");
            laanerCount++;
        }
        /// <summary>
        /// Her bliver det nummer som låneren har sat, 
        /// samt det vil blive auto incrementet hvergang der bliver lavet en låner.
        /// </summary>
        public int LaanerNummber
        {
            get
            {
                return laanerNummer;
            }
        }
    }
}
