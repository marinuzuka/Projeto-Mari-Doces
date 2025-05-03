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
    public partial class Administrador : UserControl
    {
        public Administrador()
        {
            InitializeComponent();

            dgv_centraladm.DataSource = ProdutosDAL.ListarTodosOsProdutosDataTable();
        }


        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_centraladm.SelectedRows.Count > 0 && dgv_centraladm.SelectedRows.Count <= 1) ;
            int idQueSeraExcluido = Convert.ToInt32(dgv_centraladm.CurrentRow.Cells["id"].Value);


            {
                DialogResult escolha = MessageBox.Show(
                    $"Deseja excluir o Produto de ID:{idQueSeraExcluido}?," +
                    $" \nEstá ação é Permanente.",
                    "Deletar produto",

                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (escolha == DialogResult.Yes)
                {
                    ProdutosDAL.DeletarProduto(Convert.ToInt32(dgv_centraladm.CurrentRow.Cells["id_produto"].Value));
                    btn_atualizar_Click(sender, e);
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {


            if (dgv_centraladm.SelectedRows.Count > 0 && dgv_centraladm.SelectedRows.Count <= 1) ;
            {
                int idQueSeraExcluido = Convert.ToInt32(dgv_centraladm.CurrentRow.Cells["id"].Value);

                NovoProduto novoProduto = new NovoProduto(idQueSeraExcluido);
                novoProduto.ShowDialog();
                btn_atualizar_Click(sender, e);
            }
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            dgv_centraladm.DataSource = ProdutosDAL.ListarTodosOsProdutosDataTable();
        }

        private void btn_AdicionarProduto_Click(object sender, EventArgs e)
        {
            NovoProduto novoProduto = new NovoProduto();
            novoProduto.ShowDialog();
            btn_atualizar_Click(sender, e); //chama a função de atualizar a lista dps de uma ação
        }
    }
}

    