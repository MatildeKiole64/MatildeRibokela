using DAL;
using DTO;
using IBLL;
using MatildeRibokela.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ArguidoBLL : IArguidoBLL
    {
        IArguidoDAL arguidoDAL = new ArguidoDAL();
        public bool Create(ArguidoDTO arguido)
        {
            long Id = arguidoDAL.Create(arguido);
            return Id > 0;
        }

        public bool Delete(ArguidoDTO arguido)
        {
            int resultado = arguidoDAL.Delete(arguido);
            return resultado > 0;
        }

        public bool Delete(long id)
        {
            int resultado = arguidoDAL.Delete(id);
            return resultado > 0;
        }

        public IList<ArguidoDTO> List()
        {
            return arguidoDAL.List();
        }

        public bool Update(ArguidoDTO arguido)
        {
            int resultado = arguidoDAL.Update(arguido);
            return resultado > 0;
        }
    }
}
