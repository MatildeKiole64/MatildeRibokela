using Dapper;
using DTO;
using MatildeRibokela.IDAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProcessoDAL : IProcessoDAL
    {
        private string StrConexao;
        public ProcessoDAL()
        {
            StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        }

        public long Create(ProcessoDTO processo)
        {
            long Id = 0;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                string sql = "INSERT INTO processo (num_processo, num_registo, local_detencao, instrutor, data_remissao, data_detencao,data_apresentacao,circunst_id,mantidap_id,prazo1_id,prazo2_id,prazo3_id) " +
                    "VALUES (@NrProcesso, @NrRegisto, @LocalDetencao, @Instrutor, @DataRemissaoDist, @DataDetencao, @DataApresentacaoMinistPub, @CircunstId,@MantidapId, @Prazo1Id, @Prazo2Id, @Prazo3Id); SELECT LAST_INSERT_ID()";
                Id = ConexaoBD.ExecuteScalar<long>(sql, processo);
            }
            return Id;
        }

        public int Update(ProcessoDTO processo)
        {
            throw new NotImplementedException();
        }

        public IList<ArguidoDTO> List()
        {
            throw new NotImplementedException();
        }

        public int Delete(ArguidoDTO arguido)
        {
            throw new NotImplementedException();
        }

        public int Delete(long Id)
        {
            int resultado = 0;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                string sql = "DELETE FROM arquivo WHERE id = @Id";
                resultado = ConexaoBD.Execute(sql, new { Id });
            }

            return resultado;
        }

        public int Delete(ProcessoDTO processo)
        {
            int resultado = 0;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                string sql = "DELETE FROM arquivo WHERE id = @Id";
                resultado = ConexaoBD.Execute(sql, processo);
            }

            return resultado;
        }

        public DataTable List(string NrProc = null)
        {
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM nova_view";

                if (!string.IsNullOrEmpty(NrProc))
                {
                    sql += " WHERE NrProcesso LIKE @NrProcesso OR NrRegisto LIKE @NrRegisto";
                    var reader = ConexaoBD.ExecuteReader(sql, new { NrProcesso = "%" + NrProc + "%", NumRegisto = "%" + NrProc + "%" });
                    dt.Load(reader);
                }
                else
                {
                    var reader = ConexaoBD.ExecuteReader(sql);
                    dt.Load(reader);
                }

                return dt;
            }
        }
    }
}