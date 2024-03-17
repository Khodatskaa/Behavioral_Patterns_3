using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class HealthMonitoringSystem : IHealthMonitoringSystem
    {
        private Dictionary<string, double> thresholds = new Dictionary<string, double>();

        public HealthMonitoringSystem()
        {
            thresholds.Add("Vitals", 120);
            thresholds.Add("Temperature", 37.5);
            thresholds.Add("HeartRate", 100);
            thresholds.Add("BloodPressure", 120);
            thresholds.Add("OxygenLevel", 95);
        }

        public void MonitorHealth()
        {
            CheckVitals();
            CheckBloodPressure();
            CheckTemperature();
            CheckHeartRate();
            CheckOxygenLevel();
            NotifyUser();
        }

        private void CheckVitals()
        {
            Console.WriteLine("Checking Vitals...");
        }

        private void CheckBloodPressure()
        {
            Console.WriteLine("Checking Blood Pressure...");
        }

        private void CheckTemperature()
        {
            Console.WriteLine("Checking Temperature...");
        }

        private void CheckHeartRate()
        {
            Console.WriteLine("Checking Heart Rate...");
        }

        private void CheckOxygenLevel()
        {
            Console.WriteLine("Checking Oxygen Level...");
        }

        private void NotifyUser()
        {
            Console.WriteLine("Notifying User...");
        }
    }
}