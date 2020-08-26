using Dapper;
using DTO;
using MatildeRibokela.IDAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        }

        public long Create(PrazoDTO prazo, int tipo)
        {

            long Id = 0;
            string sql = string.Empty;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                switch (tipo)
                {
                    case 0:
                        sql = "INSERT INTO prazo1 (data_inicio, data_fim, data_revisao) " +
                        "VALUES (@Inicio, @Fim, @DataRevisaoMinistPub); SELECT LAST_INSERT_ID()";
                        break;
                    case 1:
                        sql = "INSERT INTO prazo2 (data_inicio, data_fim, data_revisao) " +
                        "VALUES (@Inicio, @Fim, @DataRevisaoMinistPub); SELECT LAST_INSERT_ID()";
                        break;
                    case 2:
                        sql = "INSERT INTO prazo3 (data_inicio, data_fim, data_revisao) " +
                        "VALUES (@Inicio, @Fim, @DataRevisaoMinistPub); SELECT LAST_INSERT_ID()";
                        break;
                    default:
                        break;
                }

                Id = ConexaoBD.ExecuteScalar<long>(sql, prazo);
            }
            return Id;
        }

    }
}
