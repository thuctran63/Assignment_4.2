using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4._2.Helper;

namespace Assignment4._2.Management
{
    public class AirportManagement
    {
        private static List<Airport> airports;

        public static bool AddAirport(Airport a)
        {
            try
            {
                airports.Add(a);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool RemoveAirport(string id)
        {
            try
            {
                var airport = airports.Where(a => a.ID == id).FirstOrDefault();
                if (airport != null)
                {
                    airports.Remove(airport);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return false;
        }

        public static bool AddFixedWings(List<FixedWings> fixedWings, string idAirport)
        {
            try
            {
                if (fixedWings != null)
                {
                    var airport = airports.Where(a => a.ID == idAirport).FirstOrDefault();
                    if (airport != null)
                    {

                        foreach (var item in fixedWings){
                            if (Utilities.CanAccommodateFixedwingRunway(item.MinRunwayLength, airport.RunwaySize) && Utilities.CheckAirplaneIsAvailible(item.ID,airport))
                            {
                                airport.ListFixedWings.Add(item);
                            }
                            else
                            {
                                Console.WriteLine($"Airplane fixedwings {item.ID} is not accommodate");
                            }
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }

        public static bool AddHelicopter(List<Helicopter> helicopters, string idAirport)
        {
            try
            {
                if (helicopters != null)
                {
                    var airport = airports.Where(a => a.ID == idAirport).FirstOrDefault();
                    if (airport != null)
                    {
                        foreach (var item in helicopters)
                        {
                            if(Utilities.CheckAirplaneIsAvailible(item.ID, airport))
                            {
                                airport.ListHelicopters.Add(item);
                            }
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }

        public static bool RemoveHelicopter(List<string> IdHelicopters, string idAirport)
        {
            try
            {
                if (IdHelicopters != null && IdHelicopters.Count > 0)
                {
                    var airport = airports.Where(a => a.ID == idAirport).FirstOrDefault();
                    if (airport != null)
                    {
                        foreach (var idHelicopter in IdHelicopters)
                        {
                            var item = airport.ListHelicopters.Where(h => h.Equals(idHelicopter)).FirstOrDefault();
                            airport.ListHelicopters.Remove(item);
                        }

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }

        public static bool ChangeTypePlane(string type, FixedWings fixedWings)
        {
            if (Utilities.ValidationPlaneType(type))
            {
                fixedWings.PlaneType = type;
                return true;
            }
            return false;
        }

        public static bool ChangeMinRunWaySize(double minRunWaySize, FixedWings fixedWings)
        {
            if(minRunWaySize > 0 && fixedWings != null)
            {
                fixedWings.MinRunwayLength = minRunWaySize;
                return true;
            }
            return false;
        }



        
    }
}
