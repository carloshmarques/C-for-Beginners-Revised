using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;

namespace MarsInfoAplication
{     
    public class Constants
    {
        public const int SpeedOfLight = 300000;
    }
    public class Mars
    {
      
        public readonly int DistanceToMars = 0;

        public Mars()
        {
            DistanceToMars = Convert.ToInt32(ConfigurationManager.AppSettings["DistanceToMars"]);
            // Continue here:https://youtu.be/yvOdN5PBY2g?list=PL4LFuHwItvKbneXxSutjeyz6i1w32K6di&t=610

        }
        public int GetInfoTravelTime()
        {
             return DistanceToMars/Constants.SpeedOfLight;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Mars mars = new Mars();

                Console.WriteLine($"Information: Travel time of light, is aproximatilly {mars.GetInfoTravelTime()} seconds from mars to earth!");
                Console.ReadKey();
        }

        }
       
    }
}
