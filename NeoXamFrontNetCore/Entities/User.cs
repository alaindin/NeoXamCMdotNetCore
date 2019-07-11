using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Entities
{

    public class User
    {

        public long Id { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Photo { get; set; }
        public string Prenom { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Role { get; set; }
        public bool IsCompleted { get; set; }
    }
}
