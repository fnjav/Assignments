// Filip Andersson Vestman 8/10-2017
using System;
namespace Assignment2
{
    class Menu
    {
        private WorkingSchedule _workingSchedule = new WorkingSchedule();
        private CurrencyConverter _currencyConverter = new CurrencyConverter();
        private WholeNumbersForAdd _wholeNumbersForAdd = new WholeNumbersForAdd();
        private FloatingPointsNumberWhileAdd _floatingPointsNumberWhileAdd = new FloatingPointsNumberWhileAdd();

        public void Start()
        {
            WriteMenuText();
        }

        private void WriteMenuText()
        {
            while (true) //endless loop
            {
                Console.Write("\t\tMAIN MENU\n\n" +
                    "Whole Numbers with For\t\t\t: 1\n" +
                    "Floating Point Numbers with While\t: 2\n" +
                    "Currency Converter with Do While Loop\t: 3\n" +
                    "Work Schedule\t\t\t\t: 4\n" +
                    "Temperature Table\t\t\t: 5\n" +
                    "Exit the program\t\t\t: 0\n\n" +
                    "Your choice: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        var wholeNumbersForAdd = new WholeNumbersForAdd();
                        wholeNumbersForAdd.Start();
                        break;
                    case "2":
                        var floatingPointsNumberWhileAdd = new FloatingPointsNumberWhileAdd();
                        floatingPointsNumberWhileAdd.Start();
                        break;
                    case "3":
                        var currencyConverter = new CurrencyConverter();
                        currencyConverter.Start();
                        break;
                    case "4":
                        var workingSchedule = new WorkingSchedule();
                        workingSchedule.Start();
                        break;
                    case "5":
                        var temperatureTable = new TemperatureTable();
                        temperatureTable.Start();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("\nInvalid input, try again\n");
                        break;
                }

            }
        }
    }

}
