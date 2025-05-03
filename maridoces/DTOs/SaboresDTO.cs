using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maridoces.DTOs
{
    internal class SaboresDTO
    {

        public int id_sabor { get; set; }
        public string nome_sabor { get; set; }

        public SaboresDTO(int id_sabor, string nome_sabor)
        {
            this.id_sabor = id_sabor;
            this.nome_sabor = nome_sabor;
        }
    }
}
