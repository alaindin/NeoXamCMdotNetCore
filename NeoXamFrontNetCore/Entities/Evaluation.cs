using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Evaluation
    {
        [JsonProperty(PropertyName = "id")]
        public EvaluationPK Id { get; set; }
        [JsonProperty(PropertyName = "emp")]
        public Employee Emp { get; set; }
        [JsonProperty(PropertyName = "risque")]
        public Risk Risque { get; set; }
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
        [JsonProperty(PropertyName = "risqueGlobal")]
        public int RisqueGlobal { get; set; }
    }
}
