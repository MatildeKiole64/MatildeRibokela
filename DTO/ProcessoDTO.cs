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
        public Guid Id { get; set; }
        public string NrProcesso { get; set; }
        public string NrRegisto { get; set; }
        public DateTime DataRemissaoDist { get; set; } 
        public DateTime DataDetencao { get; set; }
        public string LocalDetencao { get; set; }
        public DateTime DataApresentacaoMinistPub { get; set; }
        public string Instrutor { get; set; }
        public List<ArguidoDTO> Arguidos { get; set; }
        public TipoP CircunstPrisao { get; set; }
        public TipoM ManterPrisao {get; set;}
        public List<PrazoDTO> Prazos { get; set; }
        public enum TipoP
        {
            Flagrante = 1,
            Mandado = 2,
        }
        public enum TipoM
        {
            Inadmissibilidade = 1,
            Inconveniencia = 2,
        }

    }
}
