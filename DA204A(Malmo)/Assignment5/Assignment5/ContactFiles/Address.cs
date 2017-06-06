using System;

// Filip Andersson Vestman  11/12-17
namespace Assignment5.ContactFiles
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public Countries Country { get; }

        /// <summary>
        /// Default constructor with empty values and Sweden as default country.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {

        }

        /// <summary>
        /// Constructor with Sweden as default country
        /// </summary>
        /// <param name="street">Name of street</param>
        /// <param name="city">Name of city</param>
        /// <param name="zip">Zip code</param>
        public Address(string street, string city, string zip) : this(street, city, zip, Countries.Sverige)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="street">Name of street</param>
        /// <param name="city">Name of city</param>
        /// <param name="zip">Zip code</param>
        /// <param name="country">Country</param>
        public Address(string street, string city, string zip, Countries country)
        {
            Street = street;
            City = city;
            Zip = zip;
            Country = country;
        }

        /// <summary>
        /// Makes sure city isn't empty
        /// </summary>
        /// <param name="city"></param>
        /// <returns>True is string isn't empty, false otherwise</returns>
        static public bool CheckCity(string city)
        {
            return !string.IsNullOrWhiteSpace(city);
        }

        /// <summary>
        /// Returns a string with information
        /// </summary>
        /// <returns>String with information</returns>
        public override string ToString()
        {
            return $"{Street,-20}{Zip,-10}{City,-20}{Country.ToString().Replace('_', ' '),-20}";
        }

    }
}
