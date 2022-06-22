using Ayosi.ConsoleDemo.Demo;

namespace Ayosi.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            AyosiContainer minimalContainer = new AyosiContainer();
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
