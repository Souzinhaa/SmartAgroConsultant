using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryEFCore.Models
{
    public class UserLoginModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public string senha { get; set; }
    }
}
