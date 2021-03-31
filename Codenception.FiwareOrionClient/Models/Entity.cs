using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class Entity
    {
        public string Type
        {
            get; init;
        }

        public string IsPattern
        {
            get; init;
        }

        public string Id
        {
            get; init;
        }

        public List<Attribute> Attributes
        {
            get; init;
        }
    }
}