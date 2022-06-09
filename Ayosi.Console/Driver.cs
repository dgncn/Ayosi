using System;

namespace ConsoleApp1
{
    public class Driver : IDriver
    {
        public double TotalWorkingHours { get; set; } = 0;

        public void GetHours()
        {
            Console.WriteLine(this.TotalWorkingHours);
        }

        public void Work()
        {
            this.TotalWorkingHours += 24;
        }
    }
}