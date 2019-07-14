using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Address
    {
        [JsonProperty(PropertyName = "numero")]
        public int Numero { get; set; }
        [JsonProperty(PropertyName = "rue")]
        public string Rue { get; set; }
        [JsonProperty(PropertyName = "ville")]
        public string Ville { get; set; }
        [JsonProperty(PropertyName = "pays")]
        public string Pays { get; set; }
        [JsonProperty(PropertyName = "codePostale")]
        public int CodePostale { get; set; }
    }
}
