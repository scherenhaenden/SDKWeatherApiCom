using Newtonsoft.Json;

namespace SDKWeatherApiCom.Services.Models.Request;

public class QueryRequestModel
{
    /// <summary>
    /// The query parameter used to specify the search query based on which data is sent back from the API.
    /// It supports a variety of options, and the value of the Query parameter should be set according to the desired search criteria.
    /// </summary>
    /// <remarks>
    /// Possible options for the Query parameter are:
    /// - Latitude and Longitude (Decimal degree) e.g: q=48.8567,2.3508
    /// - City name e.g.: q=Paris
    /// - US zip e.g.: q=10001
    /// - UK postcode e.g: q=SW1
    /// - Canada postal code e.g: q=G2J
    /// - metar:<metar code> e.g: q=metar:EGLL
    /// - iata:<3 digit airport code> e.g: q=iata:DXB
    /// - auto:ip IP lookup e.g: q=auto:ip
    /// - IP address (IPv4 and IPv6 supported) e.g: q=100.0.0.1
    /// - bulk N
    /// </remarks>
    [JsonProperty("q")]
    public string Query { get; set; }
    
    [JsonProperty("key")]
    public string Key { get; set; }
    
    [JsonProperty("aqi")]
    public string AirQualityInformation { get; set; }
    
    
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string PostalCode { get; set; }
    public string Metar { get; set; }
    public string Iata { get; set; }
    public string Auto { get; set; }
    public string Ip { get; set; }
    
}

public class BaseQueryRequestModel
{
    
    /// <summary>
    /// The query parameter used to specify the search query based on which data is sent back from the API.
    /// It supports a variety of options, and the value of the Query parameter should be set according to the desired search criteria.
    /// </summary>
    /// <remarks>
    /// Possible options for the Query parameter are:
    /// - Latitude and Longitude (Decimal degree) e.g: q=48.8567,2.3508
    /// - City name e.g.: q=Paris
    /// - US zip e.g.: q=10001
    /// - UK postcode e.g: q=SW1
    /// - Canada postal code e.g: q=G2J
    /// - metar:<metar code> e.g: q=metar:EGLL
    /// - iata:<3 digit airport code> e.g: q=iata:DXB
    /// - auto:ip IP lookup e.g: q=auto:ip
    /// - IP address (IPv4 and IPv6 supported) e.g: q=100.0.0.1
    /// - bulk N
    /// </remarks>
    [JsonProperty("q")]
    public string Query { get; set; }
    
    [JsonProperty("key")]
    public string Key { get; set; }
    
    [JsonProperty("aqi")]
    public bool AirQualityInformation { get; set; }

    
}


public class CurrentQueryRequestModel: BaseQueryRequestModel
{

    
}

public class SearchQueryRequestModel: BaseQueryRequestModel
{

    
}


public class ForecastQueryRequestModel: BaseQueryRequestModel
{
    [JsonProperty("days")]
    public int Days { get; set; }
    
    [JsonProperty("dt")]
    public int DateOutput { get; set; }
    
    [JsonProperty("unixdt")]
    public string? UnixTimeStamp { get; set; }
    
}