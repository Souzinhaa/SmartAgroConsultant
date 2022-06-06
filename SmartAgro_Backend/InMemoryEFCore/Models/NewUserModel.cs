using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryEFCore.Models
{
    public class NewUserModel
    {
        public string nome { get; set; }
        public string nomeUsuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}
