using Ayosi.ConsoleDemo.Demo;

namespace Ayosi.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var minimalContainer = new MinimalContainer();
            minimalContainer.Register<ITruckManagement, TruckManagement>();
            minimalContainer.Register<IDriver, Driver>();

            var truckManagement = (TruckManagement)minimalContainer.Create(typeof(ITruckManagement));
            truckManagement.WorkDriver();
            truckManagement.WorkDriver();
            truckManagement.WorkDriver();
            truckManagement.GetTotalWorkingHours();

        }
    }

}
