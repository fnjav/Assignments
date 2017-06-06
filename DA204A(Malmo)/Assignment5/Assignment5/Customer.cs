// Filip Andersson Vestman  11/12-17
namespace Assignment5
{
    public class Customer
    {
        public ContactFiles.Contact Contact { get; set; }
        public int Id { get; private set; }
        private static int _numberOfObjects = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="contact">Contact information of the customer</param>
        public Customer(ContactFiles.Contact contact)
        {
            Contact = contact;
            _numberOfObjects++;
            Id = _numberOfObjects;
        }

        /// <summary>
        /// Returns information about the customer
        /// </summary>
        /// <returns>Information about the customer</returns>
        public override string ToString()
        {
            return $"{Id,-15}{Contact.ToString()}";
        }
    }
}
