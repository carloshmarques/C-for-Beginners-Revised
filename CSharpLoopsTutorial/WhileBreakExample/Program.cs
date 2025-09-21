using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileBreakExample
{
    internal class Program
    {
        // This method shows how to use a "do while" loop with a break condition
        static void Loop10WhileLoopBreakAt4()
        {
            int x = 0;
            const int maxCount = 11;

            Console.WriteLine("Before loop");

            // The loop starts at x = 0
            // It runs while x is less than maxCount (11)
            // But if x reaches 5, we stop early using "break"

            do
            {
                // If x is 5, stop the loop
                if (x == 5)
                {
                    break;
                }

                // Show the current value of x
                Console.WriteLine($"The value of 'x' is {x}");

                // Increase x by 1
                x++;

            } while (x < maxCount); // Keep looping while x is less than 11

            Console.WriteLine("After loop");
        }

        static void Main(string[] args)
        {
            // Run the loop method
            Loop10WhileLoopBreakAt4();

            // Wait for a key press before closing the program
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
