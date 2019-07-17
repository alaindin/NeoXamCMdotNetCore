using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Employee : User
    {
        [JsonProperty(PropertyName = "dateEmbauche", NullValueHandling = NullValueHandling.Ignore)]
        public string DateEmbauche { get; set; }
        [JsonProperty(PropertyName = "poste", NullValueHandling = NullValueHandling.Ignore)]
        public string Poste { get; set; }
        [JsonProperty(PropertyName = "numTel", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumTel { get; set;  }
        [JsonProperty(PropertyName = "salaire", NullValueHandling = NullValueHandling.Ignore)]
        public int? Salaire { get; set; }
        [JsonProperty(PropertyName = "dep", NullValueHandling = NullValueHandling.Ignore)]
        public Departement Dep { get; set; }
        [JsonProperty(PropertyName = "ListdepAgerer", NullValueHandling = NullValueHandling.Ignore)]
        public List<Departement> ListdepAgerer { get; set; }
        [JsonProperty(PropertyName = "projetsAPiloter", NullValueHandling = NullValueHandling.Ignore)]
        public List<Project> ProjetsAPiloter { get; set; }
        [JsonProperty(PropertyName = "projetsParticipation", NullValueHandling = NullValueHandling.Ignore)]
        public List<Project> ProjetsParticipation { get; set; }
    }
}
