using DAL;
using DTO;
using IBLL;
using MatildeRibokela.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProcessoBLL : IProcessoBLL
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

        public List<ProcessoDTO> List(string NrProcesso = null)
        {
            DataTable dt = processoDAL.List(NrProcesso);
            List<ProcessoDTO> processos = new List<ProcessoDTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CircunstanciaDTO circunstancia = new CircunstanciaDTO()
                {
                    Circunstancia = dt.Rows[i]["Circunstancia"].ToString(),
                };
                ProcessoDTO processo = new ProcessoDTO()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["id"]),
                    Instrutor = dt.Rows[i]["Instrutor"].ToString(),
                    DataApresentacaoMinistPub = Convert.ToDateTime(dt.Rows[i]["DataApresentacao"]),
                    DataDetencao = Convert.ToDateTime(dt.Rows[i]["DataDetencao"].ToString()),
                    DataRemissaoDist = Convert.ToDateTime(dt.Rows[i]["DataRemissao"].ToString()),
                    LocalDetencao = dt.Rows[i]["LocalDetencao"].ToString(),
                    // MantidapId = Convert.ToInt32(dt.Rows[i]["MantidaPrisao"]),
                    Circunstancia = circunstancia,
                    NrProcesso = dt.Rows[i]["NrProcesso"].ToString(),
                    NrRegisto = dt.Rows[i]["NrRegisto"].ToString(),
                    Prazo1Id = Convert.ToInt32(dt.Rows[i]["Prazo1_id"]),
                    Prazo2Id = Convert.ToInt32(dt.Rows[i]["Prazo2_id"]),
                    Prazo3Id = Convert.ToInt32(dt.Rows[i]["Prazo3_id"]),
                };

                processos.Add(processo);
            }
            return processos;
        }

        public bool Update(ProcessoDTO processo)
        {
            int resultado = processoDAL.Update(processo);
            return resultado > 0;
        }
    }
}
