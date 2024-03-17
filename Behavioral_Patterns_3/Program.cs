using System;

namespace Behavioral_Patterns_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Health Monitoring System:");

            IHealthMonitoringSystem healthMonitoringSystem = new HealthMonitoringSystem();

            healthMonitoringSystem.MonitorHealth();
        }
    }
}
