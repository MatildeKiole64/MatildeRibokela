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
    public class ProcessoBLL: IProcessoBLL
    {
        IProcessoDAL processoDAL = new ProcessoDAL();

        public long Create(ProcessoDTO processo)
        {
            long Id = processoDAL.Create(processo);
            return Id;
        }

        public bool Delete(ProcessoDTO processo)
        {
            int resultado = processoDAL.Delete(processo);
            return resultado > 0;
        }

        public bool Delete(int Id)
        {
            int resultado = processoDAL.Delete(Id);
            return resultado > 0;
        }

        public IList<ProcessoDTO> List(string NrProcesso = null)
        {
            return processoDAL.List(NrProcesso);
        }

        public bool Update(ProcessoDTO processo)
        {
            int resultado = processoDAL.Update(processo);
            return resultado > 0;
        }
    }
}
