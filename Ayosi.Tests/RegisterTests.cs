using ConsoleApp1;
using System;
using Xunit;

namespace Ayosi.Tests
{
    public class RegisterTests
    {
        [Fact]
        public void Container_Services_Count_Should_One_When_Adding_A_Service_To_Container()
        {
            //Arrange
            int serviceCount = 0;
            Container container = new Container();


            //Action
            container.AddService(typeof(IPersonService));
            serviceCount = container.Count();

            //Assert
            Assert.Equal<int>(1, serviceCount);

        }

        [Fact]
        public void Container_Services_Count_Should_Zero_When_Container_Initialized()
        {
            //Arrange
            int serviceCount = 0;
            Container container = new Container();

            //Action
            serviceCount = container.Count();
            Assert.Equal<int>(0, serviceCount);
        }
    }
}
