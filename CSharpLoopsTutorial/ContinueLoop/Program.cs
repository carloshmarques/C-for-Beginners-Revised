using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueLoop
{
    internal class Program
    {   // https://youtu.be/oO0GXIIE56U?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=379
        static void Loop10WhileLoopContinueAt5()
        {
            int x = 0;
            const int maxCount = 11;
            while (x < maxCount)
            {
                if (x == 5)
                {
                    x++;
                    continue;
                }

                Console.WriteLine($"The value of 'x' is {x}");
                x++;


            }
           
        

        }
        static void Main(string[] args)
        {
            Loop10WhileLoopContinueAt5();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
     
    }
}
