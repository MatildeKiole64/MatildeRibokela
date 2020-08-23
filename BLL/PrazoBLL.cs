
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
    public class PrazoBLL : IPrazoBLL
    {
        IPrazoDAL prazoDAL = new PrazoDAL();
        public long Create(PrazoDTO prazo)
        {
            long Id = prazoDAL.Create(prazo);
            return Id;
        }

    }
}
