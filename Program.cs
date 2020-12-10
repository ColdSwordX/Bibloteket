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
            bool running = true;
            while (running)
            {
                UdskrivMenu();
                char choosen = char.ToUpper( Console.ReadKey().KeyChar);
                switch (choosen)
                {
                    case 'V'://Se bibliotek's navn og data
                        Console.WriteLine(bibliotek.HentBibliotek() + " " + DateTime.Now);
                        break;
                    case 'O'://Opret en ny Låner
                        Console.WriteLine("Hvad hedder den nye låner?: ");
                        string navn = Console.ReadLine();
                        Console.WriteLine("Og hvad er låner's Email?: ");
                        string email = Console.ReadLine();
                        bibliotek.OpretLaaner(navn, email);
                        break;
                    case 'U'://Udskriv alle brugere.
                        Console.WriteLine(bibliotek.HentAlleLaanere());
                        break;
                    case 'X'://Afslutter loopen.
                        running = false;
                        break;
                    default:
                        Console.WriteLine($"Du trykkede på:\t\t {choosen} \t som ikke er en del af menuen. prøv igen.");
                        break;
                }
                Console.WriteLine("Tryk en knap for at gå videre ");
                Console.ReadKey();
            }
        }
        private static void UdskrivMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("| Du kan vælge følgende");
            Console.WriteLine("| V: Vis biblitekekts navn og dato");
            Console.WriteLine("| O: Opret Låner");
            Console.WriteLine("| U: Udskriv låner");
            Console.WriteLine("| X: Afslut");
            Console.WriteLine("----------------------------------");

        }
    }
}
