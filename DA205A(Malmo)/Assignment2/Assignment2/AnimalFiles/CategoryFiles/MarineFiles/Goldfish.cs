using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Goldfish : Marine
    {
        public string MemorySpan { get; set; }

        public Goldfish(int id, string swimSpeed, string memorySpan)
            : base(id, swimSpeed)
        {
            MemorySpan = memorySpan;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{MemorySpan} memory span";
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
            var foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Twice a day: Those special flakes designed for fish");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Goldfish";
        }
    }
}
