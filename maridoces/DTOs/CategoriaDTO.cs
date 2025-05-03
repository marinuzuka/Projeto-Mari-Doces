using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maridoces.DTOs
{
    internal class CategoriaDTO
    {

        public int id_categoria { get; set; }
        public string nome_categoria { get; set; }

        public CategoriaDTO(int id_categoria, string nome_categoria)
        {
            this.id_categoria = id_categoria;
            this.nome_categoria = nome_categoria;
        }
    }
}
