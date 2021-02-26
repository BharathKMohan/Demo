using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.test
{
    public class UnitTest1
    {
        WeatherForecastController  controller = new WeatherForecastController(null);

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void GetVal(){
            var retValue = controller.Get();
            Assert.NotEqual("Test Failed", retValue.ToString());
        }

    }
}
