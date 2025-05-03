using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maridoces.DTOs
{
    internal class UsuarioDTO
    {
        private string v1;
        private string v2;

        public int id_usuario { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string Senha { get; set; }

        public UsuarioDTO(int id_usuario, string cpf, string nome, string email, string senha)
        {
            this.id_usuario = id_usuario;
            this.cpf = cpf;
            this.nome = nome;
            this.email = email;
            Senha = senha;
        }

      
    }
}
