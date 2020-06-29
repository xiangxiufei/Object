using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Object.Domain.Shared
{
    public class AppSettings
    {
        private static readonly IConfigurationRoot configuration;

        static AppSettings()
        {
            configuration = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json", false, true)
                               .Build();
        }

        public static class JWT
        {
            public static string SecurityKey => configuration["JWT:SecurityKey"];
            public static string Audience => configuration["JWT:Audience"];
            public static string Issuer => configuration["JWT:Issuer"];
            public static int Expires => Convert.ToInt32(configuration["JWT:Expires"]);
        }
    }
}