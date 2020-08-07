using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Categoria
    {
        public List<CategoriaDTO> List()
        {
            List<CategoriaDTO> categorias = new List<CategoriaDTO>();
            DataTable dt = new CategoriaDAL().List();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                categorias.Add(new CategoriaDTO
                {
                    Id = Convert.ToInt64(dt.Rows[i]["id"]),
                    Descricao = dt.Rows[i]["descricao"].ToString()
                });
            }
            return categorias;
        }
    }
}
