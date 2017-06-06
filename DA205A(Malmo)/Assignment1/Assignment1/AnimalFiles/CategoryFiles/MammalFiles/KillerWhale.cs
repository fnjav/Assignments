namespace Assignment1.AnimalFiles
{
    public class KillerWhale : Mammal
    {
        public string Kills { get; set; }

        public KillerWhale(int id, string numberOfTeeth, string kills)
            : base(id, numberOfTeeth)
        {
            Kills = kills;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{Kills} kills";
        }
    }


}
