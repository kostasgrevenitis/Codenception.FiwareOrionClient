namespace Codenception.FiwareOrionClient.Models
{
    public class UnsubscribeResponse
    {
        public string SubscriptionId
        {
            get; init;
        }

        public StatusCode StatusCode
        {
            get; init;
        }
    }
}