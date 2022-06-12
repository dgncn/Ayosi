using System;
using System.Collections.Generic;
using System.Linq;

namespace Ayosi.ConsoleDemo.Demo
{
    public class MinimalContainer
    {
        private readonly Dictionary<Type, Type> types = new Dictionary<Type, Type>();

        public void Register<TInterfaceType, TImplementationType>() where TImplementationType : TInterfaceType
        {
            types[typeof(TInterfaceType)] = typeof(TImplementationType);
        }

        public object Create(Type type)
        {
            //reflection ile varsayılan constructorı bul

            var concreteType = types[type];

            var defaultConstructor = concreteType.GetConstructors()[0];


            //varsayılan constructorın parametreleri var mı kontrol eder

            var defaultParams = defaultConstructor.GetParameters();

            //recursion kullanarak tüm parametreleri instantiate ediyoruz

            var parameters = defaultParams.Select(param => Create(param.ParameterType)).ToArray();

            return defaultConstructor.Invoke(parameters);
        }

        public int ContainerCount
        {
            get
            {
                return types.Count;
            }
        }
    }
}
