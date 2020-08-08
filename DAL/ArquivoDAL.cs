using Dapper;
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
    public class ArquivoDAL
    {
        private string StrConexao;
        public ArquivoDAL()
        {
            StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        }

        public long Create(string Caminho, DateTime DataEntrada, long IdCategoria)
        {
            long Id = 0;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                string sql = "INSERT INTO arquivo (caminho, data_upload, categoria_id) VALUES (@Caminho, @DataEntrada, @IdCategoria); SELECT LAST_INSERT_ID()";
                Id = ConexaoBD.ExecuteScalar<long>(sql, new { Caminho, DataEntrada, IdCategoria });

            }
            return Id;
        }

        public int Detele(long Id)
        {
            int resultado = 0;
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                ConexaoBD.Open();
                string sql = "DELETE FROM arquivo WHERE id = @CodigoArq";
                resultado = ConexaoBD.Execute(sql, new { CodigoArq = Id});
            }

            return resultado;
        }

        public DataTable VerifyState()
        {
            using (MySqlConnection ConexaoBD = new MySqlConnection(StrConexao))
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM arquivo WHERE DATE_SUB(data_upload, INTERVAL 5 DAY) = CURDATE()";
                var reader = ConexaoBD.ExecuteReader(sql);
                dt.Load(reader);
                return dt;
            }
        }

        public DataTable List(string TheSearch)
        {
            using (var ConexaoBD = new MySqlConnection(StrConexao))
            {
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM arquivo";

                if (!string.IsNullOrEmpty(TheSearch))
                {
                    sql += " WHERE caminho LIKE @Caminho";
                    var reader = ConexaoBD.ExecuteReader(sql, new { Caminho = "%" + TheSearch + "%" });
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
