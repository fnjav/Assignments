namespace Assignment1.AnimalFiles
{
    public class Lizard : Reptile
    {
        public string Camouflage { get; set; }

        public Lizard(int id, string tongueLength, string camouflage)
            : base(id, tongueLength)
        {
            Camouflage = camouflage;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Camouflage} Camouflage    ";
        }
    }
}
