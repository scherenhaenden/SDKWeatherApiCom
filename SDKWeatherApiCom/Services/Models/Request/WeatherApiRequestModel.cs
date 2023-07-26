namespace SDKWeatherApiCom.Services.Models.Request;

public class WeatherApiRequestModel<T> where T: BaseQueryRequestModel
{
    public WeatherApiRequestModel(
        string key,
        T queryRequestModel)
    {
        
        (Key, QueryRequestModel) = (key, queryRequestModel);
    }


    public string Key { get; init; }
    public BaseQueryRequestModel QueryRequestModel { get; set; }

}