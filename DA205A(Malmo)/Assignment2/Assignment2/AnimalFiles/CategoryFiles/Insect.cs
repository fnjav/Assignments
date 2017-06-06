using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public abstract class Insect : Animal
    {
        public string NumberOfLegs { get; set; }

        public Insect(int id, string numberOfLegs)
            : base(id)
        {
            NumberOfLegs = numberOfLegs;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{NumberOfLegs} legs, ";
        }


    }
}
