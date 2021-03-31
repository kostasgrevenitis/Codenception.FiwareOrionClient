using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class EntitiesTypesResponse
    {
        public List<EntityType> types
        {
            get; init;
        }

        public StatusCode statusCode
        {
            get; init;
        }
    }
}