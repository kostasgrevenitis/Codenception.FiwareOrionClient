using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class AttributesResponse
    {
        public string Name
        {
            get; init;
        }

        public List<Attribute> Attributes
        {
            get; init;
        }

        public StatusCode StatusCode
        {
            get; init;
        }
    }
}