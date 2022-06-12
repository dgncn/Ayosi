using System;
using System.Collections.Generic;
using System.Text;

namespace Ayosi.ConsoleDemo.Demo
{
    public class TruckManagement : ITruckManagement
    {
        private readonly IDriver _driver;

        public TruckManagement(IDriver driver)
        {
            _driver = driver;
        }

        public void GetTotalWorkingHours()
        {
            _driver.GetHours();
        }

        public void WorkDriver()
        {
            _driver.Work();
        }


    }
}
