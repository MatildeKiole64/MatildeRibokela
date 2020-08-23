using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.IDAL
{
    public interface IArguidoDAL
    {
        long Create(ArguidoDTO arguido);
        int Update(ArguidoDTO arguido);
        int Delete(ArguidoDTO arguido);
        int Delete(long id);
        IList<ArguidoDTO> List();
    }
}
