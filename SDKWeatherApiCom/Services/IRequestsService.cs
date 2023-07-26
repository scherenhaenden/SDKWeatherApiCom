using System.Collections.Specialized;
using System.Reflection;
using System.Web;
using SDKWeatherApiCom.Services.Engines;
using SDKWeatherApiCom.Services.Models.Request;
using SDKWeatherApiCom.Services.Models.Response;

namespace SDKWeatherApiCom.Services;

public interface IRequestsService
{
    public Task<TemperaturesResponseModel> GetCurrent(WeatherApiRequestCurrentModel requestModel);
    
    public Task<List<SearchResponseModel>> Search(WeatherApiRequestSearchModel requestModel);

    public Task<TemperaturesResponseModel> GetForecast(WeatherApiRequestForecastModel requestModel);
}