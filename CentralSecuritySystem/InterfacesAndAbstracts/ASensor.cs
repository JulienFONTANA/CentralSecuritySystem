using CentralSecuritySystem.Ressources;

namespace CentralSecuritySystem.InterfacesAndAbstracts
{
    public abstract class ASensor : ISensor
    {
        public string Location { get; }
        public string Type { get; }
        protected bool IsTripped { get; private set; }

        protected delegate void SendNotification(string message, LoggingLevelEnum logLevel);

        protected readonly SendNotification BroadcastMessage;
        
        protected ASensor(string location, string type)
        {
            Location = location;
            Type = type;
            IsTripped = false;
            BroadcastMessage = Presenter.PrintMessage;
        }
        
        public void TripSensor() => IsTripped = true;
        public void ResetSensor() => IsTripped = false;

        public abstract void ReturnStatus();
        
        public void IsTriggered(string location, string type)
        {
            if (Location == location && Type == type)
            {
                TripSensor();
                ReturnStatus();
            }
        }
    }
}