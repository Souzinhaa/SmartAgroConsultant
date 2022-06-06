using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryEFCore.Models
{
    public class FarmModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int hectares { get; set; }
        public string localizacao { get; set; }
        public string tipoSolo { get; set; }
    }
}
