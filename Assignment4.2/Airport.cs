using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    public class Airport
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double RunwaySize { get; set; }

        public int MaxFixedwingPark { get; set; }
        public List<FixedWings> ListFixedWings { get; set; }
        public int MaxHelicopterPark { get; set; }
        public List<Helicopter> ListHelicopters { get; set; }


        public Airport(string id, string name, double runwaySize, int maxFixedwing, int maxHelicopter)
        {
            ID = id;
            Name = name;
            RunwaySize = runwaySize;
            MaxFixedwingPark = maxFixedwing;
            ListFixedWings = new List<FixedWings>(maxFixedwing);
            MaxHelicopterPark = maxHelicopter;
            ListHelicopters = new List<Helicopter>(maxHelicopter);
        }
    }
}
