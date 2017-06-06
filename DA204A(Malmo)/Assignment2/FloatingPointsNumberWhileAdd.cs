// Filip Andersson Vestman 8/10-2017
namespace Assignment2
{
    /// <summary>
    /// Reads floating numbers and accumulate them to a total value
    /// </summary>
    class FloatingPointsNumberWhileAdd
    {
        private double _summation = 0;

        /// <summary>
        /// Starts the other methods
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadValuesAndSumNumbers();
            WriteResult();
        }

        /// <summary>
        /// Reads values and sums them
        /// </summary>
        private void ReadValuesAndSumNumbers()
        {
            while (true)
            {
                System.Console.Write("Write an amount to sum or zero to finish: ");
                var tmp = Input.ReadDoubleConsole();
                if (tmp == 0)
                    break;
                _summation += tmp;
            }
        }

        /// <summary>
        /// Writes welcome message
        /// </summary>
        private void WriteProgramInfo()
        {
            System.Console.WriteLine("\n\n++++++ Summation of real numbers ++++++" +
                "\t\tUsing While-statement\n\n" +
                "Write 0 to finish!\n" +
                "Make sure to use correct decimal caracter.\n\n");
        }

        /// <summary>
        /// Writes the final result
        /// </summary>
        private void WriteResult()
        {
            System.Console.WriteLine("\nThe sum is {0}\n", _summation);            
        }



    }

}
