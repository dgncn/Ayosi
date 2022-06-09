using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TruckManagement : ITruck
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
