using Assignment2.Enums;

namespace Assignment2.AnimalFiles
{
    public abstract class Reptile : Animal
    {
        public string TongueLength { get; set; }

        public Reptile(int id, string tongueLength)
            : base(id)
        {
            TongueLength = tongueLength;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{TongueLength} tongue, ";
        }
    }
}
