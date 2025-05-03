using maridoces.componentes;
using maridoces.conexao;

namespace maridoces
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();

            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Promoções";

            controletres controle3 = new controletres();
            pnl_centro.Controls.Add(controle3);
            controle3.Dock = DockStyle.Fill;
        }

        private void card_promocao_Click(object sender, EventArgs e)
        {

        }

        private void card_promocao_Click_1(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Promoções";

            controletres controle3 = new controletres();
            pnl_centro.Controls.Add(controle3);
            controle3.Dock = DockStyle.Fill;
        }

        private void card_pote_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Bolos de Pote";
            controle controle = new controle(1);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;

        }

        private void card_bolos_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Bolos de festa";
            controle controle = new controle(2);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;
        }

        private void card_brigadeiro_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Brigadeiros";
            controle controle = new controle(3);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;
        }

        private void card_trufas_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Trufas";
            controle controle = new controle(4);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;
        }

        private void card_brownies_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Brownies";
            controle controle = new controle(5);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;
        }

        private void card_paodemel_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Pão de mel";
            controle controle = new controle(6);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;
        }

        private void card_bebidas_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Bebidas";

            controle controle = new controle(7);
            pnl_centro.Controls.Add(controle);
            controle.Dock = DockStyle.Fill;
        }

        ////////////////////////// felipe >

        private void btn_adm_Click(object sender, EventArgs e)
        {
            pnl_centro.Controls.Clear();
            lbl_principal.Text = "Admnistradores";
            Administrador controleADM = new Administrador();
            pnl_centro.Controls.Add(controleADM);
            controleADM.Dock = DockStyle.Fill;
        }

    }
}
