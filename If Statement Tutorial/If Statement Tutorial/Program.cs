using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement_Tutorial
{      // Link https://youtu.be/2mChNV9GmpM?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=93
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMoneyInSavingsAccount = true;
            bool isEnoughToBuyBicycle = false;
            // continue here: https://youtu.be/2mChNV9GmpM?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=251
            if (isMoneyInSavingsAccount)
            {
                Console.WriteLine("I have money!");
                if (isEnoughToBuyBicycle)
                {
                    Console.WriteLine("I have enough money to buy a bicycle");

                }
                else
                {
                    Console.WriteLine("I don't have enough money to buy a bicycle");
                }
            }
            else
            {
                
                Console.WriteLine("I have no money!");
            }
            Console.ReadKey();

            // See Project Part2 to see the conclusion and make sure that itis a startup project!




          
        }

    }
}

