// Filip Andersson Vestman  11/12-17
namespace Assignment5.ContactFiles
{
    public class Contact
    {
        public Address Address { get; set; }
        public Phone Phone { get; set; }
        public Email Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="address">Address</param>
        /// <param name="phone">Phone</param>
        /// <param name="email">Email</param>
        public Contact(Address address, Phone phone, Email email)
        {
            Address = address;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Checks if first name and last name is null or whitespace
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <returns>True if ok, false if both are null or empty</returns>
        public static bool CheckName(string firstName, string lastName)
        {
            return !(string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName));
        }

        /// <summary>
        /// Returns a string with information
        /// </summary>
        /// <returns>String with information</returns>
        public override string ToString()
        {
            return $"{LastName}, {FirstName} {Address.ToString(),-70} {Phone.ToString(),-50} {Email.ToString(),-50}";
        }
    }
}
