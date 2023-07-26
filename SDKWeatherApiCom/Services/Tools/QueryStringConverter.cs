using System.Reflection;
using System.Web;
using Newtonsoft.Json;

namespace SDKWeatherApiCom.Services.Tools;

public class QueryStringConverter: IQueryStringConverter
{
    /// <summary>
    /// Converts an object to a query string using property names as parameter keys.
    /// </summary>
    public string ConvertObjectToQueryStringUsingPropertyNames(object obj)
    {
        var properties = obj.GetType().GetProperties();
        var keyValuePairs = new List<string>();

        foreach (var property in properties)
        {
            var value = property.GetValue(obj)?.ToString();
            if (value != null)
            {
                var encodedValue = HttpUtility.UrlEncode(value);
                keyValuePairs.Add($"{property.Name}={encodedValue}");
            }
        }

        return string.Join("&", keyValuePairs);
    }

    /// <summary>
    /// Converts an object to a query string using JsonProperty names as parameter keys.
    /// </summary>
    public string ConvertObjectToQueryStringUsingJsonPropertyNames(object obj)
    {
        var properties = obj.GetType().GetProperties();
        var keyValuePairs = new List<string>();

        foreach (var property in properties)
        {
            var jsonPropertyAttr = property.GetCustomAttribute<JsonPropertyAttribute>();
            if (jsonPropertyAttr != null)
            {
                var value = property.GetValue(obj)?.ToString();
                if (value != null)
                {
                    var encodedValue = HttpUtility.UrlEncode(value);
                    keyValuePairs.Add($"{jsonPropertyAttr.PropertyName}={encodedValue}");
                }
            }
        }

        return string.Join("&", keyValuePairs);
    }

    /// <summary>
    /// Converts an object to a query string using JsonProperty names as parameter keys,
    /// and converts bool properties to "yes" or "no" strings.
    /// </summary>
    public string ConvertObjectToQueryStringWithBoolToYesAndNo(object obj)
    {
        var properties = obj.GetType().GetProperties();
        var keyValuePairs = new List<string>();

        foreach (var property in properties)
        {
            var jsonPropertyAttr = property.GetCustomAttribute<JsonPropertyAttribute>();
            if (jsonPropertyAttr != null)
            {
                var value = property.GetValue(obj)?.ToString();
                if (value != null)
                {
                    var encodedValue = HttpUtility.UrlEncode(value);

                    // Convert bool values to "yes" or "no" strings
                    if (property.PropertyType == typeof(bool))
                    {
                        encodedValue = encodedValue.ToLower() == "true" ? "yes" : "no";
                    }

                    keyValuePairs.Add($"{jsonPropertyAttr.PropertyName}={encodedValue}");
                }
            }
        }

        return string.Join("&", keyValuePairs);
    }
}