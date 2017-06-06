namespace Assignment1.AnimalFiles
{
    public class Deer : Mammal
    {
        public string HornSets { get; set; }

        public Deer(int id, string numberOfTeeth, string hornSets)
            : base(id, numberOfTeeth)
        {
            HornSets = hornSets;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{HornSets} horn sets";
        }
    }


}
