using System.Diagnostics;
using SDKWeatherApiCom.Services;
using SDKWeatherApiCom.Services.Models.Request;
using SDKWeatherApiCom.Tests.Tools;

namespace SDKWeatherApiCom.Tests.Services;

public class IRequestsService_Tests
{
    AppConfig _appConfig;
    
    // write right tests
    [SetUp]
    public void Setup()
    {
        ReadConfiguration readConfiguration = new ReadConfiguration();
        _appConfig = readConfiguration.GetConfig();
    }
    
    [Test]
    public async Task Test1_Current()
    {
        var key= _appConfig.Key;
        
        IRequestsService service = new RequestsService("https://api.weatherapi.com/v1");//.GetCurrent("London", true, true);

        //init request model
        var queryRequestModel = new QueryRequestModel()
        {
            City = "London"
        };
        
        
        var requestModel = new WeatherApiRequestCurrentModel (key, queryRequestModel)
        {
            Json = true,
            Aqi = true
        };

        var result = await service.GetCurrent(requestModel) ;
       
        //return result;
        Console.WriteLine(result);
        Assert.IsNotNull(result.Current);
    }
    
    [Test]
    public async Task Test2_Search()
    {
        var key= _appConfig.Key;
        
        IRequestsService service = new RequestsService("https://api.weatherapi.com/v1");//.GetCurrent("London", true, true);

        //init request model
        var queryRequestModel = new QueryRequestModel()
        {
            City = "London"
        };
        
        
        var requestModel = new WeatherApiRequestCurrentModel (key, queryRequestModel)
        {
            Json = true,
            Aqi = false
        };

        var result = await service.Search(requestModel) ;
       
        //return result;
        Console.WriteLine(result);
        Assert.IsNotNull(result);
    }
}