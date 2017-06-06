using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditLimitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random test           


            // Slut på Random test

            while (true)
            {
                int accNum, accBeginningBalance, accCredit, accCharges, accCreditLimit, newBalance;

                Console.WriteLine("Enter account number: ");
                accNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter balance at the beginning of month: ");
                accBeginningBalance = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter total of all items charged by the customer this month: ");
                accCredit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter total of all credits applied to the customer's account this month: ");
                accCharges = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter allowed credit limit: ");
                accCreditLimit = Convert.ToInt32(Console.ReadLine());

                Account tmpAcc = new Account(accNum, accBeginningBalance, accCredit, accCharges, accCreditLimit);
                newBalance = tmpAcc.CalculateNewBalance();

                Console.WriteLine("Account: {0}", accNum);
                if (newBalance > 0)
                {                    
                    Console.WriteLine("New balance is: {0:C}\n", newBalance);                    
                }
                else
                {
                    Console.WriteLine("Credit limit exceeded\n");                    
                }

                Console.WriteLine("Do you wish to continue? Type 0 to exit the program");
                if (Console.ReadLine().Equals("0"))
                {
                   break;
                }
            }        

        }
    }
}
