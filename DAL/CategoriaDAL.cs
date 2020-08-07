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
    public class CategoriaDAL
    {
        private string StrConexao;
        public CategoriaDAL() 
        {
            StrConexao = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;
        }

        public DataTable List() 
        {
            using (MySqlConnection ConexaoBD = new MySqlConnection(StrConexao)) 
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM categoria";
                var reader = ConexaoBD.ExecuteReader(sql);
                dt.Load(reader);
                return dt;
            }
        }
    }
}
