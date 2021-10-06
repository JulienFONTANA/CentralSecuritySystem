using System.Collections.Generic;

namespace CentralSecuritySystem.Ressources
{
    public static class DisruptionType
    {
        public const string Fire = "Fire";
        public const string Motion = "Motion";
        public const string Door = "Door";
        
        public static IList<string> GetAllPossibleDisruptionTypes()
        {
            return new List<string> { Fire, Motion, Door };
        }
    }
}