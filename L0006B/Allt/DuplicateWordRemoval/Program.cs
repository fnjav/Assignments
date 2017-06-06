using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateWordRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            char[] c = new char[] { ' ', ',', '.', '?', '-', '_', '!' }; // Lista för split

            Console.WriteLine("This application will only display nonduplicate words in alphabetical order.");
            lista = Console.ReadLine() //Läser
                           .ToLower()   // Små bokstäver
                           .Split(c, StringSplitOptions.RemoveEmptyEntries)    // Splittar
                           .OrderBy(x => x) // Sorterar bokstavsordning
                           .GroupBy(n => n) // Grupperar
                           .Where(g => g.Count() == 1)        // Non duplicates              
                           .Select(g => g.Key) // Väljer från grupperingen
                           .ToList();   // Lägger till non duplicates i listan
            //Snyggare
            Console.WriteLine();
            foreach (string ord in lista)       // Skriver ut varje ord
            {
                Console.WriteLine(ord);
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
