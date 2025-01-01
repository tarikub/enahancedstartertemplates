namespace CopilotApiDemo;

public interface IWeatherForcast
{
    DateOnly Date { get; set; }
    string Summary { get; set; }
    int TemperatureC { get; set; }
    int TemperatureF { get; }

    IEnumerable<Weather> GetForecasts();
}