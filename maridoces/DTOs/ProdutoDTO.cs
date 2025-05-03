using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maridoces.DTOs
{
    public class ProdutoDTO
    {
        public int id_produtos { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public int id_categoria { get; set; }
        public int id_sabor { get; set; }
        public string imagem { get; set; }
        public string nome_categoria { get; set; }
        public string nome_sabor { get; set; }
        public bool promocao {  get; set; }
        public int ID { get; set; }
        public ProdutoDTO(int id_produtos, string nome, string descricao, decimal valor, int id_categoria, int id_sabor, string imagem, string nome_categoria, string nome_sabor, bool promocao, int ID)
        {
            this.id_produtos = id_produtos;
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
            this.id_categoria = id_categoria;
            this.id_sabor = id_sabor;
            this.imagem = imagem;
            this.nome_categoria = nome_categoria;
            this.nome_sabor = nome_sabor;
            this.promocao = promocao;
            this.ID = ID;
        }
    }
}
