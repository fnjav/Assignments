using System;

namespace Assignment1A
{
    /// <summary>
    /// Simple pet class. Edit and view information
    /// </summary>
    class Pet
    {
        private string _name;
        private int _age;
        private bool _isFemale;

        /// <summary>
        /// Edits name, age and gender
        /// </summary>
        public void EditInformation()
        {
            Console.WriteLine("Enter name");
            _name = Console.ReadLine();
            
            // Makes sure age is an integer
            var ageControl = false;
            do
            {
                Console.WriteLine("Enter age");
                ageControl = int.TryParse(Console.ReadLine(), out _age);
            } while (!ageControl);


            restartSwitch:; // Goto is ugly but works here imo
            Console.WriteLine("Is the pet male or female?");
            switch (Console.ReadLine().ToLower())
            {
                case "female":
                    _isFemale = true;
                    break;
                case "male":
                    _isFemale = false;
                    break;
                default:
                    Console.WriteLine("Non binary gender? Try again");
                    goto restartSwitch; // restart loop
            }            
        }

        /// <summary>
        /// Displays name, age and gender of pet
        /// </summary>
        public void DisplayInformation()
        {
            Console.WriteLine("Name: {0}\nAge: {1}\nThe pet is a {2}", _name, _age, _isFemale ? "female" : "male");
            Console.ReadLine(); // Exit program
        }
    }
}
