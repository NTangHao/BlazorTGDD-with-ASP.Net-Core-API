using CloneTGDD.Web.Models;

namespace CloneTGDD.Web
{
    public class WeatherApiClient(HttpClient client)
    {
        private readonly string remoteServiceBaseUrl = "/api/weatherforecast";
        public async Task<WeatherForecast[]> GetWeatherForecasts() =>
            await client.GetFromJsonAsync<WeatherForecast[]>(remoteServiceBaseUrl) ?? [];
    }
}
