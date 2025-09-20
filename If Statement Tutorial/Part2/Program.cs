using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{    // https://youtu.be/2mChNV9GmpM?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=512
    internal class Program
    {
        static void Main(string[] args)
        {   // link: https://youtu.be/2mChNV9GmpM?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=420
            decimal moneyAmountInSavingsAccount = 400;
            decimal costOfBicycle = 1000;
            bool canGetLoan = true;
            decimal maxLoanAmount = 200;

            Console.WriteLine($"Savings: {moneyAmountInSavingsAccount}, Cost: {costOfBicycle}");
            if (moneyAmountInSavingsAccount >= costOfBicycle)
            {
                Console.WriteLine("I have enough money to buy the bicycle");
            }
            else if (canGetLoan && moneyAmountInSavingsAccount + maxLoanAmount >= costOfBicycle)
            {
                Console.WriteLine("I do not have enough money in my savings account to buy the bicycle");
                Console.WriteLine("If I get a loan I will have enough money to buy the bicycle");
            }
            else if (canGetLoan && moneyAmountInSavingsAccount + maxLoanAmount >= costOfBicycle * 0.9m)
            {
                Console.WriteLine("I have over 90% of the money I need to buy the bicycle");
            }
            else if (canGetLoan && moneyAmountInSavingsAccount + maxLoanAmount > costOfBicycle / 2)
            {
                Console.WriteLine("I have over half the money I need to buy the bicycle");
            }
            else
            {
                Console.WriteLine("I do not have enough money to buy the bicycle");
            }
        }
    }
}
