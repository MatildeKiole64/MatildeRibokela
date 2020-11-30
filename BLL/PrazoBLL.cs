
using DAL;
using DTO;
using IBLL;
using MatildeRibokela.IDAL;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.BLL
{
    public class PrazoBLL : IPrazoBLL
    {
        IPrazoDAL prazoDAL = new PrazoDAL();
        public bool Create(PrazoDTO prazo)
        {
            Guid Id = prazoDAL.Create(prazo);
            return Id != Guid.Empty;
        }

        public List<PrazoDTO> List(ProcessoDTO processoDTO)
        {
            DataTable dt = prazoDAL.List(processoDTO);
            List<PrazoDTO> Prazos = new List<PrazoDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Prazos.Add
                (
                   new PrazoDTO
                   {
                      Id = Guid.Parse(dt.Rows[i]["id"].ToString()),
                      Inicio = Convert.ToDateTime(dt.Rows[i]["data_inicio"]),
                      Fim = Convert.ToDateTime(dt.Rows[i]["data_fim"]),
                      DataRevisaoMinistPub = Convert.ToDateTime(dt.Rows[i]["data_revisao"]),
                      Tipo = Convert.ToInt32(dt.Rows[i]["tipo"]),
                   }
                );
            }
            return Prazos;
        }
    }
}
