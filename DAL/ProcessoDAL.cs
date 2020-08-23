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
                string sql = "INSERT INTO arquivo (caminho, data_upload, categoria_id) VALUES (@Caminho, @DataEntrada, @IdCategoria); SELECT LAST_INSERT_ID()";
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

        public IList<ProcessoDTO> List(string NrProc = null)
        {
            throw new NotImplementedException();
        }
    }
}

