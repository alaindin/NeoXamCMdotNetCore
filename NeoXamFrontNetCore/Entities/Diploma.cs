using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Diploma
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "annee")]
        public DateTime Annee { get; set; }
        [JsonProperty(PropertyName = "etablissement")]
        public string Etablissement { get; set; }
        [JsonProperty(PropertyName = "mention")]
        public string Mention { get; set; }
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }
    }
}
