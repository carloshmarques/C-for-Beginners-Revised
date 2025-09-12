using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Placeholder for my code here:
            // link: https://youtu.be/NF4lyA1yx8Y?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di
            /// <'Stactically Typed>
            ///     C# is a statically typed at compile time
            ///     This means once, that once you've defined a variable,
            ///     you cannot define the variable again,
            ///     and you can't assign a value of an data type to a variable.
            ///     <example>
            ///     int a = 1;
            ///     string a = "one"
            ///     This example will result in a runtime compile error like so:
            ///     
            ///     "A local variable or function is already defined in this scope.
            ///     Continue here:https://youtu.be/NF4lyA1yx8Y?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=253
            ///     
            /// </'Stactically Typed>
            /*
            short b = 256;
            byte a = Convert.ToByte(b);
            Console.WriteLine($"'b' = {b}");
            Console.ReadKey();
            
            */
            float f = 1000.26f;
            int i = Convert.ToInt32(f);
            string narrative = $"Variable, 'f', which is defined as the 'float' data type, ";
            narrative += $"is initialized to 1000.26,";
            narrative += $"Variable, 'f', is than converted to the 'int' data type before having,{Environment.NewLine}";
            narrative += $"it's value assigned to an integer defined variable, 'i'.{Environment.NewLine}";
            narrative += $"The value stored in the integer variable, 'i', is now {i}.";

            Console.WriteLine(narrative);
            Console.ReadKey();

            // https://youtu.be/NF4lyA1yx8Y?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=582

        }
    }
}
