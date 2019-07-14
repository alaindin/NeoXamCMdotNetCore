using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class EvaluationPK
    {
        [JsonProperty(PropertyName = "empId")]
        public long EmpId { get; set; }
        [JsonProperty(PropertyName = "risqueId")]
        public long RisqueId { get; set; }
    }
}
