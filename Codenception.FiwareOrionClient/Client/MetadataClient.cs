using System.Net.Http;
using System.Threading.Tasks;

namespace Codenception.FiwareOrionClient.Client
{
    /// <summary>
    /// The client connects to the Orion instance and retrieves metadata, currently the instance's version only
    /// </summary>
    public class MetadataClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="webClient"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> OrionVersionAsync(WebClient webClient, string uri)
        {
            return await webClient.GetAsync(uri);
        }
    }
}