using System.Collections.Generic;
using System.Linq;

namespace Watchman.Configuration.Generic
{
    public class AwsServiceAlarms<TResourceConfig>
        : IAwsServiceAlarms
        where TResourceConfig: class 
    {
        public List<ResourceThresholds<TResourceConfig>> Resources { get; set; }

        public List<string> ExcludeResourcesPrefixedWith { get; set; }

        public Dictionary<string, AlarmValues> Values { get; set; }

        public ResourceConfig Parameters { get; set; }

        List<IResource> IAwsServiceAlarms.Resources
        {
            // todo: why
            get => this.Resources.Select(r => (IResource) r).ToList();
        }

    }
}
