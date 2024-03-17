using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class AdvancedSystem : HealthMonitoringSystem
    {
        private readonly Dictionary<string, double> thresholds = new Dictionary<string, double>();

        public AdvancedSystem()
        {
            thresholds.Add("Vitals", 120);
            thresholds.Add("BloodPressure", 80);
            thresholds.Add("Temperature", 37.0);
            thresholds.Add("HeartRate", 100);
            thresholds.Add("OxygenLevel", 95);
        }

        protected override void CheckVitals()
        {
            Console.WriteLine($"Checking vitals (Threshold: {thresholds["Vitals"]})...");
        }

        protected override void CheckBloodPressure()
        {
            Console.WriteLine($"Checking blood pressure (Threshold: {thresholds["BloodPressure"]})...");
        }

        protected override void CheckTemperature()
        {
            Console.WriteLine($"Checking temperature (Threshold: {thresholds["Temperature"]})...");
        }

        protected override void CheckHeartRate()
        {
            Console.WriteLine($"Checking heart rate (Threshold: {thresholds["HeartRate"]})...");
        }

        protected override void CheckOxygenLevel()
        {
            Console.WriteLine($"Checking oxygen level (Threshold: {thresholds["OxygenLevel"]})...");
        }

        public void SetThreshold(string parameter, double value)
        {
            thresholds[parameter] = value;
        }
    }
}