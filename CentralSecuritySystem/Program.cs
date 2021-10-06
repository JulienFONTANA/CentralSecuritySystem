using System.Threading;

namespace CentralSecuritySystem
{
    public static class Program
    {
        public static void Main()
        {
            const bool verbose = true;
            
            var system = new SecuritySystem();
            system.TripAndResertSensors(verbose);
            
            var disruptionsMaker = new DisruptionsMaker();
            for (var i = 0; i < 15; i++)
            {
                disruptionsMaker.GenerateRandomDisruption(verbose);
                Thread.Sleep(2000);
            }
        }
    }
}