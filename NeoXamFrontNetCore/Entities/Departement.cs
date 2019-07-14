using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public partial class Departement
    {
        [JsonProperty(PropertyName = "code")]
        public long Code { get; set; }
        [JsonProperty(PropertyName = "libelle")]
        public string Libelle { get; set; }
        [JsonProperty(PropertyName = "directeur")]
        public Employee Directeur { get; set; }

    }
}
