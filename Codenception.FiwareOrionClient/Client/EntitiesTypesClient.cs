using System.Net.Http;
using System.Threading.Tasks;

namespace Codenception.FiwareOrionClient.Client
{
    /// <summary>
    /// This class returns all Types and Types Attributes in the Orion Context Broker
    /// </summary>
    public class TypesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="webClient"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetTypesAsync(WebClient webClient, string endpoint)
        {
            return await webClient.GetAsync(endpoint);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="webClient"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetAttributesForTypeAsync(WebClient webClient, string endpoint)
        {
            return await webClient.GetAsync(endpoint);
        }
    }
}