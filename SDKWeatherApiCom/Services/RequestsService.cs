using Newtonsoft.Json;
using SDKWeatherApiCom.Services.Models.Request;
using SDKWeatherApiCom.Services.Models.Response;
using SDKWeatherApiCom.Services.Tools;

namespace SDKWeatherApiCom.Services;

public class RequestsService: IRequestsService
{
    private readonly string _baseUrl;
    private readonly IQueryStringConverter _queryStringConverter;

    public RequestsService(string baseUrl)
    {
        _baseUrl = baseUrl;
        _queryStringConverter = new QueryStringConverter();
    }
    
    public async Task<TemperaturesResponseModel> GetCurrent(WeatherApiRequestCurrentModel requestModel)
    {
        var currentUrl = _baseUrl + "/current." + (requestModel.Json ? "json" : "xml");

        var currentQueryRequestModel = _queryStringConverter.ConvertObjectToQueryStringWithBoolToYesAndNo(requestModel.QueryRequestModel);
        
        currentUrl += "?" + currentQueryRequestModel;
        
        var client = new HttpClient();
        
        var response = await client.GetAsync(currentUrl);
        var content = await response.Content.ReadAsStringAsync();
        var temperaturesResponseModel = JsonConvert.DeserializeObject<TemperaturesResponseModel>(content);
        return temperaturesResponseModel;
    }

    
    public async Task<List<SearchResponseModel>> Search(WeatherApiRequestSearchModel requestModel)
    {
        var currentUrl = _baseUrl + "/search." + (requestModel.Json ? "json" : "xml");
        
        var currentQueryRequestModel = _queryStringConverter.ConvertObjectToQueryStringWithBoolToYesAndNo(requestModel.QueryRequestModel);
        
        currentUrl += "?" + currentQueryRequestModel;
        
        var client = new HttpClient();
        
        var response = await client.GetAsync(currentUrl);
        var content = await response.Content.ReadAsStringAsync();
        
        var temps = JsonConvert.DeserializeObject<List<SearchResponseModel>>(content);
        return temps;
    }
    
    
    public async Task<TemperaturesResponseModel> GetForecast(WeatherApiRequestForecastModel requestModel)
    {
        var currentUrl = _baseUrl + "/forecast." + (requestModel.Json ? "json" : "xml");
        
        var currentQueryRequestModel = _queryStringConverter.ConvertObjectToQueryStringWithBoolToYesAndNo(requestModel.QueryRequestModel);
        
        currentUrl += "?" + currentQueryRequestModel;
        
        var client = new HttpClient();
        
        var response = await client.GetAsync(currentUrl);
        var content = await response.Content.ReadAsStringAsync();
        var temps = JsonConvert.DeserializeObject<TemperaturesResponseModel>(content);
        return temps;
    }
    
}