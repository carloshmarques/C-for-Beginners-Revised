using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedForLoopDecrementExample
{   // https://youtu.be/oO0GXIIE56U?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=843
    internal class Program
    {
        static void NestedForLoopChildDEcrement()
        {
            const int maxParentForLoopCount = 10;
            const int maxChildForLoopCount = 5;

           
            for (int x = 0; x < maxParentForLoopCount; x++)
            {
                Console.Write($"{x}: ");
                for (int y = maxChildForLoopCount -1; y > -1; y--)
                {
                    Console.Write($"{y} " );
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            NestedForLoopChildDEcrement();
            Console.ReadKey();
        }
    }
}
