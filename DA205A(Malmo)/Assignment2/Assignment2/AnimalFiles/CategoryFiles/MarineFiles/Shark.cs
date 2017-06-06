using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Shark : Marine
    {
        public string TeethSharpness { get; set; }

        public Shark(int id, string swimSpeed, string teethSharpness)
            : base(id, swimSpeed)
        {
            TeethSharpness = teethSharpness;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{TeethSharpness} sharp teeth";
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
            var foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Once a day: A cow");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Shark";
        }
    }
}
