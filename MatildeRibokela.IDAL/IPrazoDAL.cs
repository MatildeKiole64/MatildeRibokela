using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.IDAL
{
    public interface IPrazoDAL
    {
        Guid Create(PrazoDTO prazo);
        DataTable List(ProcessoDTO processo);
    }
}
