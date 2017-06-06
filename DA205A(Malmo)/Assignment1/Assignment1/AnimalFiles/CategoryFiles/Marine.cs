namespace Assignment1.AnimalFiles
{
    public class Marine : Animal
    {
        public string SwimSpeed { get; set; }

        public Marine(int id, string swimSpeed)
            : base(id)
        {
            SwimSpeed = swimSpeed;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"Swim speed: {SwimSpeed}, ";
        }
    }
}
