namespace Assignment1.AnimalFiles
{
    public abstract class Bird : Animal
    {
        public string Wingspan { get; set; }

        public Bird(int id, string wingspan)
            : base(id)
        {
            Wingspan = wingspan;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{Wingspan} wingspan, ";
        }
    }
}
