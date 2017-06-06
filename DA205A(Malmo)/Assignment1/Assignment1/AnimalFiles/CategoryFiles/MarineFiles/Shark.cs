namespace Assignment1.AnimalFiles
{
    public class Shark : Marine
    {
        public string TeethSharpness { get; set; }

        public Shark(int id, string swimSpeed, string teethSharpness)
            : base(id, swimSpeed)
        {
            TeethSharpness = teethSharpness;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{TeethSharpness} sharp teeth";
        }
    }
}
