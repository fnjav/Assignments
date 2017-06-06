namespace Assignment1.AnimalFiles
{
    public class Wolf : Mammal
    {
        public string Howl { get; set; }

        public Wolf(int id, string numberOfTeeth, string howl)
            : base(id, numberOfTeeth)
        {
            Howl = howl;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"Howls like this: {Howl}";
        }
    }


}
