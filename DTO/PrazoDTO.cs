using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class PrazoDTO
    {
        public long Id { get; set; } 
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime DataRevisaoMinistPub { get; set; }
    }
}
