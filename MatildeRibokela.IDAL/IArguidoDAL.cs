using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.IDAL
{
    public interface IArguidoDAL
    {
        Guid Create(ArguidoDTO arguido);
        int Update(ArguidoDTO arguido);
        int Delete(ArguidoDTO arguido);
        int Delete(long id);
        DataTable List(ProcessoDTO processoDTO);
        DataTable List();
    }
}
