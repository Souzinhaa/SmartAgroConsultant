using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryEFCore.Models
{
    public class UserDefModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public bool visibilidade { get; set; }
        public bool login { get; set; }
    }
}
