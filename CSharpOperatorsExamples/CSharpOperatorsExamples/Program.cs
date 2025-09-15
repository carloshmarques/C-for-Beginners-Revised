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
            // Unary  Operators
            //++
            string line = string.Empty;
            string exampleLabel = string.Empty;

            int a = 1;
            a++;
            //a equals 2
            exampleLabel = "$1: ";
            line =$"{exampleLabel} 'a' equals {a}"; 
            LogToScreen(line);

            bool b = true;
            bool c = !b;
            // c equals false
            exampleLabel = "$2: ";
            line = $"{exampleLabel} 'c' equals {c}";
            LogToScreen(line);

            // Multiplicative
            //*
            int d = 5;
            int e = d * 2;
            exampleLabel = "$3: ";
            line = $"{exampleLabel} 'e' equals {e}";
            LogToScreen(line);

            // continue here:https://youtu.be/qGgwm95FK5M?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=244
        }
        public static void LogToScreen(string line)
        {
            Console.WriteLine(line);
        }

    }
}
