using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Action
    {
        [JsonProperty(PropertyName = "code")]
        public long Code { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
        [JsonProperty(PropertyName = "Label")]
        public string Label { get; set; }
        [JsonProperty(PropertyName = "risquesP")]
        public List<Risk> RisquesP { get; set; }
        [JsonProperty(PropertyName = "risquesC")]
        public List<Risk> RisquesC { get; set; }
    }
}
