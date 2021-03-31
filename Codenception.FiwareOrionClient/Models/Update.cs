using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class Update
    {
        public List<Entity> ContextElements
        {
            get; init;
        }

        public string UpdateAction
        {
            get; init;
        }
    }
}