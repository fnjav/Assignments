namespace Assignment1.AnimalFiles
{
    public class Ant : Insect
    {
        public string Colony { get; set; }

        public Ant(int id, string numberOfLegs, string colony)
            : base(id, numberOfLegs)
        {
            Colony = colony;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"Colony: {Colony}";
        }
    }

}
