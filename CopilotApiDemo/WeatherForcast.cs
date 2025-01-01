
namespace CopilotApiDemo
{
    public class WeatherForcast
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public IEnumerable<WeatherForcast> GetForecasts()
        {
            return new List<WeatherForcast>
            {
                new WeatherForcast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now),
                    TemperatureC = 25,
                    Summary = "Sunny"
                }
            };
        }
    }
}