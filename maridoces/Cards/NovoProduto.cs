using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maridoces.conexao;
using maridoces.DTOs;

namespace maridoces
{
    public partial class NovoProduto : Form
    {
        private IEnumerable<ProdutoDTO> _ProdutoSelecionado;
        public NovoProduto()
        {
            InitializeComponent();

            cbx_sabor.DataSource = SaborDAL.ListarTodosOsSabores(); // lista la no combo box como o tipo, "system.etc"
            cbx_sabor.DisplayMember = "nome_sabor"; //tabela de nomes que vai aparecer na combo box, nome que aparece
            cbx_sabor.ValueMember = "id_sabor"; //pegar informaçã

            cbx_categoria.DataSource = CategoriaDAL.ListarTodosAsCategorias(); // lista la no combo box como o tipo, "system.etc"
            cbx_categoria.DisplayMember = "nome_categoria"; //tabela de nomes que vai aparecer na combo box, nome que aparece
            cbx_categoria.ValueMember = "id_categoria"; //pegar informação de qual coluna, id que vai fazer a busca no banco de dados 




        }
        public NovoProduto(int ID)
        {
            InitializeComponent();
            lbl_nome.Text = "Editar Produto: ";
            this.Text = "Editar Produo";

            cbx_categoria.DataSource = CategoriaDAL.ListarTodosAsCategorias(); // lista la no combo box como o tipo, "system.etc"
            cbx_categoria.DisplayMember = "nome_categoria"; //tabela de nomes que vai aparecer na combo box, nome que aparece
            cbx_categoria.ValueMember = "id_categoria";

           // _ProdutoSelecionado = ProdutosDAL.ListarTodosOsProdutos().Where(item => item.id_categoria = ID);

            txt_nomeProduto.Text = _ProdutoSelecionado.First().nome;
            rtb_descricaoProduto.Text = _ProdutoSelecionado.First().descricao;
            txt_LinkImagem.Text = _ProdutoSelecionado.First().imagem;
            mktb_valor.Text = _ProdutoSelecionado.First().valor.ToString("0000.00");
            cbx_categoria.SelectedValue = _ProdutoSelecionado.First().id_categoria;

            btn_EditarProduto.Text = "Editar ";
            btn_EditarProduto.Click += btn_EditarProduto_Click;
        }
      //  private void btn_EditarProduto_Click_1(object sender, EventArgs e)
       // {
       //     ProdutosDAL.EditarProduto(
      //      _ProdutoSelecionado.First().ID,
      //    txt_nomeProduto.Text,
       //    rtb_descricaoProduto.Text,
     //      mktb_valor.Text.Replace(",", " ").Replace(" ", "0"),
       //    txt_LinkImagem.Text,
      ///     Convert.ToInt32(cbx_categoria.SelectedValue)
      //     );
      //      this.Close();

       // }

        private void btn_EditarProduto_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
