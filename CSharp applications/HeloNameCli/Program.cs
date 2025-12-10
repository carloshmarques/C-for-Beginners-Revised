using System;
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
            // Link to tutorial source project
            // https://youtu.be/2pquQMSYk6c?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di
            // Set the console window title.//
            Console.Title = "Hello Name";
            // Console Greats the user
            Console.WriteLine("Hello, what is your name?");
            // Declare a variable to store the user's name
            var name = Console.ReadLine();
            // Console Greats the user by name, option 1: using string interpolation
            //  Console.WriteLine($"Hello, {name}; ");   // string interpolation example
            // Console Greats the user by name,using string interpolaption option 2 
            Console.WriteLine("Hello man, {0}!", name); // {0} is a place holder for the name variable
            Console.ReadKey();
            // Conitnue here:https://youtu.be/2pquQMSYk6c?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=1067
        }
    }
}