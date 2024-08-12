using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2.Helper
{
    public class Utilities
    {
        public static bool ValidationID(string id, int type)
        {
            if (!string.IsNullOrEmpty(id))
            {
                switch (type)
                {
                    case 1:
                        if (id.StartsWith("FW") && id.Substring(2).All(char.IsDigit))
                        {
                            return true;
                        }
                        break;
                    case 2:
                        if (id.StartsWith("RW") && id.Substring(2).All(char.IsDigit))
                        {
                            return true;
                        }
                        break;
                    case 3:
                        if (id.StartsWith("AP") && id.Substring(2).All(char.IsDigit))
                        {
                            return true;
                        }
                        break;
                }
            }
            return false;
        }

        public static bool ValidationPlaneType(string planeType)
        {
            string[] validTypes = { "CAG", "LGR", "PRV" };
            return validTypes.Contains(planeType);
        }

        public static bool ValidationMaxTakeOff(double maxTakeOff, double emptyWeight)
        {
            if (maxTakeOff > emptyWeight * 1.5) return false;
            return true;
        }

        public static bool ValidationModelSize(string modelSize)
        {
            if (!string.IsNullOrEmpty(modelSize) && modelSize.Length <= 40) return true;
            return false;

        }

        public static bool CanAccommodateFixedwingRunway(double MinRunwayLength, double RunwaySize)
        {
            if (MinRunwayLength <= RunwaySize) return true;
            return false;
        }

        public static bool CheckAirplaneIsAvailible(string idAirplane, Airport airport)
        {
            var a = airport.ListFixedWings.FirstOrDefault(x => x.ID == idAirplane);
            var b = airport.ListHelicopters.FirstOrDefault(x => x.ID == idAirplane);

            if(a == null && b == null) return false;
            return true;
        }


    }
}
