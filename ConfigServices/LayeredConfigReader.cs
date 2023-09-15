using System.Collections;
using System.Collections.Generic;

namespace ConfigServices
{
    public class LayeredConfigReader : IConfigReader
    {
        private readonly IEnumerable<IConfigService> services;

        public LayeredConfigReader(IEnumerable<IConfigService> services)
        {
            this.services = services;
        }
        public string GetValue(string name)
        {
            string value = null;
            foreach (var service in services)
            {
                string reValue = service.GetValue(name);
                if (reValue != null)
                {
                    value = reValue;//最后一个不为null，就是结果
                }
            }

            return value;
        }
    }
}