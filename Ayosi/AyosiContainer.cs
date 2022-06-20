using Ayosi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ayosi
{
    public abstract class AyosiContainer : IBaseContainer, IRegisterable
    {
        private readonly Dictionary<Type, Type> registeredServices;
        public AyosiContainer()
        {
            registeredServices = new Dictionary<Type, Type>();
        }

        public Dictionary<Type, Type> RegisteredServices
        {
            get
            {
                return registeredServices;
            }
        }


        public IBaseContainer Register<TInterfaceType, TImplementationType>() where TImplementationType : TInterfaceType
        {
            registeredServices[typeof(TInterfaceType)] = typeof(TImplementationType);
            return this;
        }

        public void AsSingleton(AyosiContainer ayosiContainer) 
        {

        }

        public object Create(Type type)
        {
            //reflection ile varsayılan constructorı bul

            var concreteType = registeredServices[type];

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

        public void AsSingleton()
        {
            throw new NotImplementedException();
        }

        public int RegisteredServicesCount
        {
            get
            {
                return registeredServices.Count;
            }
        }
    }
}
