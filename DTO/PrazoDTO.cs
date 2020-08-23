using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PrazoDTO
    {
        public long Id { get; set; }
        public DateTimeOffset Inicio { get; set; }
        public DateTimeOffset Fim { get; set; }
        public DateTimeOffset DataRevisaoMinistPub { get; set; }
    }
}
