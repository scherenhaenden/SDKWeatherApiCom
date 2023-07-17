using SDKWeatherApiCom.Services;
using SDKWeatherApiCom.Services.Models.Request;
using SDKWeatherApiCom.Tests.Tools;

namespace SDKWeatherApiCom.Tests.Services;

public class IRequestsService_Tests
{
    // write right tests
    [SetUp]
    public void Setup()
    {
        ReadConfiguration readConfiguration = new ReadConfiguration();
        readConfiguration.GetConfig();
    }
    
    [Test]
    public async Task Test1()
    {
        var key= "8663e373364c40f7971133602231607";
        
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
        
        Assert.IsNotNull(result.Current);
    }
}