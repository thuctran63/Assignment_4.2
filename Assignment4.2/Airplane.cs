using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    public abstract class Airplane
    {
        public string ID { get; set; }
        public string Model { get; set; }
        public double CruiseSpeed { get; set; }
        public double EmptyWeight { get; set; }
        public double MaxTakeoffWeight { get; set; }
        public double FuelCapacity { get; set; }

        public Airplane(string id,string model, double cruiseSpeed, double emptyWeight, double maxTakeoff, double fuelCapacity)
        {
     

            this.ID = id;
            this.Model = model;
            this.CruiseSpeed = cruiseSpeed;
            this.EmptyWeight = emptyWeight;
            this.MaxTakeoffWeight = maxTakeoff;
            this.FuelCapacity = fuelCapacity;

        }

        public abstract void Fly();
    }
}
