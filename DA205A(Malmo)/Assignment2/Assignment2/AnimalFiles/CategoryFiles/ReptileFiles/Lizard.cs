using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Lizard : Reptile
    {
        public string Camouflage { get; set; }

        public Lizard(int id, string tongueLength, string camouflage)
            : base(id, tongueLength)
        {
            Camouflage = camouflage;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Camouflage} Camouflage    ";
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
            return new FoodSchedule();
        }

        /// <summary>
        /// Species of animal
        /// </summary>
        /// <returns>Species as string</returns>
        public override string GetSpecies()
        {
            return "Lizard";
        }
    }
}
