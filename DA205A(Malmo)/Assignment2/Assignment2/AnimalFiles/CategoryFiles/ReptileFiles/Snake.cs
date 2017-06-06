using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Snake : Reptile
    {
        public string CrawlSpeed { get; set; }

        public Snake(int id, string tongueLength, string crawlSpeed)
            : base(id, tongueLength)
        {
            CrawlSpeed = crawlSpeed;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{CrawlSpeed} Crawl speed";
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
            foodSchedule.AddFoodScheduleItem("Morning: One mouse");
            foodSchedule.AddFoodScheduleItem("Lunch: Two mice");
            foodSchedule.AddFoodScheduleItem("Dinner: One rat");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Snake";
        }
    }
}
