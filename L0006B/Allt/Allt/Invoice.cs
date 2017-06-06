using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allt
{
    class Invoice
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public int _quantity;
        public decimal _price;

        // Blir något error med rekursion om jag gör som med number och description här
        // De abstrakta get/set uppför sig nog likadant
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
            }
        }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        // Constructor
        public Invoice(string number, string description, int quantity, decimal price)
        {
            this.Number = number;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;

        }

        public decimal GetInvoiceAmount()
        {
            return Quantity * Price;
        }
    }
    
}
