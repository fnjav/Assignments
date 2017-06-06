using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public abstract class Mammal : Animal
    {
        public string NumberOfTeeth { get; set; }

        public Mammal(int id, string numberOfTeeth)
            : base(id)
        {
            NumberOfTeeth = numberOfTeeth;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"has {NumberOfTeeth} teeth, ";
        }
    }
}
