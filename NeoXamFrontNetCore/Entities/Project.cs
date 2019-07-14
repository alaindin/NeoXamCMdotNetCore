using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{
    public class Project
    {
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
        [JsonProperty(PropertyName = "dateDeb")]
        public DateTime DateDeb { get; set; }
        [JsonProperty(PropertyName = "DateFin")]
        public DateTime DateFin { get; set; }
        [JsonProperty(PropertyName = "avancement")]
        public int Avancement { get; set; }
        [JsonProperty(PropertyName = "designation")]
        public string Designation { get; set; }
        [JsonProperty(PropertyName = "employeeAparticiper")]
        public List<Employee> EmployeeAparticiper { get; set; }
        [JsonProperty(PropertyName = "chefDeProjet")]
        public Employee ChefDeProjet { get; set; }
    }
}
