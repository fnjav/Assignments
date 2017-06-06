using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Butterfly : Insect
    {
        public string Pattern { get; set; }

        public Butterfly(int id, string numberOfLegs, string pattern)
            : base(id, numberOfLegs)
        {
            Pattern = pattern;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{Pattern} pattern";
        }

        /// <summary>
        /// Returns type of eater
        /// </summary>
        /// <returns>Type of eater as EaterType enum</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Omnivorous;
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
            return "Butterfly";
        }
    }

}
