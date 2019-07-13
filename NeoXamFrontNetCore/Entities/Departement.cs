using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public partial class Departement
    {
        [JsonProperty(PropertyName ="code")]
        public long Code;
        [JsonProperty(PropertyName = "libelle")]
        public string Libelle;

    }
}
