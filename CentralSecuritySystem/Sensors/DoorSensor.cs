using CentralSecuritySystem.InterfacesAndAbstracts;
using CentralSecuritySystem.Ressources;

namespace CentralSecuritySystem.Sensors
{
    public class DoorSensor : ASensor
    {
        public DoorSensor(string location)
            : base(location, DisruptionType.Door) { }

        public override void ReturnStatus()
        {
            if (IsTripped)
                BroadcastMessage($"Doors opened in {Location}", LoggingLevelEnum.Info);
            else
                BroadcastMessage($"{Type} sensor report closed doors in {Location}", LoggingLevelEnum.Info);
            
            ResetSensor();
        }
    }
}