using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class ActionModel
    {
        [JsonProperty(PropertyName = "code", NullValueHandling = NullValueHandling.Ignore)]
        public long Code { get; set; }
        [JsonProperty(PropertyName = "date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }
        [JsonProperty(PropertyName = "Label")]
        public string Label { get; set; }
        [JsonProperty(PropertyName = "risquesP", NullValueHandling = NullValueHandling.Ignore)]
        public List<Risk> RisquesP { get; set; }
        [JsonProperty(PropertyName = "risquesC",NullValueHandling =NullValueHandling.Ignore)]
        public List<Risk> RisquesC { get; set; }
    }
}
