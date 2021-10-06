using System;
using System.Collections.Generic;
using System.Linq;
using CentralSecuritySystem.InterfacesAndAbstracts;
using CentralSecuritySystem.Ressources;
using CentralSecuritySystem.Sensors;

namespace CentralSecuritySystem
{
    public class SecuritySystem
    {
        private static Presenter Presenter { get; set; }
        private static IEnumerable<ISensor> AllSensors { get; set; }
        
        public SecuritySystem()
        {
            Presenter = new Presenter();
            AllSensors = new List<ISensor>
            {
                new FireSensor(Location.Kitchen),
                new MotionSensor(Location.Kitchen),
                new DoorSensor(Location.Kitchen),
                
                new MotionSensor(Location.Garage),
                new DoorSensor(Location.Garage),
                
                new MotionSensor(Location.Basement),
                new DoorSensor(Location.Basement),
                
                new MotionSensor(Location.Garden)
            };
        }

        public static void TriggerSensor(string location, string type)
        {
            AllSensors.FirstOrDefault(x => x.Location == location && x.Type == type)?.IsTriggered(location, type);
        }

        public void TripAndResertSensors(bool verbose)
        {
            if (verbose)
            {
                Presenter.PrintMessage("Arming and Tripping sensors on purpose, then resetting them.", LoggingLevelEnum.Info);
                foreach (var sensor in AllSensors)
                {
                    sensor.TripSensor();
                    sensor.ReturnStatus();
                    sensor.ResetSensor();
                    sensor.ReturnStatus();
                }
                Presenter.PrintMessage("End of test - sensors ready." + Environment.NewLine, LoggingLevelEnum.Info);
            }
        }
    }
}