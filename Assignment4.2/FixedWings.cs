using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    public class FixedWings : Airplane
    {

        public string PlaneType { get; set; }
        public double MinRunwayLength { get; set; }

        // constructor
        public FixedWings(string id, string model, double cruiseSpeed, double emptyWeight, double maxTakeoff, double fuelCapacity, string planeType, double minRunwayLength) : base(id, model, cruiseSpeed, emptyWeight, maxTakeoff, fuelCapacity)
        {
      
            PlaneType = planeType;
            this.MinRunwayLength = minRunwayLength;
        }

        public override void Fly()
        {
            Console.WriteLine("FixedWings");
        }
    }
}
