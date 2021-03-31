using System.Net.Http;
using System.Threading.Tasks;

namespace Codenception.FiwareOrionClient.Client
{
    /// <summary>
    /// The client is related to the entities CRUD operations
    /// </summary>
    public class EntitiesClient
    {
        /// <summary>
        /// Orion Context Broker starts in an empty state (no entities in the database), so first of all we need to make Orion aware of the existence of certain entities.
        /// Read more at <a href="https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#entity-creation">https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#entity-creation</a>
        /// </summary>
        /// <param name="webClient">Method: POST</param>
        /// <param name="newEntity">Response example:
        /// {
        ///     "id": "fe751d70-f26c-4c05-8e05-e814c5d17fac",
        ///     "type": "TestByAtlantis",
        ///     "temperature": {
        ///         "value": 23,
        ///         "type": "Float"
        ///     },
        ///     "pressure": {
        ///     "value": 720,
        ///     "type": "Integer"
        ///     }
        /// }
        /// </param>
        /// <param name="uri">Example: _BASE_URL_/v2/entities</param>
        /// <returns>Upon receipt of this request, Orion creates the entity in its internal database, sets the values for its attributes and responds with a 201 Created HTTP code.</returns>
        public async Task<HttpResponseMessage> AddEntityAsync(WebClient webClient, string newEntity, string uri)
        {
            return await webClient.PostAsync(uri, newEntity);
        }

        /// <summary>
        /// Get all the entities
        /// Read more at <a href="https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#query-entity">https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#query-entity</a>
        /// </summary>
        /// <param name="webClient">Method: GET</param>
        /// <param name="uri">Example: _BASE_URL_/v2/entities</param>
        /// <returns>
        /// {
        ///    "contextResponses": [
        ///        {
        ///            "contextElement": {
        ///                "type": "sacmi_cds_machine",
        ///                "isPattern": "false",
        ///                "id": "24c83f7d-688f-42d6-a106-411a5bf21c6f",
        ///                "attributes": [...]
        ///    },
        ///            "statusCode": {
        ///                "code": "200",
        ///                "reasonPhrase": "OK"
        ///            }
        ///        },
        ///        {
        ///            "contextElement": {
        ///                "type": "sacmi_cds_machine",
        ///                "isPattern": "false",
        ///                "id": "f5a8d53f-ef1d-4108-9001-9427050ef809",
        ///                "attributes": [...]
        ///            },
        ///            "statusCode": {
        ///                "code": "200",
        ///                "reasonPhrase": "OK"
        ///            }
        ///        }
        ///	]
        ///}
        /// </returns>
        public async Task<HttpResponseMessage> GetAllEntitiesAsync(WebClient webClient, string uri)
        {
            return await webClient.GetAsync(uri);
        }

        /// <summary>
        /// If we want a specific entity, we can provide the entity's id in order to retrieve it.
        /// Read more at <a href="https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#query-entity">https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#query-entity</a>
        /// </summary>
        /// <param name="webClient">Method: GET</param>
        /// <param name="uri">Example: _BASE_URL_/v2/entities{id}, {id} is the entity's id</param>
        /// <returns>Response example:
        /// {
        ///     "id": "fe751d70-f26c-4c05-8e05-e814c5d17fac",
        ///     "type": "TestByAtlantis",
        ///     "pressure": {
        ///         "type": "Integer",
        ///         "value": 720,
        ///         "metadata": {}
        ///     },
        ///     "temperature": {
        ///         "type": "Float",
        ///         "value": 23,
        ///         "metadata": {}
        ///     }
        /// }
        /// </returns>
        public async Task<HttpResponseMessage> GetEntityAsync(WebClient webClient, string uri)
        {
            return await webClient.GetAsync(uri);
        }

        /// <summary>
        /// Read more at <a href="https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#update-entity">https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html#update-entity</a>
        /// </summary>
        /// <param name="webClient">Method : PUT</param>
        /// <param name="updateEntity"></param>
        /// <param name="uri">Example: _BASE_URL_/v2/entities/{id}</param>
        /// <returns>It returns a 204 status code</returns>
        public async Task<HttpResponseMessage> UpdateEntityAsync(WebClient webClient, string updateEntity, string uri)
        {
            return await webClient.PutAsync(uri, updateEntity);
        }

        /// <summary>
        /// Read more at <a href="https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html">https://fiware-orion.readthedocs.io/en/master/user/walkthrough_apiv2/index.html</a>
        /// </summary>
        /// <param name="webClient">Method: DELETE</param>
        /// <param name="uri">Example : _BASE_URL_/v2/entities/{id}</param>
        /// <returns>It returns a 204 status code</returns>
        public async Task<HttpResponseMessage> DeleteEntityAsync(WebClient webClient, string uri)
        {
            return await webClient.DeleteAsync(uri);
        }
    }
}