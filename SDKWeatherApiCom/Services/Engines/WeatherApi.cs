namespace SDKWeatherApiCom.Services.Engines;

public class WeatherApi: IWeatherApi
{
    private readonly string _apiKey;
    

    public WeatherApi(string apiKey)
    {
        _apiKey = apiKey;
    }

    public object GetCurrentWeatherAsync(object latitude, object longitude)
    {
        // not implemented
        return null;
    }

    public object GetWeatherForecastAsync(object cityName, object country)
    {
        // not implemented
        return null;
    }
}