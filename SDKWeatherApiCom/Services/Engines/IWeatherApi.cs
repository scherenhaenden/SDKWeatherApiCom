namespace SDKWeatherApiCom.Services.Engines;

public interface IWeatherApi
{
    Task<object> GetCurrentWeatherAsync(string cityName);
    
    object GetCurrentWeatherAsync(object latitude, object longitude);
    
    object GetWeatherForecastAsync(object cityName, object country);
}