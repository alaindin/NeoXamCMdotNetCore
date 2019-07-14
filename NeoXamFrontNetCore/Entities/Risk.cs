using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Risk
    {
        [JsonProperty(PropertyName = "code")]
        public long Code { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "fait")]
        public string Fait { get; set; }
        [JsonProperty(PropertyName = "actionPreventive")]
        public Action ActionPreventive { get; set; }
        [JsonProperty(PropertyName = "actionConsecutive")]
        public Action ActionConsecutive { get; set; }
    }
}
