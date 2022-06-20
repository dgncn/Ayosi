using Ayosi.ConsoleDemo.Demo;
using Xunit;

namespace Ayosi.Tests
{
    public class RegisterTests
    {
        [Fact]
        public void Container_Count_Should_One_When_Registering_A_Service_To_Container()
        {
            //Arrange
            var minimalContainer = new MinimalContainer();

            //Act
            minimalContainer.Register<IDriver, Driver>();
            var driver = (Driver)minimalContainer.Create(typeof(IDriver));
            driver.Work();

            //Assert
            Assert.Equal(1, minimalContainer.RegisteredServicesCount);
        }

        [Fact]
        public void Check_Singularity_Of_Registered_As_Singleton_Service()
        {
            //Arrange
            var minimalContainer = new MinimalContainer();

            //Act
            minimalContainer.Register<IDriver, Driver>();
            
            //.AsSingleton();
            var driver = (Driver)minimalContainer.Create(typeof(IDriver));
            driver.Work();

            //Assert
            Assert.Equal(1, minimalContainer.RegisteredServicesCount);
        }

    }
}
