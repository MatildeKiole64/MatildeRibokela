using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IProcessoBLL
    {
        long Create(ProcessoDTO processo);
        bool Update(ProcessoDTO processo);
        bool Delete(ProcessoDTO processo);
        bool Delete(int Id);
        List<ProcessoDTO> List(string NumProcesso = null);
    }
}
