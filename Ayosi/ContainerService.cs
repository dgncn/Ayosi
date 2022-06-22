using Ayosi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ayosi
{

    public class ContainerService : IContainerService
    {
        private ServiceLifetime _serviceLifetime;

        public ContainerService(string name,Type serviceType, ServiceLifetime serviceLifetime = ServiceLifetime.Transient)
        {
            _serviceLifetime = serviceLifetime;
            Name = name;
            ServiceType = serviceType;
        }

        public ServiceLifetime ServiceLifetime
        {
            get { return _serviceLifetime; }
            set { _serviceLifetime = value; }
        }

        public string Name { get; set; }
        public Type ServiceType { get; set; }
    }
}
