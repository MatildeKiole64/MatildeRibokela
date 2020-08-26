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
        public DateTime DataRemissaoDist { get; set; }
        public long MantidapId { get; set; }
        public string Instrutor { get; set; }
        public long CircunstId { get; set; }
        public DateTime DataDetencao { get; set; }
        public string LocalDetencao { get; set; }
        public DateTime DataApresentacaoMinistPub { get; set; }
        public long Prazo1Id { get; set; }
        public long Prazo2Id { get; set; }
        public long Prazo3Id { get; set; }
        public CircunstanciaDTO Circunstancia { get; set; }
        
    }
}
