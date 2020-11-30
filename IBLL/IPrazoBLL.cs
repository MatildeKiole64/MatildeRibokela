using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IPrazoBLL
    {
        bool Create(PrazoDTO prazo);
        List<PrazoDTO> List(ProcessoDTO processoDTO);
    }
}
