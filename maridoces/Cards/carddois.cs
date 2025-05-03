using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using maridoces.DTOs;

namespace maridoces.Cards
{
    public partial class carddois : UserControl
    {
        [Category("# MenuCard - Configurações#")]
        public Image ImagemDeFundo
        {
            get { return pct_imagem.BackgroundImage; }
            set { pct_imagem.BackgroundImage = value; }
        }

        //[Category("# MenuCard - Configurações#")]
        //public Image ImagemDaEtiqueta
        //{
        //    get { return pct_lowcarb.BackgroundImage; }
        //    set { pct_lowcarb.BackgroundImage = value; }
        //}

        [Category("# MenuCard - Configurações#")]
        public string nomeproduto
        {
            get { return lbl_nomeproduto.Text; }
            set { lbl_nomeproduto.Text = value; }
        }

        [Category("# MenuCard - Configurações#")]
        public string linkImagem
        {
            get { return pct_imagem.ImageLocation; }
            set { pct_imagem.ImageLocation = value; }
        }


        public event EventHandler Click
        {
            add
            {
                pct_imagem.Click += value;
                pnl_central.Click += value;
                lbl_nomeproduto.Click += value;
            }

            remove
            {
                pct_imagem.Click -= value;
                lbl_nomeproduto.Click -= value;
                pnl_central.Click -= value;
            }
        }

        public carddois()
        {
            InitializeComponent();

            Utils.Rounded.setRoundedController(this, 25);


        }

        public carddois(ProdutoDTO produto)
        {
            InitializeComponent();

            Utils.Rounded.setRoundedController(this, 25);

            lbl_nomeproduto.Text = produto.nome;
            pct_imagem.ImageLocation = produto.imagem;
            lbl_valor.Text = produto.valor.ToString();
        }

        private void pct_lowcarb_Click(object sender, EventArgs e)
        {

        }
    }


}
