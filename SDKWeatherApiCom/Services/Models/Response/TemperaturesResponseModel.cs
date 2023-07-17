using Newtonsoft.Json;

namespace SDKWeatherApiCom.Services.Models.Response;

public class TemperaturesResponseModel
{
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public LocationResponseModel LocationModel { get; set; }

    [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
    public CurrentResponseModel Current { get; set; }
}