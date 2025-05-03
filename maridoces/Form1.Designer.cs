namespace maridoces
{
    partial class Form_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            pictureBox1 = new PictureBox();
            pnl_centro = new Panel();
            pnl_principal = new Panel();
            btn_adm = new Button();
            lbl_principal = new Label();
            pnl_inferior = new Panel();
            btn_finalizar = new Button();
            tpl_menu = new TableLayoutPanel();
            card_bebidas = new card();
            card_promocao = new card();
            card_brownies = new card();
            card_paodemel = new card();
            card_pote = new card();
            card_brigadeiro = new card();
            card_bolos = new card();
            card_trufas = new card();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_principal.SuspendLayout();
            pnl_inferior.SuspendLayout();
            tpl_menu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Retângulo_lateral;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pnl_centro
            // 
            pnl_centro.BackColor = Color.BlanchedAlmond;
            pnl_centro.Dock = DockStyle.Fill;
            pnl_centro.Location = new Point(200, 57);
            pnl_centro.Name = "pnl_centro";
            pnl_centro.Size = new Size(504, 674);
            pnl_centro.TabIndex = 2;
            // 
            // pnl_principal
            // 
            pnl_principal.Controls.Add(btn_adm);
            pnl_principal.Controls.Add(lbl_principal);
            pnl_principal.Dock = DockStyle.Top;
            pnl_principal.Location = new Point(200, 0);
            pnl_principal.Margin = new Padding(0);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(504, 57);
            pnl_principal.TabIndex = 0;
            // 
            // btn_adm
            // 
            btn_adm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_adm.BackColor = Color.Transparent;
            btn_adm.BackgroundImageLayout = ImageLayout.Center;
            btn_adm.Cursor = Cursors.Hand;
            btn_adm.FlatAppearance.BorderSize = 0;
            btn_adm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_adm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_adm.FlatStyle = FlatStyle.Flat;
            btn_adm.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_adm.Location = new Point(469, 3);
            btn_adm.Name = "btn_adm";
            btn_adm.RightToLeft = RightToLeft.No;
            btn_adm.Size = new Size(32, 31);
            btn_adm.TabIndex = 1;
            btn_adm.Text = "⚙️​";
            btn_adm.UseVisualStyleBackColor = false;
            btn_adm.Click += btn_adm_Click;
            // 
            // lbl_principal
            // 
            lbl_principal.AutoSize = true;
            lbl_principal.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_principal.ForeColor = Color.FromArgb(67, 36, 24);
            lbl_principal.Location = new Point(155, 18);
            lbl_principal.Name = "lbl_principal";
            lbl_principal.Size = new Size(252, 32);
            lbl_principal.TabIndex = 0;
            lbl_principal.Text = "NOME DO PRODUTO";
            // 
            // pnl_inferior
            // 
            pnl_inferior.BackColor = Color.White;
            pnl_inferior.Controls.Add(btn_finalizar);
            pnl_inferior.Dock = DockStyle.Bottom;
            pnl_inferior.Location = new Point(0, 731);
            pnl_inferior.Name = "pnl_inferior";
            pnl_inferior.Size = new Size(704, 150);
            pnl_inferior.TabIndex = 2;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_finalizar.BackColor = Color.FromArgb(255, 130, 124);
            btn_finalizar.Cursor = Cursors.Hand;
            btn_finalizar.Enabled = false;
            btn_finalizar.FlatAppearance.BorderSize = 0;
            btn_finalizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 160, 158);
            btn_finalizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 130, 124);
            btn_finalizar.FlatStyle = FlatStyle.Flat;
            btn_finalizar.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_finalizar.ForeColor = Color.Linen;
            btn_finalizar.Location = new Point(442, 65);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(250, 70);
            btn_finalizar.TabIndex = 0;
            btn_finalizar.Text = "Finalizar e pagar";
            btn_finalizar.UseVisualStyleBackColor = false;
            // 
            // tpl_menu
            // 
            tpl_menu.AutoScroll = true;
            tpl_menu.BackColor = Color.White;
            tpl_menu.BackgroundImage = Properties.Resources.Retângulo_lateral;
            tpl_menu.ColumnCount = 1;
            tpl_menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tpl_menu.Controls.Add(card_bebidas, 0, 8);
            tpl_menu.Controls.Add(card_promocao, 0, 1);
            tpl_menu.Controls.Add(card_brownies, 0, 6);
            tpl_menu.Controls.Add(card_paodemel, 0, 7);
            tpl_menu.Controls.Add(card_pote, 0, 2);
            tpl_menu.Controls.Add(card_brigadeiro, 0, 4);
            tpl_menu.Controls.Add(card_bolos, 0, 3);
            tpl_menu.Controls.Add(card_trufas, 0, 5);
            tpl_menu.Controls.Add(pictureBox1, 0, 0);
            tpl_menu.Dock = DockStyle.Left;
            tpl_menu.Location = new Point(0, 0);
            tpl_menu.Name = "tpl_menu";
            tpl_menu.RowCount = 9;
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4505577F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1936779F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1936779F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1936779F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1936779F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1936779F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1936779F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8834829F));
            tpl_menu.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1152372F));
            tpl_menu.Size = new Size(200, 731);
            tpl_menu.TabIndex = 0;
            // 
            // card_bebidas
            // 
            card_bebidas.Anchor = AnchorStyles.None;
            card_bebidas.BackColor = Color.White;
            card_bebidas.ImagemDeFundo = Properties.Resources.Bebida;
            card_bebidas.linkImagem = null;
            card_bebidas.Location = new Point(20, 663);
            card_bebidas.Margin = new Padding(0, 6, 0, 6);
            card_bebidas.Name = "card_bebidas";
            card_bebidas.nome_Card = "Bebidas";
            card_bebidas.Size = new Size(160, 62);
            card_bebidas.TabIndex = 8;
            card_bebidas.Click += card_bebidas_Click;
            // 
            // card_promocao
            // 
            card_promocao.Anchor = AnchorStyles.None;
            card_promocao.BackColor = Color.White;
            card_promocao.BackgroundImageLayout = ImageLayout.None;
            card_promocao.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            card_promocao.ImagemDeFundo = Properties.Resources.Star_1;
            card_promocao.linkImagem = "";
            card_promocao.Location = new Point(20, 140);
            card_promocao.Margin = new Padding(0, 6, 0, 6);
            card_promocao.Name = "card_promocao";
            card_promocao.nome_Card = "Promoções";
            card_promocao.Size = new Size(160, 62);
            card_promocao.TabIndex = 1;
            card_promocao.Click += card_promocao_Click_1;
            // 
            // card_brownies
            // 
            card_brownies.Anchor = AnchorStyles.None;
            card_brownies.BackColor = Color.White;
            card_brownies.ImagemDeFundo = Properties.Resources.Brownie;
            card_brownies.linkImagem = null;
            card_brownies.Location = new Point(20, 510);
            card_brownies.Margin = new Padding(0, 6, 0, 6);
            card_brownies.Name = "card_brownies";
            card_brownies.nome_Card = "Brownies";
            card_brownies.Size = new Size(160, 62);
            card_brownies.TabIndex = 6;
            card_brownies.Click += card_brownies_Click;
            // 
            // card_paodemel
            // 
            card_paodemel.Anchor = AnchorStyles.None;
            card_paodemel.BackColor = Color.White;
            card_paodemel.ImagemDeFundo = Properties.Resources.Group_1;
            card_paodemel.linkImagem = null;
            card_paodemel.Location = new Point(20, 584);
            card_paodemel.Margin = new Padding(0, 6, 0, 6);
            card_paodemel.Name = "card_paodemel";
            card_paodemel.nome_Card = "Pão de Mel";
            card_paodemel.Size = new Size(160, 67);
            card_paodemel.TabIndex = 7;
            card_paodemel.Click += card_paodemel_Click;
            // 
            // card_pote
            // 
            card_pote.Anchor = AnchorStyles.None;
            card_pote.BackColor = Color.White;
            card_pote.ImagemDeFundo = (Image)resources.GetObject("card_pote.ImagemDeFundo");
            card_pote.linkImagem = null;
            card_pote.Location = new Point(20, 214);
            card_pote.Margin = new Padding(0, 6, 0, 6);
            card_pote.Name = "card_pote";
            card_pote.nome_Card = "Bolos de Pote";
            card_pote.Size = new Size(160, 62);
            card_pote.TabIndex = 2;
            card_pote.Click += card_pote_Click;
            // 
            // card_brigadeiro
            // 
            card_brigadeiro.Anchor = AnchorStyles.None;
            card_brigadeiro.BackColor = Color.White;
            card_brigadeiro.ImagemDeFundo = Properties.Resources.Brigadeiro;
            card_brigadeiro.linkImagem = null;
            card_brigadeiro.Location = new Point(20, 362);
            card_brigadeiro.Margin = new Padding(0, 6, 0, 6);
            card_brigadeiro.Name = "card_brigadeiro";
            card_brigadeiro.nome_Card = "Brigadeiro";
            card_brigadeiro.Size = new Size(160, 62);
            card_brigadeiro.TabIndex = 4;
            card_brigadeiro.Click += card_brigadeiro_Click;
            // 
            // card_bolos
            // 
            card_bolos.Anchor = AnchorStyles.None;
            card_bolos.BackColor = Color.White;
            card_bolos.ImagemDeFundo = Properties.Resources.Bolo_de_festa;
            card_bolos.linkImagem = null;
            card_bolos.Location = new Point(20, 288);
            card_bolos.Margin = new Padding(0, 6, 0, 6);
            card_bolos.Name = "card_bolos";
            card_bolos.nome_Card = "Bolos de Festa";
            card_bolos.Size = new Size(160, 62);
            card_bolos.TabIndex = 3;
            card_bolos.Click += card_bolos_Click;
            // 
            // card_trufas
            // 
            card_trufas.Anchor = AnchorStyles.None;
            card_trufas.BackColor = Color.White;
            card_trufas.ImagemDeFundo = Properties.Resources.Trufa;
            card_trufas.linkImagem = null;
            card_trufas.Location = new Point(20, 436);
            card_trufas.Margin = new Padding(0, 6, 0, 6);
            card_trufas.Name = "card_trufas";
            card_trufas.nome_Card = "Trufas";
            card_trufas.Size = new Size(160, 62);
            card_trufas.TabIndex = 5;
            card_trufas.Click += card_trufas_Click;
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 881);
            Controls.Add(pnl_centro);
            Controls.Add(pnl_principal);
            Controls.Add(tpl_menu);
            Controls.Add(pnl_inferior);
            Name = "Form_principal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_principal.ResumeLayout(false);
            pnl_principal.PerformLayout();
            pnl_inferior.ResumeLayout(false);
            tpl_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnl_centro;
        private Panel pnl_inferior;
        private Button btn_finalizar;
        private TableLayoutPanel tpl_menu;
        private card card_bebidas;
        private card card_promocao;
        private card card_brownies;
        private card card_paodemel;
        private card card_pote;
        private card card_brigadeiro;
        private card card_bolos;
        private card card_trufas;
        private Button btn_adm;
        private Panel pnl_principal;
        private Label lbl_principal;
    }
}
