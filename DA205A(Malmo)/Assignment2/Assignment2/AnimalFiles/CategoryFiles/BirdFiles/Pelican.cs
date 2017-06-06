using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Pelican : Bird
    {
        public string FishAmount { get; set; }

        public Pelican(int id, string wingspan, string fishAmount)
            : base(id, wingspan)
        {
            FishAmount = fishAmount;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{FishAmount} fish in throat pouch ";
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
            foodSchedule.AddFoodScheduleItem("Morning: Fish");
            foodSchedule.AddFoodScheduleItem("Lunch: Another fish");
            foodSchedule.AddFoodScheduleItem("Dinner: Mammal");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Pelican";
        }
    }
}
