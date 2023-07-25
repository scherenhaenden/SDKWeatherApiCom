using Newtonsoft.Json;

namespace SDKWeatherApiCom.Services.Models.Response;

public class TemperaturesResponseModel
{
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public LocationResponseModel LocationModel { get; set; }

    [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
    public CurrentResponseModel Current { get; set; }
}


public partial class SearchResponseModel

{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("lat")]
    public double Lat { get; set; }

    [JsonProperty("lon")]
    public double Lon { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

