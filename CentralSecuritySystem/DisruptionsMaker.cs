using System;
using System.Collections.Generic;
using CentralSecuritySystem.Ressources;

namespace CentralSecuritySystem
{
    public class DisruptionsMaker
    {
        private IList<string> AllLocations { get; }
        private IList<string> AllDisruptionTypes { get; }
        private Random Rnd { get; }
        private Presenter Presenter { get; }
        
        protected delegate void Disrupt(string location, string type);

        protected readonly Disrupt CreateDisturbance;
        
        public DisruptionsMaker()
        {
            AllLocations = Location.GetAllPossibleLocations();
            AllDisruptionTypes = DisruptionType.GetAllPossibleDisruptionTypes();
            Rnd = new Random();
            Presenter = new Presenter();
            CreateDisturbance = SecuritySystem.TriggerSensor;
        }

        /// <summary>
        /// Disruptions can be in Kitchen, Garage, Basement or Garden.
        /// Disruptions can be fire, motion or an open door.
        /// An open door in the kitchen will be caught by a sensor,
        /// while a fire in the garden will go unnoticed.
        /// </summary>
        public void GenerateRandomDisruption(bool verbose)
        {
            var location = AllLocations[Rnd.Next(AllLocations.Count - 1)];
            var type = AllDisruptionTypes[Rnd.Next(AllLocations.Count - 1)];
            
            if (verbose)
                Presenter.PrintMessage($"Creation disruption in {location} of type {type}.", LoggingLevelEnum.Debug);

            CreateDisturbance(location, type);
        }
    }
}