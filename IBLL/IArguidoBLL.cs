using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IArguidoBLL
    {
        bool Create(ArguidoDTO arguido);
        bool Update(ArguidoDTO arguido);
        bool Delete(ArguidoDTO arguido);
        bool Delete(long id);
        List<ArguidoDTO>List();
    }
}
