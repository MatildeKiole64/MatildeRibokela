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

namespace MatildeRibokela.DAL
{
    public class ProcessoDAL : IProcessoDAL
    {
        private string StrConexao;
        public ProcessoDAL()
        {
            //StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            StrConexao = "server = localhost; uid = root; pwd = ''; database = ribokeladb ";
        }
        public Guid Create(ProcessoDTO processo)
        {
            Guid Id = Guid.Empty;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();

                using (var TransicaoBD = ConexaoBD.BeginTransaction())
                {
                    string sql = "INSERT INTO processo (id, num_processo, num_registo, local_detencao, instrutor, data_remissao, data_detencao,data_apresentacao,circunst_prisao, manter_prisao) " +
                        "VALUES (@Id, @NrProcesso, @NrRegisto, @LocalDetencao, @Instrutor, @DataRemissaoDist, @DataDetencao, @DataApresentacaoMinistPub, @CircunstPrisao,@ManterPrisao); SELECT LAST_INSERT_ID()";
                    int resultado = ConexaoBD.Execute(sql, processo);
                    if (resultado > 0)
                    {
                        Id = processo.Id;
                        TransicaoBD.Commit();
                    }
                    else
                    {
                        TransicaoBD.Rollback();
                    }
                }
            }
            return Id;
        }

        public int Update(ProcessoDTO processo)
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

                string sql = "SELECT * FROM processo p";

                if (!string.IsNullOrEmpty(NrProc))
                {
                    sql += " WHERE (p.num_processo LIKE @NrProcesso OR p.num_registo LIKE @NrRegisto)";
                    var reader = ConexaoBD.ExecuteReader(sql, new { NrProcesso = "%" + NrProc + "%", NrRegisto = "%" + NrProc + "%" });
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
        public DataTable ListByDataRevisao()
        {
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM processo p, prazo pr WHERE p.id = pr.processo_id AND data_revisao = curdate()";
                var reader = ConexaoBD.ExecuteReader(sql);
                dt.Load(reader);
                return dt;
            }
        }

    }
}
