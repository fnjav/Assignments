namespace Assignment1.AnimalFiles
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
    }
}
