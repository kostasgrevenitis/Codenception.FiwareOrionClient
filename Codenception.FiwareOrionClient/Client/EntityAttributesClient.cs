using System.Net.Http;
using System.Threading.Tasks;

namespace Codenception.FiwareOrionClient.Client
{
    public class EntityAttributesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="client"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetAttributesForEntityAsync(WebClient client, string endpoint)
        {
            return await client.GetAsync(endpoint);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="client"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetAttributeValueForEntityAsync(WebClient client, string endpoint)
        {
            return await client.GetAsync(endpoint);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="webclient"></param>
        /// <param name="attribute"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> AddAttributeForEntityAsync(WebClient webclient, string attribute, string endpoint)
        {
            return await webclient.PutAsync(endpoint, attribute);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="webclient"></param>
        /// <param name="attributeValue"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> SetAttributeValueForEntityAsync(WebClient webclient, string attributeValue, string endpoint)
        {
            return await webclient.PutAsync(endpoint, attributeValue);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="webClient"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> DeleteAttributeForEntityAsync(WebClient webClient, string endpoint)
        {
            return await webClient.DeleteAsync(endpoint);
        }
    }
}