
namespace maridoces
{
    partial class NovoProduto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btn_EditarProduto = new Button();
            lbl_nome = new Label();
            txt_nomeProduto = new TextBox();
            rtb_descricaoProduto = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbx_categoria = new ComboBox();
            cbx_sabor = new ComboBox();
            btn_imagem = new Button();
            btn_cancelar = new Button();
            btn_adicionar = new Button();
            btn_fechar = new Button();
            mktb_valor = new MaskedTextBox();
            txt_LinkImagem = new TextBox();
            lbl_linkimagem = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_EditarProduto
            // 
            btn_EditarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_EditarProduto.AutoEllipsis = true;
            btn_EditarProduto.BackColor = Color.FromArgb(117, 209, 197);
            btn_EditarProduto.Cursor = Cursors.Hand;
            btn_EditarProduto.FlatAppearance.BorderSize = 0;
            btn_EditarProduto.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_EditarProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btn_EditarProduto.FlatStyle = FlatStyle.Popup;
            btn_EditarProduto.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditarProduto.ForeColor = Color.FromArgb(67, 36, 24);
            btn_EditarProduto.Location = new Point(331, 652);
            btn_EditarProduto.Name = "btn_EditarProduto";
            btn_EditarProduto.Size = new Size(135, 31);
            btn_EditarProduto.TabIndex = 0;
            btn_EditarProduto.Text = "Editar Produto";
            btn_EditarProduto.UseVisualStyleBackColor = false;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(88, 255);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(123, 19);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome do Produto :";
            // 
            // txt_nomeProduto
            // 
            txt_nomeProduto.BackColor = SystemColors.Info;
            txt_nomeProduto.Location = new Point(88, 277);
            txt_nomeProduto.Name = "txt_nomeProduto";
            txt_nomeProduto.Size = new Size(329, 23);
            txt_nomeProduto.TabIndex = 2;
            // 
            // rtb_descricaoProduto
            // 
            rtb_descricaoProduto.BackColor = SystemColors.Info;
            rtb_descricaoProduto.Location = new Point(88, 353);
            rtb_descricaoProduto.Name = "rtb_descricaoProduto";
            rtb_descricaoProduto.Size = new Size(329, 122);
            rtb_descricaoProduto.TabIndex = 3;
            rtb_descricaoProduto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 331);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 4;
            label1.Text = "Descrição do Produto :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 503);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 5;
            label2.Text = "Valor do Produto :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Linen;
            pictureBox1.Location = new Point(88, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 103);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 31);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 8;
            label3.Text = "Foto do Produto :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 543);
            label4.Name = "label4";
            label4.Size = new Size(149, 19);
            label4.TabIndex = 9;
            label4.Text = "Categoria do Produto :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(89, 582);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 10;
            label5.Text = "Sabor do Produto :";
            // 
            // cbx_categoria
            // 
            cbx_categoria.BackColor = SystemColors.Info;
            cbx_categoria.FormattingEnabled = true;
            cbx_categoria.Location = new Point(256, 544);
            cbx_categoria.Name = "cbx_categoria";
            cbx_categoria.Size = new Size(137, 23);
            cbx_categoria.TabIndex = 11;
            // 
            // cbx_sabor
            // 
            cbx_sabor.BackColor = SystemColors.Info;
            cbx_sabor.FormattingEnabled = true;
            cbx_sabor.Location = new Point(256, 583);
            cbx_sabor.Name = "cbx_sabor";
            cbx_sabor.Size = new Size(137, 23);
            cbx_sabor.TabIndex = 12;
            // 
            // btn_imagem
            // 
            btn_imagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_imagem.AutoEllipsis = true;
            btn_imagem.BackColor = Color.FromArgb(117, 209, 197);
            btn_imagem.Cursor = Cursors.Hand;
            btn_imagem.FlatAppearance.BorderSize = 0;
            btn_imagem.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_imagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btn_imagem.FlatStyle = FlatStyle.Popup;
            btn_imagem.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_imagem.ForeColor = Color.FromArgb(67, 36, 24);
            btn_imagem.Location = new Point(306, 223);
            btn_imagem.Name = "btn_imagem";
            btn_imagem.Size = new Size(111, 27);
            btn_imagem.TabIndex = 13;
            btn_imagem.Text = "Salvar imagem";
            btn_imagem.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cancelar.AutoEllipsis = true;
            btn_cancelar.BackColor = Color.FromArgb(255, 130, 124);
            btn_cancelar.Cursor = Cursors.Hand;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_cancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.FromArgb(67, 36, 24);
            btn_cancelar.Location = new Point(252, 652);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(73, 31);
            btn_cancelar.TabIndex = 14;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_adicionar.AutoEllipsis = true;
            btn_adicionar.BackColor = Color.FromArgb(255, 225, 153);
            btn_adicionar.Cursor = Cursors.Hand;
            btn_adicionar.FlatAppearance.BorderSize = 0;
            btn_adicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_adicionar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btn_adicionar.FlatStyle = FlatStyle.Popup;
            btn_adicionar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_adicionar.ForeColor = Color.FromArgb(67, 36, 24);
            btn_adicionar.Location = new Point(22, 652);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(224, 31);
            btn_adicionar.TabIndex = 15;
            btn_adicionar.Text = "Adicionar categoria e sabor";
            btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_fechar
            // 
            btn_fechar.BackColor = Color.FromArgb(255, 130, 124);
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.FlatAppearance.BorderSize = 0;
            btn_fechar.FlatStyle = FlatStyle.Popup;
            btn_fechar.Location = new Point(453, 9);
            btn_fechar.Margin = new Padding(0);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(26, 30);
            btn_fechar.TabIndex = 16;
            btn_fechar.Text = "❌";
            btn_fechar.UseVisualStyleBackColor = false;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // mktb_valor
            // 
            mktb_valor.BackColor = SystemColors.Info;
            mktb_valor.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mktb_valor.Location = new Point(256, 499);
            mktb_valor.Mask = "####.#9";
            mktb_valor.Name = "mktb_valor";
            mktb_valor.PromptChar = '0';
            mktb_valor.Size = new Size(137, 23);
            mktb_valor.TabIndex = 17;
            // 
            // txt_LinkImagem
            // 
            txt_LinkImagem.BackColor = SystemColors.Info;
            txt_LinkImagem.Location = new Point(88, 185);
            txt_LinkImagem.Name = "txt_LinkImagem";
            txt_LinkImagem.Size = new Size(329, 23);
            txt_LinkImagem.TabIndex = 19;
            // 
            // lbl_linkimagem
            // 
            lbl_linkimagem.AutoSize = true;
            lbl_linkimagem.BackColor = Color.Transparent;
            lbl_linkimagem.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_linkimagem.Location = new Point(88, 163);
            lbl_linkimagem.Name = "lbl_linkimagem";
            lbl_linkimagem.Size = new Size(114, 19);
            lbl_linkimagem.TabIndex = 18;
            lbl_linkimagem.Text = "Link da Imagem:";
            // 
            // NovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(488, 725);
            Controls.Add(txt_LinkImagem);
            Controls.Add(lbl_linkimagem);
            Controls.Add(mktb_valor);
            Controls.Add(btn_fechar);
            Controls.Add(btn_adicionar);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_imagem);
            Controls.Add(cbx_sabor);
            Controls.Add(cbx_categoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtb_descricaoProduto);
            Controls.Add(txt_nomeProduto);
            Controls.Add(lbl_nome);
            Controls.Add(btn_EditarProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NovoProduto";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_EditarProduto;
        private Label lbl_nome;
        private TextBox txt_nomeProduto;
        private RichTextBox rtb_descricaoProduto;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private EventHandler NovoProduto_Load;
        private readonly EventHandler lbl_nome_Click;
        private readonly EventHandler label1_Click;
        private ComboBox cbx_categoria;
        private ComboBox cbx_sabor;
        private Button btn_imagem;
        private Button btn_cancelar;
        private Button btn_adicionar;
        private Button btn_fechar;
        private MaskedTextBox mktb_valor;
        private TextBox txt_LinkImagem;
        private Label lbl_linkimagem;

        public EventHandler txt_nomeProduto_TextChanged { get; private set; }
        public EventHandler rtb_descricaoProduto_TextChanged { get; private set; }
        public EventHandler textBox1_TextChanged { get; private set; }
    }
}
