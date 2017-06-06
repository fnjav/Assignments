using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Ant : Insect
    {
        public string Colony { get; set; }

        public Ant(int id, string numberOfLegs, string colony)
            : base(id, numberOfLegs)
        {
            Colony = colony;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"Colony: {Colony}";
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
            var foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Every two hours: Lot of sugar");
            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Ant";
        }
    }

}
