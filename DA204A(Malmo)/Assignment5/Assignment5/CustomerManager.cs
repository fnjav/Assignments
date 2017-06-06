using System;
using System.Collections.Generic;

// Filip Andersson Vestman  21/12-17
namespace Assignment5
{
    public class CustomerManager
    {
        private List<Customer> _customers = new List<Customer>();
        public int Count => _customers.Count;

        /// <summary>
        /// Add customer to list
        /// </summary>
        /// <param name="customer">Customer to be added</param>
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        /// <summary>
        /// Returns content as list of strings
        /// </summary>
        /// <returns>List of strings with information for each customer</returns>
        public List<string> ToList()
        {
            List<string> output = new List<string>();
            _customers.ForEach(c => output.Add(c.ToString()));
            return output;
        }

        /// <summary>
        /// Removes contact from customer at index
        /// </summary>
        /// <param name="index">Index of customer</param>
        public void RemoveAt(int index)
        {
            _customers.RemoveAt(index);
        }

        /// <summary>
        /// Returns customer at index
        /// </summary>
        /// <param name="index">Index of customer</param>
        /// <returns></returns>
        public Customer GetAt(int index)
        {
            return _customers[index];
        }

        /// <summary>
        /// Replaces contact of customer at index
        /// </summary>
        /// <param name="index">index of customer</param>
        /// <param name="contact">New contact for customer</param>
        public void ReplaceAt(int index, ContactFiles.Contact contact)
        {
            _customers[index].Contact = contact;
        }

        /// <summary>
        /// Checks if index is within the range of the list of customers
        /// </summary>
        /// <param name="index">Index to be checked</param>
        /// <returns>True if valid, false otherwise</returns>
        public bool CheckIndex(int index)
        {
            return !(index < 0 || index >= Count);
        }
    }
}
