// Filip Andersson Vestman 8/10-2017
using System.Collections.Generic;

namespace Assignment2
{
    /// <summary>
    /// Adds whole numbers
    /// </summary>
    class WholeNumbersForAdd
    {        
        private int _numberOfInputs;
        private int _summation;
        

        /// <summary>
        /// Starts the summation
        /// </summary>
        public void Start()
        {    
            _summation = SumNumbers(ReadInput());
            WriteResult();
        }

        /// <summary>
        /// Reads input
        /// </summary>
        /// <returns></returns>
        private int[] ReadInput()
        {
            var _listOfNumbers = new List<int>();
            WriteProgramInfo();
            // Ask the user for how many whole numbers to add            
            System.Console.Write("Number of values to sum? ");
            _numberOfInputs = Input.ReadIntegerConsole();

            // Let the user give the numbers. Read each of the numbers into your program.
            for (var i = 1; i <= _numberOfInputs; i++)
            {
                System.Console.Write("Please give the value no {0} <whole number>: ", i);
                _listOfNumbers.Add(Input.ReadIntegerConsole());
            }
            return _listOfNumbers.ToArray();
        }

        /// <summary>
        /// Sums up the numbers
        /// </summary>
        /// <param name="numbers">numbers to sum</param>
        /// <returns>result</returns>
        private int SumNumbers(params int[] numbers) // params needless in this case, but with params SumNumbers(1, 2, 4); would be possible
        {
            var result = 0;
            foreach (var i in numbers)
                result += i;
            return result;
        }

        /// <summary>
        /// Writes welcome message
        /// </summary>
        private void WriteProgramInfo()
        {
            System.Console.WriteLine("++++++ Summation of whole numbers ++++++\n" +
                "\tUsing a for-statement\n\n");
        }

        /// <summary>
        /// Writes the result
        /// </summary>
        private void WriteResult()
        {
            System.Console.WriteLine("\nThe sum is\t{0}\n\n", _summation); 
        }
    }

}
