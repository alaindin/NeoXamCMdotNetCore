using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Employee : User
    {
        [JsonProperty(PropertyName = "dateEmbauche")]
        public string DateEmbauche { get; set; }
        [JsonProperty(PropertyName = "poste")]
        public string Poste { get; set; }
        [JsonProperty(PropertyName = "numTel")]
        public int NumTel { get; set; }
        [JsonProperty(PropertyName = "salaire")]
        public int Salaire { get; set; }
        [JsonProperty(PropertyName = "dep")]
        public Departement Dep { get; set; }
        [JsonProperty(PropertyName = "ListdepAgerer")]
        public List<Departement> ListdepAgerer { get; set; }
        [JsonProperty(PropertyName = "projetsAPiloter")]
        public List<Project> ProjetsAPiloter { get; set; }
        [JsonProperty(PropertyName = "projetsParticipation")]
        public List<Project> ProjetsParticipation { get; set; }
    }
}
