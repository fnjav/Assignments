using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Wolf : Mammal
    {
        public string Howl { get; set; }

        public Wolf(int id, string numberOfTeeth, string howl)
            : base(id, numberOfTeeth)
        {
            Howl = howl;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"Howls like this: {Howl}";
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
            foodSchedule.AddFoodScheduleItem("Once a day: One lamb");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Wolf";
        }
    }


}
