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
            //Link to source project
            // https://youtu.be/2pquQMSYk6c?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di
            // Set the console window title.//
            Console.Title = "Hello Name";
            string name = "";
            // Display a greeting to the user.//
            // Ask the user for their name and then greet them by name.//
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            // Greet the user by name.//
            Console.WriteLine($"Hello, {name}!");
            // Wait for the user to acknowledge the results.//
            Console.ReadKey();
            // Contnue here: https://youtu.be/2pquQMSYk6c?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=818
        }
    }
}
