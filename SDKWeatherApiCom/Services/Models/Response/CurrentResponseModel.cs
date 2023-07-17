using Newtonsoft.Json;

namespace SDKWeatherApiCom.Services.Models.Response;

public class CurrentResponseModel
{
    [JsonProperty("last_updated_epoch", NullValueHandling = NullValueHandling.Ignore)]
    public long? LastUpdatedEpoch { get; set; }

    [JsonProperty("last_updated", NullValueHandling = NullValueHandling.Ignore)]
    public string LastUpdated { get; set; }

    [JsonProperty("temp_c", NullValueHandling = NullValueHandling.Ignore)]
    public long? TempC { get; set; }

    [JsonProperty("temp_f", NullValueHandling = NullValueHandling.Ignore)]
    public double? TempF { get; set; }

    [JsonProperty("is_day", NullValueHandling = NullValueHandling.Ignore)]
    public long? IsDay { get; set; }

    [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
    public ConditionResponseModel ConditionResponseModel { get; set; }

    [JsonProperty("wind_mph", NullValueHandling = NullValueHandling.Ignore)]
    public double? WindMph { get; set; }

    [JsonProperty("wind_kph", NullValueHandling = NullValueHandling.Ignore)]
    public long? WindKph { get; set; }

    [JsonProperty("wind_degree", NullValueHandling = NullValueHandling.Ignore)]
    public long? WindDegree { get; set; }

    [JsonProperty("wind_dir", NullValueHandling = NullValueHandling.Ignore)]
    public string WindDir { get; set; }

    [JsonProperty("pressure_mb", NullValueHandling = NullValueHandling.Ignore)]
    public long? PressureMb { get; set; }

    [JsonProperty("pressure_in", NullValueHandling = NullValueHandling.Ignore)]
    public double? PressureIn { get; set; }

    [JsonProperty("precip_mm", NullValueHandling = NullValueHandling.Ignore)]
    public double? PrecipMm { get; set; }

    [JsonProperty("precip_in", NullValueHandling = NullValueHandling.Ignore)]
    public long? PrecipIn { get; set; }

    [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
    public long? Humidity { get; set; }

    [JsonProperty("cloud", NullValueHandling = NullValueHandling.Ignore)]
    public long? Cloud { get; set; }

    [JsonProperty("feelslike_c", NullValueHandling = NullValueHandling.Ignore)]
    public double? FeelslikeC { get; set; }

    [JsonProperty("feelslike_f", NullValueHandling = NullValueHandling.Ignore)]
    public double? FeelslikeF { get; set; }

    [JsonProperty("vis_km", NullValueHandling = NullValueHandling.Ignore)]
    public long? VisKm { get; set; }

    [JsonProperty("vis_miles", NullValueHandling = NullValueHandling.Ignore)]
    public long? VisMiles { get; set; }

    [JsonProperty("uv", NullValueHandling = NullValueHandling.Ignore)]
    public long? Uv { get; set; }

    [JsonProperty("gust_mph", NullValueHandling = NullValueHandling.Ignore)]
    public double? GustMph { get; set; }

    [JsonProperty("gust_kph", NullValueHandling = NullValueHandling.Ignore)]
    public double? GustKph { get; set; }

    [JsonProperty("air_quality", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, double> AirQuality { get; set; }
}


public class ConditionResponseModel
{
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }

    [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
    public string Icon { get; set; }

    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public long? Code { get; set; }
}