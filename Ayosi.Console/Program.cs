using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            container.AddService(typeof(IPersonService));


        }
    }
}
