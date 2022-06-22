using Ayosi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ayosi
{
    public abstract class BaseContainer : IBaseContainer
    {

        private readonly Dictionary<Type, ContainerService> registeredServices;
        public BaseContainer()
        {
            registeredServices = new Dictionary<Type, ContainerService>();
        }

        public Dictionary<Type, ContainerService> RegisteredServices => registeredServices;


        public IBaseContainer Register<TInterfaceType, TImplementationType>() where TImplementationType : class, TInterfaceType
        {
            var implType = typeof(TImplementationType);

            registeredServices[typeof(TInterfaceType)] = new ContainerService(implType.FullName, implType);
            return this;
        }


        public object Create(Type type)
        {
            //reflection ile varsayılan constructorı bul

            var service = registeredServices[type];
            var concreteType = service.ServiceType;
            var defaultConstructor = concreteType.GetConstructors()[0];


            //varsayılan constructorın parametreleri var mı kontrol eder

            var defaultParams = defaultConstructor.GetParameters();

            //recursion kullanarak tüm parametreleri instantiate ediyoruz

            var parameters = defaultParams
                .Select(param =>
                    Create(param.ParameterType)
                )
                .ToArray();

            return defaultConstructor.Invoke(parameters);
        }

        public void AsSingleton() => throw new NotImplementedException();

        public void Resolve<TService>() => throw new NotImplementedException();

        public int RegisteredServicesCount => registeredServices.Count;
    }
}
