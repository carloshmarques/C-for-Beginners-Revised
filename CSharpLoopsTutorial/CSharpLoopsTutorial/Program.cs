using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLoopsTutorial
{   // https://youtu.be/oO0GXIIE56U?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=3
    // LoopsLesson
    internal class Program
    {
       
        // This method shows how a "do while" loop works in C#
        static void Loop10WhileLoop()
        {
            int x = 0;
            const int maxCount = 11;

            // We want to show numbers from 0 to 10.
            // So we stop when x reaches 11.
            // The "do while" loop runs at least one time.
            // It keeps running while x is less than maxCount.
            /*
             * do
             * {
             *  // code
             *  }
             *  while(false)(code executes once)
             *  
             *  while(false)
             *  { 
             *   //Code  (code will never execute)
             *  }
             */

            // https://youtu.be/oO0GXIIE56U?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=180

        do
        {
            // Show the current value of x
            Console.WriteLine($"The value of 'x' is {x}");

            // Increase x by 1
            x++;

        }
        while (x < maxCount); // Check if x is still less than 11

        }
        static void Main(string[] args)
        {
        // Run the loop method
        Loop10WhileLoop();
        // Wait for a key press before closing the program
        Console.ReadKey();



        }
    }
}
