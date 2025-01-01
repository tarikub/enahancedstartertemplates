using System;
using Xunit;
using CopilotApiDemo;

namespace CopilotApiDemo.Tests
{
    public class WeatherForcastTests
    {
        [Fact]
        public void WeatherForcast_CorrectlyInitializes()
        {
            // Arrange
            var date = DateOnly.FromDateTime(DateTime.Now);
            var temperatureC = 25;
            var summary = "Sunny";

            // Act
            var forecast = new WeatherForcast
            {
                Date = date,
                TemperatureC = temperatureC,
                Summary = summary
            };

            // Assert
            Assert.Equal(date, forecast.Date);
            Assert.Equal(temperatureC, forecast.TemperatureC);
            Assert.Equal(summary, forecast.Summary);
        }

        [Fact]
        public void TemperatureF_CalculatesCorrectly()
        {
            // Arrange
            var forecast = new WeatherForcast { TemperatureC = 25 };

            // Act
            var temperatureF = forecast.TemperatureF;

            // Assert
            Assert.Equal(76, temperatureF);
        }
    }
}
