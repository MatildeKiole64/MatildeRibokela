using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.IDAL
{
    public interface IProcessoDAL
    {
        long Create(ProcessoDTO processo);
        int Update(ProcessoDTO processo);
        int Delete(ProcessoDTO processo);
        int Delete(long id);
        IList<ProcessoDTO> List(string NrProc = null);
    }
}
