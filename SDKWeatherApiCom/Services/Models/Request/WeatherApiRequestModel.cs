using SDKWeatherApiCom.Services.Models.Shared;

namespace SDKWeatherApiCom.Services.Models.Request;


public class QueryRequestModel
{
    /*
     *
     * Latitude and Longitude (Decimal degree) e.g: q=48.8567,2.3508
city name e.g.: q=Paris
US zip e.g.: q=10001
UK postcode e.g: q=SW1
Canada postal code e.g: q=G2J
metar:<metar code> e.g: q=metar:EGLL
iata:<3 digit airport code> e.g: q=iata:DXB
auto:ip IP lookup e.g: q=auto:ip
IP address (IPv4 and IPv6 supported) e.g: q=100.0.0.1
bulk 
     * 
     */
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


public class WeatherApiRequestModel
{
    public WeatherApiRequestModel(
        string key,
        QueryRequestModel queryRequestModel
        ) => (key, queryRequestModel) = (Key, QueryRequestModel);
    
    public string Key { get; init; }
    
    public QueryRequestModel QueryRequestModel { get; set; }
    public bool Aqi { get; set; }
    public string Unixdt { get; set; }
    public LanguageCode Language { get; set; }
    public bool Json { get; set; } = true;
}


public class WeatherApiRequestCurrentModel: WeatherApiRequestModel
{
    public WeatherApiRequestCurrentModel(
        string key,
        QueryRequestModel queryRequestModel
    ) : base(key, queryRequestModel) => (key, queryRequestModel) = (Key, QueryRequestModel);
    

    public string Key { get; init; }
    public QueryRequestModel QueryRequestModel { get; set; }
    public bool Aqi { get; set; }
    public string Unixdt { get; set; }
    public LanguageCode Language { get; set; }
    public bool Json { get; set; } = true;
}