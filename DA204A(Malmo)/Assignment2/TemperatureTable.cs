// Filip Andersson Vestman 8/10-2017

namespace Assignment2
{
    /// <summary>
    /// Converts
    /// </summary>
    public class TemperatureTable
    {
        /// <summary>
        /// Starts the program
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndWriteResult();
        }

        /// <summary>
        /// Forces the choice to be either c or f
        /// </summary>
        /// <returns>Choice</returns>
        private string ChooseConversion()
        {
            while (true)
            {
                switch (System.Console.ReadLine().ToLower())
                {
                    case "c":
                        return "c";
                    case "f":
                        return "f";
                    default:
                        System.Console.Write("Invalid input, try again: ");
                        break;
                }
            }

        }

        /// <summary>
        /// Reads input and writes result
        /// </summary>
        private void ReadInputAndWriteResult()
        {
            System.Console.Write("Do you wish to convert to C or F? :");
            var choice = ChooseConversion();
            System.Console.Write("Which interval do you wish to use? :");
            var interval = Input.ReadIntegerConsole();

            if (choice.Equals("c"))
                System.Console.WriteLine(ConvertToCelsius(interval));
            else if (choice.Equals("f"))
                System.Console.WriteLine(ConvertToFahrenheit(interval));


        }

        /// <summary>
        /// Writes program info
        /// </summary>
        private void WriteProgramInfo()
        {
            System.Console.WriteLine("\tTemperature Table\n");
        }

        /// <summary>
        /// Converts F to C and returns result
        /// </summary>
        /// <param name="interval">Interval for conversion</param>
        /// <returns>Result as string</returns>
        private string ConvertToCelsius(int interval)
        {
            if (interval < 1) // Interval can't be smaller  than 1
                interval = 1;
            System.Console.WriteLine("\nChanging Fahrenheit (F) to Celsius (C)\n");
            var result = "";
            for (double i = 0; i <= 100; i += interval)
            {
                result += $"\t{i,10:0.00} F = {5.0 / 9.0 * (i - 32),10:0.00} C\n"; //,10 right alignment, :0.00 to get two decimals, -17.78 etc
            }
            return result;
        }

        /// <summary>
        /// Converts C to F and returns result
        /// </summary>
        /// <param name="interval">Interval for conversion</param>
        /// <returns>Result as string</returns>
        private string ConvertToFahrenheit(int interval)
        {
            if (interval < 1) // Interval can't be smaller  than 1
                interval = 1;
            System.Console.WriteLine("\nChanging Celsius (C) to Fahrenheit (F)\n");
            var result = "";
            for (double i = 0; i <= 100; i += interval)
            {
                result += $"\t{i,10:0.00} C = {9.0 / 5.0 * (i + 32),10:0.00} F\n";
            }
            return result;
        }
    }
}