namespace CopilotApiDemo.WeatherApi;

public class WeatherForcast : IWeatherForcast
{
    public DateOnly Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public IEnumerable<Weather> GetForecasts()
    {
        // Sample implementation
        return new List<Weather>
        {
            new Weather { Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 20, Summary = "Sunny" },
            new Weather { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), TemperatureC = 22, Summary = "Cloudy" }
        };
    }
}
