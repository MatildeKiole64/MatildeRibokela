using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Arquivo
    {
        ArquivoDAL arquivoDAL = new ArquivoDAL();
        public bool upload(ArquivoDTO arquivoDTO, string destino)
        {
            File.Copy(arquivoDTO.Caminho, destino);
            long resultado = arquivoDAL.Create(destino, arquivoDTO.DataEntrada, arquivoDTO.Categoria.Id);
            return resultado > 0;
        }

        public bool remove(long id)
        {
            int resultado = arquivoDAL.Detele(id);
            return resultado > 0;
        }


        public List<ArquivoDTO> list(string TheSearch = null)
        {
            List<ArquivoDTO> arquivos = new List<ArquivoDTO>();
            DataTable dt = new ArquivoDAL().List(TheSearch);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CategoriaDTO categoriaDTO = new CategoriaDTO()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["id"]),
                    Descricao = "Categoria " + (i + 1)
                };

                ArquivoDTO arquivoDTO = new ArquivoDTO();
                arquivoDTO.Id = Convert.ToInt64(dt.Rows[i]["id"]);
                arquivoDTO.Caminho = dt.Rows[i]["caminho"].ToString();
                arquivoDTO.DataEntrada = Convert.ToDateTime(dt.Rows[i]["data_upload"]);
                arquivoDTO.Nome = Path.GetFileName(arquivoDTO.Caminho);
                arquivoDTO.Tamanho = new FileInfo(arquivoDTO.Caminho).Length;
                arquivoDTO.Categoria = categoriaDTO;
                arquivos.Add(arquivoDTO);

            }
            return arquivos;
        }

        public List<ArquivoDTO> VerifyState()
        {
            List<ArquivoDTO> arquivos = new List<ArquivoDTO>();
            DataTable dt = new ArquivoDAL().VerifyState();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CategoriaDTO categoriaDTO = new CategoriaDTO()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["id"]),
                    Descricao = "Categoria " + (i + 1)
                };

                ArquivoDTO arquivoDTO = new ArquivoDTO();
                arquivoDTO.Id = Convert.ToInt64(dt.Rows[i]["id"]);
                arquivoDTO.Caminho = dt.Rows[i]["caminho"].ToString();
                arquivoDTO.DataEntrada = Convert.ToDateTime(dt.Rows[i]["data_upload"]);
                arquivoDTO.Nome = Path.GetFileName(arquivoDTO.Caminho);
                arquivoDTO.Tamanho = new FileInfo(arquivoDTO.Caminho).Length;
                arquivoDTO.Categoria = categoriaDTO;
                arquivos.Add(arquivoDTO);

            }
            return arquivos;
        }
    }
}
