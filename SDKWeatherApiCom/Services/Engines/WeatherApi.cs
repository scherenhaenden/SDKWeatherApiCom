using SDKWeatherApiCom.Services.Models.Request;

namespace SDKWeatherApiCom.Services.Engines;

public class WeatherApi: IWeatherApi
{
    private readonly string _apiKey;
    private readonly IRequestsService _requestsService;
    

    public WeatherApi(string apiKey)
    {
        _apiKey = apiKey;
        _requestsService = new RequestsService("https://api.weatherapi.com/v1");
    }

    public async Task<object> GetCurrentWeatherAsync(string cityName)
    {
        
        var currentQueryRequestModel = new CurrentQueryRequestModel()
        {
            Query = "London",
            AirQualityInformation = true,
            Key = _apiKey
        };
        
        var requestModel = new WeatherApiRequestCurrentModel (_apiKey, currentQueryRequestModel)
        {
            Json = true,
            QueryRequestModel = currentQueryRequestModel
        };

        return await _requestsService.GetCurrent(requestModel) ;
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