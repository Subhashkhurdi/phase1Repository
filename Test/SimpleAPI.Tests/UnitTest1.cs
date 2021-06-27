using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        //Arragnge
        WeatherForecastController wController=new WeatherForecastController();
        [Fact]
        public void Test1()
        {
           //Act
           var output = wController.FetchData(1);
           //Assert
           //Assert.Equal("Amita",output);
           Assert.Equal("Subhash Saini",output);
        }
    }
}
