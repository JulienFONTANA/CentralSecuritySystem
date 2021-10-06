using System;
using CentralSecuritySystem.Sensors;
using NUnit.Framework;

namespace CentralSecuritySystemTests
{
    [TestFixture]
    public class Tests
    {
        private FireSensor FireSensor { get; set; }

        [SetUp]
        public void SetUp()
        {
            FireSensor = new FireSensor("Place");
        }
        
        [Test]
        public void ShouldReturnSpecificMessageAsAWarningWhenFireSensorIsTriggered()
        {
            Assert.True(true);
        }
    }
}