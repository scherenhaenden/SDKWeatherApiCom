namespace SDKWeatherApiCom.Services.Engines;

public interface IWeatherApi
{
    object GetCurrentWeatherAsync(object latitude, object longitude);
    
    object GetWeatherForecastAsync(object cityName, object country);
}