using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Frog : Reptile
    {
        public string JumpHeight { get; set; }

        public Frog(int id, string tongueLength, string jumpHeight)
            : base(id, tongueLength)
        {
            JumpHeight = jumpHeight;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{JumpHeight} jump height";
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
            foodSchedule.AddFoodScheduleItem("Morning: One snail");
            foodSchedule.AddFoodScheduleItem("Lunch: Two snails");
            foodSchedule.AddFoodScheduleItem("Dinner: One snail");

            return foodSchedule;
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Snail";
        }
    }
}
