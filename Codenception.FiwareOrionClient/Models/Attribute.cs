using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class Attribute
    {
        public string Name
        {
            get; init;
        }

        public string Type
        {
            get; init;
        }

        public object Value
        {
            get; init;
        }

        public List<AttributeMetadata> Metadata
        {
            get; set;
        }
    }
}