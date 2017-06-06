// Filip Andersson Vestman  11/12-17
namespace Assignment5.ContactFiles
{
    public class Phone
    {
        public string Personal { get; set; }
        public string Work { get; set; }

        /// <summary>
        /// Returns a string with information
        /// </summary>
        /// <returns>String with information</returns>
        public override string ToString()
        {
            return $"{Personal,-15}{Work,-15}";
        }
    }
}
