using Microsoft.Extensions.Configuration;
using System;

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
        var environment = GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        if (environment != null)
        {
            GetAppSettings(environment, "Key");
        }
        
        
        Console.WriteLine("Enviroment->" + environment);
        var myjson = $"appsettings.{environment}.json";
        myjson = myjson.Replace("..", ".");
        Console.WriteLine("JSON file->" + myjson);
        
        
        var builder = new ConfigurationBuilder()
            
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
 
        var configuration = builder.Build();
 
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
    public string? GetAppSettings(string environment, string name)
    {
        /*var config = new ConfigurationBuilder()
            .AddJsonFile(myjson, false)
            .Build().GetSection("AppSettings").Get<AppSettings>();*/
        
        
        var builder = new ConfigurationBuilder()
            
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appsettings.{environment}.json");
 
        var configuration = builder.Build();
 
        return configuration[name];
    }
}