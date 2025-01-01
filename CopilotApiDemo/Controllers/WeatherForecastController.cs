using Microsoft.AspNetCore.Mvc;

namespace CopilotApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForcast _weatherForecast; 

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForcast weatherForecast) 
        {
            _logger = logger;
            _weatherForecast = weatherForecast; 
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Weather> Get() 
        {
            return _weatherForecast.GetForecasts(); 
        }
    }
}
