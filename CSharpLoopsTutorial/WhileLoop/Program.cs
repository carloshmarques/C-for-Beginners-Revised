using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{   // https://youtu.be/oO0GXIIE56U?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=268
    
    internal class Program
    
    {
        static void Loop10WhileLoop()
        {
            int x = 0;
            const int maxCount = 11;
            while (x < maxCount) 
            { 
                Console.WriteLine($"The value of 'x' is {x}");
                x++;
            }

        }
        static void Main(string[] args)
        {
            Loop10WhileLoop();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


