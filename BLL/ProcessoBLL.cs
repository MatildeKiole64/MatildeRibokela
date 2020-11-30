using MatildeRibokela.DAL;
using DTO;
using IBLL;
using MatildeRibokela.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatildeRibokela.BLL
{
    public class ProcessoBLL : IProcessoBLL
    {
        IProcessoDAL processoDAL = new ProcessoDAL();
        IArguidoBLL arguidoBLL = new ArguidoBLL();
        IPrazoBLL prazoBLL = new PrazoBLL();
        public Guid Create(ProcessoDTO processo)
        {
            Guid Id = processoDAL.Create(processo);
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
        public List<ProcessoDTO> ListByDataRevisao()
        {
            DataTable dt = processoDAL.ListByDataRevisao();
            List<ProcessoDTO> processos = new List<ProcessoDTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ProcessoDTO processo = new ProcessoDTO()
                {
                    Id = Guid.Parse(dt.Rows[i]["id"].ToString()),
                    Instrutor = dt.Rows[i]["Instrutor"].ToString(),
                    DataApresentacaoMinistPub = Convert.ToDateTime(dt.Rows[i]["data_apresentacao"]),
                    DataDetencao = Convert.ToDateTime(dt.Rows[i]["data_detencao"].ToString()),
                    DataRemissaoDist = Convert.ToDateTime(dt.Rows[i]["data_remissao"].ToString()),
                    LocalDetencao = dt.Rows[i]["local_detencao"].ToString(),
                    NrProcesso = dt.Rows[i]["num_processo"].ToString(),
                    NrRegisto = dt.Rows[i]["num_registo"].ToString(),
                };
                processo.Arguidos = arguidoBLL.List(processo);
                processo.Prazos = prazoBLL.List(processo);
                processos.Add(processo);
            }
            return processos;
        }


        public List<ProcessoDTO> List(string NrProcesso = null)
        {
            DataTable dt = processoDAL.List(NrProcesso);
            List<ProcessoDTO> processos = new List<ProcessoDTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ProcessoDTO processo = new ProcessoDTO()
                {
                    Id = Guid.Parse(dt.Rows[i]["id"].ToString()),
                    Instrutor = dt.Rows[i]["Instrutor"].ToString(),
                    DataApresentacaoMinistPub = Convert.ToDateTime(dt.Rows[i]["data_apresentacao"]),
                    DataDetencao = Convert.ToDateTime(dt.Rows[i]["data_detencao"].ToString()),
                    DataRemissaoDist = Convert.ToDateTime(dt.Rows[i]["data_remissao"].ToString()),
                    LocalDetencao = dt.Rows[i]["local_detencao"].ToString(),
                    NrProcesso = dt.Rows[i]["num_processo"].ToString(),
                    NrRegisto = dt.Rows[i]["num_registo"].ToString(),
                    CircunstPrisao = (ProcessoDTO.TipoP)Convert.ToInt32(dt.Rows[i]["circunst_prisao"]),
                    ManterPrisao = (ProcessoDTO.TipoM)Convert.ToInt32(dt.Rows[i]["manter_prisao"])
                };
                processo.Arguidos = arguidoBLL.List(processo);
                processo.Prazos = prazoBLL.List(processo);
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
