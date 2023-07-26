namespace SDKWeatherApiCom.Services.Tools;

public interface IQueryStringConverter
{
    string ConvertObjectToQueryStringUsingPropertyNames(object obj);
    string ConvertObjectToQueryStringUsingJsonPropertyNames(object obj);
    
    string ConvertObjectToQueryStringWithBoolToYesAndNo(object obj);
}