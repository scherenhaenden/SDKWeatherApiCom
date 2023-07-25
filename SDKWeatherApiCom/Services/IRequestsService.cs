using Newtonsoft.Json;
using SDKWeatherApiCom.Services.Models.Request;
using SDKWeatherApiCom.Services.Models.Response;

namespace SDKWeatherApiCom.Services;

public interface IRequestsService
{
    public Task<TemperaturesResponseModel> GetCurrent(WeatherApiRequestCurrentModel requestModel);
    
    public Task<List<SearchResponseModel>> Search(WeatherApiRequestCurrentModel requestModel);
}

public class RequestsService: IRequestsService
{
    private readonly string _baseUrl;

    public RequestsService(string baseUrl)
    {
        _baseUrl = baseUrl;
    }
    
    
    public Task<TemperaturesResponseModel> GetCurrent(WeatherApiRequestCurrentModel requestModel)
    {
        var currentUrl = _baseUrl + "/current." + (requestModel.Json ? "json" : "xml");
        
        currentUrl += "?key=" + requestModel.Key;
        
        // for now only city
        currentUrl += $"&q={requestModel.QueryRequestModel.City}";
        
        currentUrl += $"&aqi={(requestModel.Aqi ? "yes" : "no")}";
        
        var client = new HttpClient();
        
        var response = client.GetAsync(currentUrl);
        response.Wait();
        var result = response.Result;
        var content = result.Content.ReadAsStringAsync();
        content.Wait();
        var values = content.Result;
        var temps = JsonConvert.DeserializeObject<TemperaturesResponseModel>(values);
        return Task.FromResult(temps);
    }
    
    public Task<List<SearchResponseModel>> Search(WeatherApiRequestCurrentModel requestModel)
    {
        var currentUrl = _baseUrl + "/search." + (requestModel.Json ? "json" : "xml");
        
        currentUrl += "?key=" + requestModel.Key;
        
        // for now only city
        currentUrl += $"&q={requestModel.QueryRequestModel.City}";
        
        currentUrl += $"&aqi={(requestModel.Aqi ? "yes" : "no")}";
        
        var client = new HttpClient();
        
        var response = client.GetAsync(currentUrl);
        response.Wait();
        var result = response.Result;
        var content = result.Content.ReadAsStringAsync();
        content.Wait();
        var values = content.Result;
        var temps = JsonConvert.DeserializeObject<List<SearchResponseModel>>(values);
        return Task.FromResult(temps);
    }
    
}