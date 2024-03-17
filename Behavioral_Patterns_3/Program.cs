using System;

namespace Behavioral_Patterns_3
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple Health Monitoring System:");
            SimpleSystem simpleSystem = new SimpleSystem();
            simpleSystem.MonitorHealth();

            Console.WriteLine("\nAdvanced Health Monitoring System:");

            AdvancedSystem advancedSystem = new AdvancedSystem();

            advancedSystem.SetThreshold("Vitals", 130);
            advancedSystem.SetThreshold("Temperature", 38.0);

            advancedSystem.MonitorHealth();
        }
    }

}
