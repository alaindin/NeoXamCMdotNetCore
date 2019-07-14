using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Language
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "langue")]
        public string Langue { get; set; }
        [JsonProperty(PropertyName = "niveauEcrit")]
        public int NiveauEcrit { get; set; }
        [JsonProperty(PropertyName = "niveauParle")]
        public int NiveauParle { get; set; }

        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }
    }
}
