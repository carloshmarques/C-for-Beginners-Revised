using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOperatorsExamples
{
    internal class Program
    {
        // link: https://youtu.be/qGgwm95FK5M?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=25
        static void Main(string[] args)
        {
            //Unary Operators

            //++

            //E1
            string line = string.Empty;
            string exampleLabel = string.Empty;

            int a = 1;
            a++;
            //a equals 2
            exampleLabel = "E1: ";
            line = $"{exampleLabel}'a' equals {a}";

            LogToScreen(line);

            //!

            //E2
            bool b = true;
            bool c = !b;
            //c equals false
            exampleLabel = "E2: ";
            line = $"{exampleLabel}'c' equals {c}";

            LogToScreen(line);

            //Multiplicative
            //*


            //E3
            int d = 5;
            int e = d * 2;
            //e equals 10
            exampleLabel = "E3: ";
            line = $"{exampleLabel}'e' equals {e}";

            LogToScreen(line);

            // /

            //E4
            int f = 10;
            int g = f / 2;
            //g equals 5
            exampleLabel = "E4: ";
            line = $"{exampleLabel}'g' equals {g}";

            LogToScreen(line);

            // %

            //E5
            int h = 10;
            int i = h % 3;
            //i equals 1
            exampleLabel = "E5: ";
            line = $"{exampleLabel}'i' equals {i}";

            LogToScreen(line);

            //Additive Operators

            // docs: https://github.com/GavinLonDigital/CSharpOperatorExamples/blob/master/CSharpOperatorExamples/Program.cs
            // continue here:https://youtu.be/qGgwm95FK5M?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=244
        }
        public static void LogToScreen(string line)
        {
            Console.WriteLine(line);
        }

    }
}
