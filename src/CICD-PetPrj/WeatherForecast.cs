namespace CICD_PetPrj
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => TemperatureC * 9 / 5 + 32;

        public string? Summary { get; set; }
    }
}
