using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Bee : Insect
    {
        public string HoneyProduced { get; set; }

        public Bee(int id, string numberOfLegs, string honeyProduced)
            : base(id, numberOfLegs)
        {
            HoneyProduced = honeyProduced;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{HoneyProduced} honey produced";
        }

        /// <summary>
        /// Returns type of eater
        /// </summary>
        /// <returns>Type of eater as EaterType enum</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }

        /// <summary>
        /// Food schedule for the animal
        /// </summary>
        /// <returns>Food Schedule</returns>
        public override FoodSchedule GetFoodSchedule()
        {
            return new FoodSchedule();
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Bee";
        }

    }

}
