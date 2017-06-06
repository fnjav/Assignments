namespace Assignment1.AnimalFiles
{
    public class Butterfly : Insect
    {
        public string Pattern { get; set; }

        public Butterfly(int id, string numberOfLegs, string pattern)
            : base(id, numberOfLegs)
        {
            Pattern = pattern;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{Pattern} pattern";
        }
    }

}
