using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Dog : Mammal
    {
        public string TailLength { get; private set; }

        public Dog(int id, string numberOfTeeth, string tailLength)
            : base(id, numberOfTeeth)
        {
            TailLength = tailLength;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"Length of tail: {TailLength}";
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
            foodSchedule.AddFoodScheduleItem("Morning: Breakfast");
            foodSchedule.AddFoodScheduleItem("Lunch: Bowl of dog food");
            foodSchedule.AddFoodScheduleItem("Dinner: Another bowl of dog food");
            foodSchedule.AddFoodScheduleItem("Late night snack: Bit of falukorv");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Dog";
        }
    }


}
