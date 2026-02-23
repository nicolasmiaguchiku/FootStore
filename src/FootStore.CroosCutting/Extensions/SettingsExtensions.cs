using FootStore.CroosCutting.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace FootStore.CroosCutting.Extensions
{
    public static class SettingsExtensions
    {
        public static Settings GetApplicationSettings(this IConfiguration configuration, IHostEnvironment env)
        {
            var settings = configuration.GetSection("Settings").Get<Settings>()!;

            if (!env.IsDevelopment())
            {
                settings!.MongoSettings.ConnectionString = GetOrDefault("ConnectionString_Mongo", settings.MongoSettings.ConnectionString);
            }

            return settings;
        }

        private static string GetOrDefault(string key, string? fallback)
        {
            var value = Environment.GetEnvironmentVariable(key);
            return string.IsNullOrWhiteSpace(value) ? fallback ?? "" : value;
        }
    }
}