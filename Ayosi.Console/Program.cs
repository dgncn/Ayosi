using Ayosi.Console.Demo;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var minimalContainer = new MinimalContainer();
            minimalContainer.Register<ITruck, TruckManagement>();
            minimalContainer.Register<IDriver, Driver>();

            var truckManagement = (TruckManagement)minimalContainer.Create(typeof(ITruck));
            truckManagement.WorkDriver();
            truckManagement.WorkDriver();
            truckManagement.WorkDriver();
            truckManagement.GetTotalWorkingHours();

        }
    }
}
