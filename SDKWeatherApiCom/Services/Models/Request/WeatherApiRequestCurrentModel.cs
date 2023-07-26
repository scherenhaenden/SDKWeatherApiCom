using Newtonsoft.Json;
using SDKWeatherApiCom.Services.Models.Shared;

namespace SDKWeatherApiCom.Services.Models.Request;

public class WeatherApiRequestCurrentModel: WeatherApiRequestModel<CurrentQueryRequestModel>
{
    public WeatherApiRequestCurrentModel(
        string key,
        CurrentQueryRequestModel queryRequestModel
    ) : base(key, queryRequestModel) => (Key, QueryRequestModel) = (key, queryRequestModel);

    public new CurrentQueryRequestModel QueryRequestModel { get; set; }
    public bool Json { get; set; } = true;
}


public class WeatherApiRequestSearchModel: WeatherApiRequestModel<SearchQueryRequestModel>
{
    public WeatherApiRequestSearchModel(
        string key,
        SearchQueryRequestModel queryRequestModel
    ) : base(key, queryRequestModel) => (Key, QueryRequestModel) = (key, queryRequestModel);

    public new SearchQueryRequestModel QueryRequestModel { get; set; }
    
    public bool Json { get; set; } = true;
}


public class WeatherApiRequestForecastModel: WeatherApiRequestModel<ForecastQueryRequestModel>
{
    public WeatherApiRequestForecastModel(
        string key,
        ForecastQueryRequestModel queryRequestModel
    ) : base(key, queryRequestModel) => (Key, QueryRequestModel) = (key, queryRequestModel);
    
    public new ForecastQueryRequestModel QueryRequestModel { get; set; }
    public bool Aqi { get; set; }
    public string Unixdt { get; set; }
    public LanguageCode Language { get; set; }
    public bool Json { get; set; } = true;
    public int Days { get; set; }
}

public class WeatherApiRequestSearchForecastModel
{
    public string Key { get; init; }
    
    
    [JsonProperty("lat")]    // Latitude in decimal degree
    public decimal Latitude { get; set; }

    [JsonProperty("lon")]    // Longitude in decimal degree
    public decimal Longitude { get; set; }

    [JsonProperty("name")]   // Location name
    public string LocationName { get; set; }

    [JsonProperty("region")] // Region or state of the location, if available
    public string Region { get; set; }

    [JsonProperty("country")] // Location country
    public string Country { get; set; }

    [JsonProperty("tz_id")]   // Time zone name
    public string TimeZoneName { get; set; }

    [JsonProperty("localtime_epoch")]   // Local date and time in Unix time
    public int LocalTimeEpoch { get; set; }

    [JsonProperty("localtime")] // Local date and time
    public string LocalTime { get; set; }
}