using Microsoft.Extensions.Configuration;

namespace Codenception.FiwareOrionClient.Client
{
    /// <summary>
    /// https://devblogs.microsoft.com/premier-developer/setting-up-net-core-configuration-providers/
    /// </summary>
    public class Options
    {
        private readonly IConfiguration _config;

        public Options(IConfigurationRoot configurationRoot)
        {
            _config = configurationRoot;
        }

        public string AttributesPath()
        {
            return _config["AttributesPath"];
        }

        public string AuthTokenHeader()
        {
            return _config["AuthTokenHeader"];
        }

        public string BaseUrl()
        {
            return _config["BaseUrl"];
        }

        public string ContextTypesPath()
        {
            return _config["ContextTypesPath"];
        }

        public string EntitiesPath()
        {
            return _config["EntitiesPath"];
        }

        public string UrlFormatTwoPlaceholders()
        {
            return _config["UrlFormatTwoPlaceholders"];
        }

        public string UrlFormatThreePlaceholders()
        {
            return _config["UrlFormatThreePlaceholders"];
        }

        public string UrlFormatFourPlaceholders()
        {
            return _config["UrlFormatFourPlaceholders"];
        }

        public string UrlFormatFivePlacelolders()
        {
            return _config["UrlFormatFivePlacelolders"];
        }

        public string UrlFormatSixPlacelolders()
        {
            return _config["UrlFormatSixPlacelolders"];
        }

        public string VersionPath()
        {
            return _config["VersionPath"];
        }

        public string PublishPath()
        {
            return _config["PublishPath"];
        }

        public string EntityType()
        {
            return _config["EntityType"];
        }

        public string QueryContextPath()
        {
            return _config["QueryContextPath"];
        }

        public string SubscribeContextPath()
        {
            return _config["SubscribeContextPath"];
        }

        public string UpdateSubscriptionContextPath()
        {
            return _config["UpdateSubscriptionContextPath"];
        }

        public string UnsubscribeContextPath()
        {
            return _config["UnsubscribeContextPath"];
        }

        public string Token()
        {
            return _config["Token"];
        }
    }
}