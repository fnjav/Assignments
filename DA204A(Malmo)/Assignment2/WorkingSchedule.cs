// Filip Andersson Vestman 8/10-2017
using System;

namespace Assignment2
{
    /// <summary>
    /// Simple working schedule
    /// </summary>
    class WorkingSchedule
    {
        /// <summary>
        /// Starts the program
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
        }

        /// <summary>
        /// Reads input from user
        /// </summary>
        private void ReadInput()
        {
            bool breakLoop = new bool();
            do // Do while since I want it to run at least once, regular while would've worked in the same way though
            {
                Console.Write("1. Show a list of the weekends to work\n" +
                    "2. Show a list of the nights to work\n" +
                    "0 Return to main menu\n\n" +
                    "Your choice: ");
                switch (Console.ReadLine()) // I like switch for menu
                {
                    case "1":
                        WriteSchedule(1, 3); // Start 1, interval 3
                        break;
                    case "2":
                        WriteSchedule(6, 5); // Start 6, interval 5
                        break;
                    case "0":
                        breakLoop = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input\n");
                        break;
                }

            } while (!breakLoop);
        }
      
        /// <summary>
        /// Writes schedules
        /// </summary>
        /// <param name="startWeek">Start week</param>
        /// <param name="interval">Interval</param>
        private void WriteSchedule(int startWeek, int interval)
        {
            var column = 1;
            var maxColumns = 3;
            var result = "";
            for (int i = startWeek; i <= 52; i += interval) // For-loop because 52 weeks exactly
            {
                result += $"\t\tWeek {i}";
                if (column++ >= maxColumns)
                {
                    column = 1; // Reset column
                    result += "\n"; // New line
                }
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// Writes welcome message
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\t\tYOUR SCHEDULE PROGRAM\n" +
                "Select from the menu which type of schedule you would like to see\n");
        }
    }

}
