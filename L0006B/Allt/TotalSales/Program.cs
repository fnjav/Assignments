using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalSales
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] result = new int[3, 5];
            int choicePerson, choiceProduct;
            
            // Oändlig loop
            while (true)
            {
                String input;
                Console.WriteLine("Enter sales person number (-1 to end):");
                input = Console.ReadLine();
                // Bryter loopen
                if (input.Equals("-1"))
                {
                    break;
                }
                // Ingen felhantering
                choicePerson = Convert.ToInt32(input)-1;
                Console.WriteLine("Enter product number:");
                choiceProduct = Convert.ToInt32(Console.ReadLine())-1;
                Console.WriteLine("Enter sales amount:");
                result[choicePerson, choiceProduct] += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Product\tSalesperson 1\tSalesperson 2\tSalesperson 3\tTotal");

            // Stegar först igenom varje produkt, sedan varje säljare
            for (int i = 0; i < 5; i++)
            {
                String output = "" + (i+1) + "\t";
                int total = 0;
                for (int j = 0; j < 3; j++)
                {
                    int tmp = result[j, i];
                    output += String.Format("{0:C0}\t\t", tmp);
                    total += tmp;
                }
                output += String.Format("{0:C0}", total);
                Console.WriteLine(output);
                
            }
            Console.Write("Total\t");

            //Stegar igenom varje säljare, sen produkt
            for (int i = 0; i < 3; i++)
            {
                int total = 0;
                for (int j = 0; j < 5; j++)
                {
                    total += result[i, j];
                }
                Console.Write("{0:C0}\t\t", total);

            }

            // Fulfix för att inte stänga programmet efter avslutad loop
            Console.WriteLine("\nPress any key to exit..");
            Console.ReadLine();
        }
    }
}
