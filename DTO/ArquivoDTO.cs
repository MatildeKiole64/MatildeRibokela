using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ArquivoDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public decimal Tamanho { get; set; }
        public DateTime DataEntrada { get; set; }
        public CategoriaDTO Categoria { get; set; }
    }
}
