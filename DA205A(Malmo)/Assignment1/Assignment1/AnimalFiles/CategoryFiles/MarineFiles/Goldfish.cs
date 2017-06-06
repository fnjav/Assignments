namespace Assignment1.AnimalFiles
{
    public class Goldfish : Marine
    {
        public string MemorySpan { get; set; }

        public Goldfish(int id, string swimSpeed, string memorySpan)
            : base(id, swimSpeed)
        {
            MemorySpan = memorySpan;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{MemorySpan} memory span";
        }
    }

}
