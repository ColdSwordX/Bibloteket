using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteket
{
    class Program
    {
        public static Bibliotek bibliotek = new Bibliotek("Sønderborg Bibliotek");
        static void Main(string[] args)
        {
            Console.WriteLine(bibliotek.HentBibliotek() + " " + DateTime.Now);
            bibliotek.OpretLaaner(1, "Jens");
            bibliotek.OpretLaaner(2, "Gerhard");
            bibliotek.OpretLaaner(3, "Lucas");
            Console.WriteLine(bibliotek.HentAlleLaanere());
            Console.ReadKey();
        }
    }
}
