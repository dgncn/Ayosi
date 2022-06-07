using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Container : IContainer
    {
        private Dictionary<string, object> _registeredServices = new Dictionary<string, object>();


        public void AddService(object service)
        {
            _registeredServices.Add(service.GetType().Name, service.GetType());
        }

        public string Summary()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in _registeredServices)
            {
                stringBuilder.AppendLine($"{item.Value} {item.Key}");
            }
            return stringBuilder.ToString();
        }

        public int Count()
        {
            return _registeredServices.Count;
        }
    }
}
