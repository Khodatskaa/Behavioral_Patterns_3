using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class SimpleSystem : HealthMonitoringSystem
    {
        protected override void CheckVitals()
        {
            Console.WriteLine("Checking vitals...");
        }

        protected override void CheckBloodPressure()
        {
            Console.WriteLine("Checking blood pressure...");
        }

        protected override void CheckTemperature()
        {
            Console.WriteLine("Checking temperature...");
        }

        protected override void CheckHeartRate()
        {
            Console.WriteLine("Checking heart rate...");
        }

        protected override void CheckOxygenLevel()
        {
            Console.WriteLine("Checking oxygen level...");
        }

        protected override void NotifyUser()
        {
            Console.WriteLine("Health check complete. Please consult a doctor if any issues are found.");
        }
    }
}
