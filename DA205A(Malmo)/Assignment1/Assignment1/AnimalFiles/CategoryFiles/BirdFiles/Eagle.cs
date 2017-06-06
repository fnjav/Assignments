namespace Assignment1.AnimalFiles
{
    public class Eagle : Bird
    {
        public string ColourOfBeak { get; set; }

        public Eagle(int id, string wingspan, string colourOfBeak)
            : base(id, wingspan)
        {
            ColourOfBeak = colourOfBeak;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"has {ColourOfBeak} beak";
        }
    }
}
