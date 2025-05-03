using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maridoces.Cards;
using maridoces.conexao;

namespace maridoces.componentes
{
    public partial class controle : UserControl
    {
        public controle()
        {
            InitializeComponent();

            foreach (var item in ProdutosDAL.ListarTodosOsProdutos())
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
        }

        public controle(int id_categoria)
        {
            InitializeComponent();

            foreach (var item in ProdutosDAL.ListarTodosOsProdutos()
                .Where(item => item.id_categoria == id_categoria))
            {
                carddois a = new carddois(item);
                flp_Bolos.Controls.Add(a);
            }
        }

    }
}
