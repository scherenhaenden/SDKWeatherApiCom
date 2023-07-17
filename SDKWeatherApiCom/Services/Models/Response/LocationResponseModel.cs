using Newtonsoft.Json;

namespace SDKWeatherApiCom.Services.Models.Response;

public class LocationResponseModel
{
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
    public string Region { get; set; }

    [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
    public string Country { get; set; }

    [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
    public double? Lat { get; set; }

    [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
    public double? Lon { get; set; }

    [JsonProperty("tz_id", NullValueHandling = NullValueHandling.Ignore)]
    public string TzId { get; set; }

    [JsonProperty("localtime_epoch", NullValueHandling = NullValueHandling.Ignore)]
    public long? LocaltimeEpoch { get; set; }

    [JsonProperty("localtime", NullValueHandling = NullValueHandling.Ignore)]
    public string Localtime { get; set; }
}