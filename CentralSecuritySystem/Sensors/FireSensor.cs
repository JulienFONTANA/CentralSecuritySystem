using CentralSecuritySystem.InterfacesAndAbstracts;
using CentralSecuritySystem.Ressources;

namespace CentralSecuritySystem.Sensors
{
    public class FireSensor : ASensor
    {
        public FireSensor(string location) 
            : base(location, DisruptionType.Fire) { }
        
        public override void ReturnStatus()
        {
            if (IsTripped)
                BroadcastMessage($"FIRE in {Location}", LoggingLevelEnum.Danger);
            else
                BroadcastMessage($"{Type} sensor report no fire in {Location}", LoggingLevelEnum.Info);
            
            ResetSensor();
        }
    }
}