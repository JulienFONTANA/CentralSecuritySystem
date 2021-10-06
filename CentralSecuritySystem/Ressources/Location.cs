using System.Collections.Generic;

namespace CentralSecuritySystem.Ressources
{
    public static class Location
    {
        public const string Kitchen = "Kitchen";
        public const string Garage = "Garage";
        public const string Basement = "Basement";
        public const string Garden = "Garden";

        public static IList<string> GetAllPossibleLocations()
        {
            return new List<string> { Kitchen, Garage, Basement, Garden };
        }
    }
}