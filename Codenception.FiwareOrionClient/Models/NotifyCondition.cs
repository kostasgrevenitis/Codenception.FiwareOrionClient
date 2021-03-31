using System.Collections.Generic;

namespace Codenception.FiwareOrionClient.Models
{
    public class NotifyCondition
    {
        public string Type
        {
            get; init;
        }

        public List<string> ConditionValues
        {
            get; init;
        }
    }
}