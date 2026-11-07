using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CICD_PetPrj;
using System.Linq;

namespace CICD_PetPrj.UnitTests
{
    public class WeatherForecastTests
    {
        [Theory]
        [InlineData(32, 89)]
        [InlineData(11, 51)]
        [InlineData(100, 211)]
        public void TemperatureF_FromCelsius_ReturnsExpectedFahrenheit(int input, int expectedOutput)
        {
            WeatherForecast weatherForecast = new WeatherForecast() { TemperatureC = input};
            bool isCorrect = int.Equals(weatherForecast.TemperatureF, expectedOutput);
            Assert.True(isCorrect, $"Expected {expectedOutput} but got {weatherForecast.TemperatureF}");
        }
    }
}
