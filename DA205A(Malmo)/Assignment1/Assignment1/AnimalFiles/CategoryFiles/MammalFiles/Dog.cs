namespace Assignment1.AnimalFiles
{
    public class Dog : Mammal
    {
        public string TailLength { get; private set; }

        public Dog(int id, string numberOfTeeth, string tailLength)
            : base(id, numberOfTeeth)
        {
            TailLength = tailLength;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"Length of tail: {TailLength}";
        }
    }


}
