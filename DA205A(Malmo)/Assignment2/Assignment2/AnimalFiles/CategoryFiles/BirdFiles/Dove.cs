using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public class Dove : Bird
    {
        public string Product { get; set; }

        public Dove(int id, string wingspan, string product)
            : base(id, wingspan)
        {
            Product = product;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"is {Product}";
        }

        public override EaterType GetEaterType()
        {
            return EaterType.Omnivorous;
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return new FoodSchedule(); // Self feeding
        }

        public override string GetSpecies()
        {
            return "Dove";
        }
    }
}
