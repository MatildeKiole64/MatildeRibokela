using DAL;
using DTO;
using IBLL;
using MatildeRibokela.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetencaoBLL : IDetencaoBLL
    {
        IDetencaoDAL detencaoDAL = new DetencaoDAL();
        public long Create(DetencaoDTO detencao)
        {
            long Id = detencaoDAL.Create(detencao);
            return Id;
        }
    }
}
