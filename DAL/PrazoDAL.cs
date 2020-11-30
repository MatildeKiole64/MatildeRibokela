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
    public class PrazoDAL : IPrazoDAL
    {
        private string StrConexao;
        public PrazoDAL()
        {
            //StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            StrConexao = "server = localhost; uid = root; pwd = ''; database = ribokeladb ";
        }

        public Guid Create(PrazoDTO prazo)
        {
            Guid Id = Guid.Empty;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();

                using (var TransicaoBD = ConexaoBD.BeginTransaction())
                {
                    string sql = "INSERT INTO prazo (id, data_inicio, data_fim, data_revisao, tipo, processo_id) " +
                    "VALUES (@Id, @Inicio, @Fim, @DataRevisaoMinistPub, @Tipo, @ProcessoId); SELECT LAST_INSERT_ID()";
                    int resultado = ConexaoBD.Execute(sql, prazo);
                    if (resultado > 0)
                    {
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

        public DataTable List(ProcessoDTO processoDTO)
        {
            DataTable dt = new DataTable();
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                string sql = "SELECT p.id as id, data_inicio, data_fim, data_revisao, tipo FROM prazo p, processo pc WHERE p.processo_id = pc.id AND pc.id = @Id ORDER BY tipo ASC";
                var reader = ConexaoBD.ExecuteReader(sql, processoDTO);
                dt.Load(reader);
                return dt;
            }
        }
    }
}
