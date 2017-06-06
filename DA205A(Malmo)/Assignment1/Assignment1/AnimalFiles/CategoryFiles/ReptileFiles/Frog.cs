namespace Assignment1.AnimalFiles
{
    public class Frog : Reptile
    {
        public string JumpHeight { get; set; }

        public Frog(int id, string tongueLength, string jumpHeight)
            : base(id, tongueLength)
        {
            JumpHeight = jumpHeight;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{JumpHeight} jump height";
        }
    }
}
