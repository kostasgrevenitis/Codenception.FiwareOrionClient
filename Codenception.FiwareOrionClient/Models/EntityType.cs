using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class EntityType
    {
        public string Name
        {
            get; init;
        }

        public List<string> Attributes
        {
            get; init;
        }
    }
}