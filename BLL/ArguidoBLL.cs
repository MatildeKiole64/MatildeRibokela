using DAL;
using DTO;
using IBLL;
using MatildeRibokela.IDAL;
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
    public class ArguidoBLL : IArguidoBLL
    {
        IArguidoDAL arguidoDAL = new ArguidoDAL();
        public bool Create(ArguidoDTO arguido)
        {
            long Id = arguidoDAL.Create(arguido);
            return Id > 0;
        }

        public bool Delete(ArguidoDTO arguido)
        {
            int resultado = arguidoDAL.Delete(arguido);
            return resultado > 0;
        }

        public bool Delete(long id)
        {
            int resultado = arguidoDAL.Delete(id);
            return resultado > 0;
        }

        public List<ArguidoDTO> List()
        {
            List<ArguidoDTO> arguidos = new List<ArguidoDTO>();
            DataTable dt = arguidoDAL.List();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ArguidoDTO arguido = new ArguidoDTO()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["id"]),
                    Idade = Convert.ToInt32(dt.Rows[i]["idade"]),
                    ProcessoId = Convert.ToInt32(dt.Rows[i]["processo_id"]),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Contacto1 = Convert.ToInt32(dt.Rows[i]["Contacto1"]),
                    Contacto2 = Convert.ToInt32(dt.Rows[i]["Contacto2"]),
                    ResidenciaHabitual = dt.Rows[i]["residencia_hab"].ToString(),
                };

                arguidos.Add(arguido);
            }
            return arguidos;
        }

        public bool Update(ArguidoDTO arguido)
        {
            int resultado = arguidoDAL.Update(arguido);
            return resultado > 0;
        }
    }
}
