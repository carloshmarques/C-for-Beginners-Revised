﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}; ");
            Console.ReadKey();

        }
    }
}
