using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Experience
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "dateDeb")]
        public string DateDeb { get; set; }
        [JsonProperty(PropertyName = "dateFin")]
        public string DateFin { get; set; }
        [JsonProperty(PropertyName = "entreprise")]
        public string Entreprise { get; set; }
        [JsonProperty(PropertyName = "poste")]
        public string Poste { get; set; }
        [JsonProperty(PropertyName = "resume")]
        public string Resume { get; set; }
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }
    }
}
