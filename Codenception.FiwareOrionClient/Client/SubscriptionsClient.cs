using Codenception.FiwareOrionClient.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Codenception.FiwareOrionClient.Client
{
    public class SubscriptionsClient
    {
        /// <summary>
        /// Subscribes the specified URLs for context changes
        /// </summary>
        /// <param name="contextSubscription">The context subscription</param>
        /// <returns>The response object</returns>
        public async Task<HttpResponseMessage> SubscribeAsync(WebClient webClient, string subscription, string uri)
        {
            return await webClient.PostAsync(uri, subscription);
        }

        /// <summary>
        /// Updates the specified context subscription. The subscription needs an id.
        /// </summary>
        /// <param name="contextSubscription">The context subscription</param>
        /// <returns>The response object</returns>
        public async Task<HttpResponseMessage> UpdateSubscriptionAsync(WebClient webClient, string subscription, string uri)
        {
            return await webClient.PostAsync(uri, subscription);
        }

        /// <summary>
        /// Unsubscribes the subscription with the specified subscription id.
        /// </summary>
        /// <param name="subscriptionId">The context subscription id</param>
        /// <returns>The response object</returns>
        public async Task<HttpResponseMessage> UnsubscribeAsync(WebClient webClient, string subscriptionId, string uri)
        {
            return await webClient.PostAsync(uri, JsonConvert.SerializeObject(new Subscription() { SubscriptionId = subscriptionId }));
        }
    }
}