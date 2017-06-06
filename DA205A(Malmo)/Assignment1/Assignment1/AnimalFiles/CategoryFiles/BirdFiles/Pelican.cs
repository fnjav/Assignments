namespace Assignment1.AnimalFiles
{
    public class Pelican : Bird
    {
        public string FishAmount { get; set; }

        public Pelican(int id, string wingspan, string fishAmount)
            : base(id, wingspan)
        {
            FishAmount = fishAmount;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{FishAmount} fish in throat pouch ";
        }
    }
}
