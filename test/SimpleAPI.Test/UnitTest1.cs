using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsInputValue()
        {
            var returnValue = controller.Get(15);
            Assert.Equal(15,returnValue.Value);
        }
    }
}
