using System;
namespace Ayosi.ConsoleDemo.Demo
{

    public class Driver : IDriver
    {
        public double TotalWorkingHours { get; set; } = 0;

        public void GetHours()
        {
            Console.WriteLine(TotalWorkingHours);
        }

        public void Work()
        {
            TotalWorkingHours += 24;
        }
    }
}