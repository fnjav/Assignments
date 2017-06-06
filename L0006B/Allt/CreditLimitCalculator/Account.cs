using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLimitCalculator
{
    class Account
    {
        public int Number { get; set; }
        public int BeginningBalance { get; set; }
        public int Charges { get; set; }
        public int Credit { get; set; }
        public int CreditLimit { get; set; }

        public Account(int number, int beginningBalance, int charges, int credit, int creditLimit)
        {
            this.Number = number;
            this.BeginningBalance = beginningBalance;
            this.Charges = charges;
            this.Credit = credit;
            this.CreditLimit = creditLimit;
        }

        public int CalculateNewBalance()
        {
            return BeginningBalance + Charges - Credit;
        }
    }
}
