using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Eagle : Bird
    {
        public string ColourOfBeak { get; set; }

        public Eagle(int id, string wingspan, string colourOfBeak)
            : base(id, wingspan)
        {
            ColourOfBeak = colourOfBeak;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"has {ColourOfBeak} beak";
        }

        /// <summary>
        /// Returns type of eater
        /// </summary>
        /// <returns>Type of eater as EaterType enum</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
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
            return "Eagle";
        }
    }
}
