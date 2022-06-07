using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PersonService : IPersonService
    {
        public void GetName()
        {
            Console.WriteLine("Name");
        }
    }
}
