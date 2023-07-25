using Microsoft.Extensions.Configuration;
using System;
using Newtonsoft.Json;

namespace SDKWeatherApiCom.Tests.Tools;

public class AppConfig
{
    public string Key { get; set; }
    public Uri BaseUrl { get; set; }
}

public class ReadConfiguration
{

    public AppConfig GetConfig()
    {
        
        return GetAppSettings();
        var environment = GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        if (environment != null)
        {
            
        }
        
        //return configuration.GetSection("AppSettings").Get<AppConfig>();
        return new AppConfig();

    }
    
    
    
    // create method that gets the Environment Variable from the system
    // and returns the value
    public string? GetEnvironmentVariable(string name)
    {
        return Environment.GetEnvironmentVariable(name);
    }
    
    // create method that gets appsettings.json file and returns the value
    public AppConfig? GetAppSettings()
    {
        /*var config = new ConfigurationBuilder()
            .AddJsonFile(myjson, false)
            .Build().GetSection("AppSettings").Get<AppSettings>();*/

        var currentDirectory = Directory.GetCurrentDirectory();
        
        // read text file
        var text = File.ReadAllText("appsettings.json");
        // parse text file to AppSettings
        return JsonConvert.DeserializeObject<AppConfig>(text);



    }
}