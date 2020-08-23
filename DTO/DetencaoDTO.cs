using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO 
{
    public class DetencaoDTO 
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public bool Flagrante { get; set; }
        public DateTime DataApresentacaoMinistPub { get; set; }
    }
}