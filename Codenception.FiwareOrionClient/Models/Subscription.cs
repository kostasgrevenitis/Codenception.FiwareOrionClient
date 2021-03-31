using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class Subscription
    {
        public string SubscriptionId
        {
            get; init;
        }

        public List<QueryEntity> Entities
        {
            get; init;
        }

        public List<string> Attributes
        {
            get; init;
        }

        public string Reference
        {
            get; init;
        }

        public string Duration
        {
            get; init;
        }

        public List<NotifyCondition> NotifyConditions
        {
            get; init;
        }

        public string Throttling
        {
            get; init;
        }
    }
}