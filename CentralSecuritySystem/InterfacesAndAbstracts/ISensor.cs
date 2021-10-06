namespace CentralSecuritySystem.InterfacesAndAbstracts
{
    public interface ISensor
    {
        string Location { get; }
        string Type { get; }
        
        void TripSensor();
        void ResetSensor();
        void ReturnStatus();
        void IsTriggered(string location, string type);
    }
}