using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Codenception.FiwareOrionClient.Client
{
    public class WebClient
    {
        private readonly string _authTokenHeader;
        private readonly string _token;

        /// <summary>
        /// Creates a new instance of the default web client.
        /// It is suggested any web client to carry the AuthTokenHeader and Token parameters
        /// </summary>
        /// <param name="authTokenHeader">X-Auth-Token header</param>
        /// <param name="token">Read more here <a href="https://fiware-orion.readthedocs.io/en/master/quick_start_guide/index.html">https://fiware-orion.readthedocs.io/en/master/quick_start_guide/index.html</a></param>
        public WebClient(string authTokenHeader, string token)
        {
            _authTokenHeader = authTokenHeader;
            _token = token;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add(_authTokenHeader, _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return await client.GetAsync(endpoint);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="body">The body content that will be posted</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PostAsync(string endpoint, string body)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add(_authTokenHeader, _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var postContent = new StringContent(body, Encoding.UTF8, "application/json");
                return await client.PostAsync(endpoint, postContent);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="body">The body content that will be posted</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PutAsync(string endpoint, string body)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add(_authTokenHeader, _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var postContent = new StringContent(body, Encoding.UTF8, "application/json");
                return await client.PutAsync(endpoint, postContent);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> DeleteAsync(string endpoint)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add(_authTokenHeader, _token);
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return await client.DeleteAsync(endpoint);
            }
        }
    }
}