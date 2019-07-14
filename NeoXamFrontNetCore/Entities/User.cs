using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{

    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "nom")]
        public string Nom { get; set; }
        [JsonProperty(PropertyName = "photo")]
        public string Photo { get; set; }
        [JsonProperty(PropertyName = "prenom")]
        public string Prenom { get; set; }
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        [JsonProperty(PropertyName = "registerDate")]
        public DateTime RegisterDate { get; set; }
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }
        [JsonProperty(PropertyName = "osCompleted")]
        public bool IsCompleted { get; set; }
        [JsonProperty(PropertyName = "adresse")]
        public Address Adresse { get; set; }
        [JsonProperty(PropertyName = "diplomes")]
        public List<Diploma> Diplomes { get; set; }
        [JsonProperty(PropertyName = "langues")]
        public List<Language> Langues { get; set; }
        [JsonProperty(PropertyName = "experiences")]
        public List<Experience> Experiences { get; set; }
        [JsonProperty(PropertyName = "trainnings")]
        public List<Trainning> Trainnings { get; set; }
    }
}
