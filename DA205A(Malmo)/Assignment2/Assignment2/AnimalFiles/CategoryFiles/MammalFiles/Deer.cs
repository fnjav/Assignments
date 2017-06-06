using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Deer : Mammal
    {
        public string HornSets { get; set; }

        public Deer(int id, string numberOfTeeth, string hornSets)
            : base(id, numberOfTeeth)
        {
            HornSets = hornSets;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{HornSets} horn sets";
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
            foodSchedule.AddFoodScheduleItem("Morning: A few acorns");
            foodSchedule.AddFoodScheduleItem("17:30: Lot of corn");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Deer";
        }
    }


}
