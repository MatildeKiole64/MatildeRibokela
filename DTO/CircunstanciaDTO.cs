using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CircunstanciaDTO
    {
        public long Id { get; set; }
        public string Circunstancia { get; set; }

        public override string ToString()
        {
            return Circunstancia; 
        }
    }
}
