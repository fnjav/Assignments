using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class KillerWhale : Mammal
    {
        public string Kills { get; set; }

        public KillerWhale(int id, string numberOfTeeth, string kills)
            : base(id, numberOfTeeth)
        {
            Kills = kills;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{Kills} kills";
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
            foodSchedule.AddFoodScheduleItem("Every four hours: Lot of fish and mammals");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Killer Whale";
        }
    }


}
