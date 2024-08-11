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
            if (!ValidatePlaneType(planeType)) throw new ArgumentException("Invalid plane type for Fixedwing airplane.");
            PlaneType = planeType;
            this.MinRunwayLength = minRunwayLength;
        }

        public override void Fly()
        {
            Console.WriteLine("FixedWings");
        }

        protected override bool ValidateID(string id)
        {
            return id.Length == 7 && id.StartsWith("FW") && id.Substring(2).All(char.IsDigit);
        }


        private bool ValidatePlaneType(string planeType)
        {
            string[] validTypes = { "CAG", "LGR", "PRV" };
            return validTypes.Contains(planeType);
        }
    }
}
