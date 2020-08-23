using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.IDAL
{
    public interface IDetencaoDAL
    {
        long Create(DetencaoDTO detencao);
        int Update(DetencaoDTO detencao);
        int Delete(DetencaoDTO detencao);
        int Delete(long id);
    }
}
