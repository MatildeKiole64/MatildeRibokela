using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProcessoDTO
    {
        public long Id { get; set; }
        public string NrProcesso { get; set; }
        public string NrRegisto { get; set; }    
        public DateTimeOffset DataRemissaoDist { get; set; }
        public bool Inconveniencia { get; set; }
        public string Instrutor { get; set; }
        public long DetencaoId { get; set; }
        public long Prazo1Id { get; set; }
        public long Prazo2Id { get; set; }
        public long Prazo3Id { get; set; }
    }
}
