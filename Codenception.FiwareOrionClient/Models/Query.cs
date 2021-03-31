using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class Query
    {
        public List<QueryEntity> QueryEntities
        {
            get; init;
        }

        public List<string> Attributes
        {
            get; init;
        }
    }
}