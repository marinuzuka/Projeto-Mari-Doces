using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maridoces.DTOs
{
    internal class BebidasDTO
    {

        public int id_bebida { get; set; }
        public string nome_bebida { get; set; }

        public BebidasDTO(int id_bebida, string nome_bebida)
        {
            this.id_bebida = id_bebida;
            this.nome_bebida = nome_bebida;
        }
    }
}
