using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryEFCore.Models
{
    public class UserReturnModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public UserReturnModel(int id, string nm)
        {
            this.id = id;
            this.nome = nm;
        }
    }
}
