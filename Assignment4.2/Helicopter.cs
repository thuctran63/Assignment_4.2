using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    public class Helicopter : Airplane
    {
        public double Range { get; set; }

        // constructor

        public Helicopter(string id,string model, double cruiseSpeed, double emptyWeight, double maxTakeoff, double fuelCapacity, double range) : base(id,model, cruiseSpeed, emptyWeight, maxTakeoff, fuelCapacity)
        {

            if (maxTakeoff > emptyWeight * 1.5) throw new ArgumentException("Max takeoff weight exceeds 1.5 times the empty weight.");

            Range = range;
        }

        public override void Fly()
        {
            Console.WriteLine("roated wing");
        } 

        protected override bool ValidateID(string id)
        {
            return id.Length == 7 && id.StartsWith("RW") && id.Substring(2).All(char.IsDigit);
        }
    }
}
