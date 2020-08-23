using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.IDAL
{
    public interface IPrazoDAL
    {
        long Create(PrazoDTO prazo);
    }
}
