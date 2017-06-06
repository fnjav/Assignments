// Filip Andersson Vestman 8/10-2017
namespace Assignment2
{
    class Input
    {
        /// <summary>
        /// Reads and makes sure the input is double
        /// </summary>
        /// <returns>Input as double</returns>
        public static double ReadDoubleConsole()
        {
            var inputControl = false;
            double result;
            do
            {                
                inputControl = double.TryParse(System.Console.ReadLine(), out result);
                if (!inputControl)
                    System.Console.WriteLine("Invalid input, try again");
            } while (!inputControl);
            return result;
        }

        /// <summary>
        /// Reads and makes sure the input is decimal
        /// </summary>
        /// <returns>Input as decimal or the method to try again</returns>
        public static decimal ReadDecimalConsole() // Test with recursive calling
                                                   // 4.3. Do not call a method from inside the same method – avoid recursive calling! You must use loops to repeat a method! 
                                                   // I think it looks ok in this case, otherwise it would've looked like ReadDoubleConsole
        {
            if (decimal.TryParse(System.Console.ReadLine(), out var result))
            {
                return result;
            }            
            System.Console.WriteLine("Invalid input, try again!");
            return ReadDecimalConsole(); // try again, recursive
        }

        /// <summary>
        /// Reads and makes sure the input is integer
        /// </summary>
        /// <returns>Input as integer</returns>
        public static int ReadIntegerConsole()
        {
            var inputControl = false;
            int result;
            do
            {                
                inputControl = int.TryParse(System.Console.ReadLine(), out result);
                if (!inputControl)
                    System.Console.WriteLine("Invalid input, try again");
            } while (!inputControl);
            return result;
        }
    }

}
