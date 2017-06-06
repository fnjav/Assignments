namespace Assignment1.AnimalFiles
{
    public class Bee : Insect
    {
        public string HoneyProduced { get; set; }

        public Bee(int id, string numberOfLegs, string honeyProduced)
            : base(id, numberOfLegs)
        {
            HoneyProduced = honeyProduced;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{HoneyProduced} honey produced";
        }
    }

}
