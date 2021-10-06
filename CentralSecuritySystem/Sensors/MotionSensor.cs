using CentralSecuritySystem.InterfacesAndAbstracts;
using CentralSecuritySystem.Ressources;

namespace CentralSecuritySystem.Sensors
{
    public class MotionSensor : ASensor
    {
        public MotionSensor(string location) 
            : base(location, DisruptionType.Motion) { }

        public override void ReturnStatus()
        {
            if (IsTripped)
                BroadcastMessage($"Warning : Movement detected in {Location}", LoggingLevelEnum.Warning);
            else
                BroadcastMessage($"{Type} sensor report no movement in {Location}", LoggingLevelEnum.Info);

            ResetSensor();
        }
    }
}