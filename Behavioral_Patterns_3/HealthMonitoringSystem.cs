using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public abstract class HealthMonitoringSystem : IHealthMonitoringSystem
    {
        public void MonitorHealth()
        {
            CheckVitals();
            CheckBloodPressure();
            CheckTemperature();
            CheckHeartRate();
            CheckOxygenLevel();
            NotifyUser();
        }

        protected abstract void CheckVitals();
        protected abstract void CheckBloodPressure();
        protected abstract void CheckTemperature();
        protected abstract void CheckHeartRate();
        protected abstract void CheckOxygenLevel();

        protected virtual void NotifyUser()
        {
            Console.WriteLine("Health check complete. No issues found.");
        }
    }
}

