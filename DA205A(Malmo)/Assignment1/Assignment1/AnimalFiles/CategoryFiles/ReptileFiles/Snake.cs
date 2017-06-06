namespace Assignment1.AnimalFiles
{
    public class Snake : Reptile
    {
        public string CrawlSpeed { get; set; }

        public Snake(int id, string tongueLength, string crawlSpeed)
            : base(id, tongueLength)
        {
            CrawlSpeed = crawlSpeed;
        }

        /// <summary>
        /// Returns information about the animal
        /// </summary>
        /// <returns>string with information</returns>
        public override string ToString()
        {
            return base.ToString() + $"{CrawlSpeed} Crawl speed";
        }
    }
}
