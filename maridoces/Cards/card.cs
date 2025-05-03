using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maridoces
{
    public partial class card : UserControl
    {

        [Category("# MenuCard - Configurações#")]
        public Image ImagemDeFundo
        {
            get { return pictureBox1.BackgroundImage; }
            set { pictureBox1.BackgroundImage = value; }
        }

        [Category("# MenuCard - Configurações#")]
        public string nome_Card
        {
            get { return lbl_nomeCard.Text; }
            set { lbl_nomeCard.Text = value; }
        }

        [Category("# MenuCard - Configurações#")]
        public string linkImagem
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

        public event EventHandler Click
        {
            add
            {
                pictureBox1.Click += value;
                card_1.Click += value;
                lbl_nomeCard.Click += value;
            }

            remove
            {
                pictureBox1.Click -= value;
                lbl_nomeCard.Click -= value;
                card_1.Click -= value;
            }
        }

        public card()
        {
            InitializeComponent();

            Utils.Rounded.setRoundedController(this, 25);


        }


    }
}
