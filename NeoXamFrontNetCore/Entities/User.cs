using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{

    public class User
    {
      
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "nom", NullValueHandling = NullValueHandling.Ignore)]
        public string Nom { get; set; }
        [JsonProperty(PropertyName = "photo", NullValueHandling = NullValueHandling.Ignore)]
        public string Photo { get; set; }
        [JsonProperty(PropertyName = "prenom", NullValueHandling = NullValueHandling.Ignore)]
        public string Prenom { get; set; }
        [JsonProperty(PropertyName = "password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "registerDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RegisterDate { get; set; }
        [JsonProperty(PropertyName = "role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }
        [JsonProperty(PropertyName = "isCompleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsCompleted { get; set; }
        [JsonProperty(PropertyName = "adresse", NullValueHandling = NullValueHandling.Ignore)]
        public Address Adresse { get; set; }
        [JsonProperty(PropertyName = "diplomes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Diploma> Diplomes { get; set; }
        [JsonProperty(PropertyName = "langues", NullValueHandling = NullValueHandling.Ignore)]
        public List<Language> Langues { get; set; }
        [JsonProperty(PropertyName = "experiences", NullValueHandling = NullValueHandling.Ignore)]
        public List<Experience> Experiences { get; set; }
        [JsonProperty(PropertyName = "trainnings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Trainning> Trainnings { get; set; }
    }
}
