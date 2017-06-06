// Filip Andersson Vestman 8/10-2017
using System.Collections.Generic;
using System;

namespace Assignment2
{
    /// <summary>
    /// Simple currency converter
    /// </summary>
    class CurrencyConverter
    {
        private decimal _summation = new decimal();
        private string _currency;
        private decimal _rate;

        /// <summary>
        /// Starts the program
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
            _currency = ChooseCurrency();
            _rate = ChooseRate();
            WriteResult();

        }

        /// <summary>
        /// Reads input from user and sum it
        /// </summary>
        private void ReadInput()
        {
            decimal tmp;
            do
            {
                Console.Write("Write an amount or zero to finish: ");
                tmp = Input.ReadDecimalConsole();
                _summation += tmp;
            } while (tmp != 0); // Break loop if 0
        }

        /// <summary>
        /// Lets user choose currency
        /// </summary>
        /// <returns>Currency as string</returns>
        private string ChooseCurrency()
        {
            do
            {
                Console.Write("\nName of the foreign currency: ");
                switch (Console.ReadLine().ToLower()) // to lower so euro and Euro is treated the same way
                {
                    case "euro":
                        return "euro";
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;
                }
            } while (true);
        }

        /// <summary>
        /// Lets user choose exchange rate
        /// </summary>
        /// <returns>Exchange rate as decimal</returns>
        private decimal ChooseRate()
        {
            Decimal tmp;
            while (true)
            {
                Console.Write("Exchange rate: ");
                tmp = Input.ReadDecimalConsole();
                if (tmp <= 0)
                {
                    Console.WriteLine("Exchange rate can't be zero");
                }
                else
                    break;
            }
            return tmp;

        }


        /// <summary>
        /// Writes welcome message and information
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n++++++ The Currency Converter ++++++\n\n" +
                "Write 0 to finish input!\n" +
                "Make sure to use correct decimal character.\n\n");
        }

        /// <summary>
        /// Writes final result
        /// </summary>
        private void WriteResult()
        {
            Console.WriteLine("\n\nThe sum is {0} kr\n\n" +
                "{0} kr is converted to {1:0.00} {2} at the rate of {3} kr/{2}\n\n", _summation, _summation / _rate, _currency, _rate);
        }

    }

}
