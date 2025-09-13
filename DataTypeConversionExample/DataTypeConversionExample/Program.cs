using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversionExample
{
    internal class Program
    {
        // Public statements
        public struct ImperialMeasurement
        {
            public float feet;
            // Contructor
            public ImperialMeasurement(float r)
            {
                 this.feet = r;
            }
            // End Constructor for feet
            // static method
            public static explicit operator ImperialMeasurement(int m)
            {
                float covnersionResult = 3.28f * m;
                ImperialMeasurement temp = new ImperialMeasurement(covnersionResult);
                return temp;

            }

            // end method
            
        }
        // End Statements
        static void Main(string[] args)
        {    // link https://youtu.be/NF4lyA1yx8Y?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=811           
            // promt the user to enter a whole number in meters
            Console.WriteLine("Please enter a whole number in meters!");

            int mm = Convert.ToInt32(Console.ReadLine());

            ImperialMeasurement im = (ImperialMeasurement)mm;
            Console.WriteLine($"The measurement of {mm} in meters is {im.feet} in feet");
            Console.ReadKey();
            
        }
    }
}
    
