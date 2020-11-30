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
            //StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
            StrConexao = "server = localhost; uid = root; pwd = ''; database = ribokeladb ";
        }

        public Guid Create(ArguidoDTO arguido)
        {
            Guid Id = Guid.Empty;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();

                using (var TransicaoBD = ConexaoBD.BeginTransaction())
                {
                    string sql = "INSERT INTO arguido (id,nome, idade, residencia_hab, contacto1, contacto2, processo_id) " +
                        "VALUES (@Id,@Nome, @Idade, @ResidenciaHabitual, @Contacto1, @Contacto2, @ProcessoId);";
                    int resultado = ConexaoBD.Execute(sql, arguido);
                    if (resultado > 0) 
                    {
                        Id = arguido.Id;
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

        public DataTable List(ProcessoDTO processoDTO)
        {
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                DataTable dt = new DataTable();
                string sql = "SELECT a.id as id, nome, idade, residencia_hab, contacto1, contacto2, processo_id FROM arguido a, processo p WHERE a.processo_id = p.id AND a.processo_id = @Id";
                var reader = ConexaoBD.ExecuteReader(sql, processoDTO);
                dt.Load(reader);
                return dt;
            }
        }
    }
}
