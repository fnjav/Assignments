using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            int choice = GetMenuChoice();

            while (choice != 3)
            {
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter length: ");
                        rectangle.Length = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Enter width: ");
                        rectangle.Width = Convert.ToDouble(Console.ReadLine());
                        break;
                }

                Console.WriteLine(rectangle.ToString());
                Console.WriteLine();
                choice = GetMenuChoice();
            }
            
        }

        private static int GetMenuChoice()
        {
            Console.WriteLine("1. Set Length");
            Console.WriteLine("2. Set Width");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
