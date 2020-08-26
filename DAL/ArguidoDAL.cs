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
    public class ArguidoDAL : IArguidoDAL
    {
        private string StrConexao;
        public ArguidoDAL()
        {
            StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        }

        public long Create(ArguidoDTO arguido)
        {
            long Id = 0;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                string sql = "INSERT INTO arguido (nome, idade, residencia_hab, contacto1, contacto2, processo_id) " +
                    "VALUES (@Nome, @Idade, @ResidenciaHabitual, @Contacto1, @Contacto2, @ProcessoId); SELECT LAST_INSERT_ID()";
                Id = ConexaoBD.ExecuteScalar<long>(sql, arguido);
            }
            return Id;
        }

        public int Update(ArguidoDTO arguido)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM arguido";
                var reader = ConexaoBD.ExecuteReader(sql);
                dt.Load(reader);
                return dt;
            }
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
    }
}
