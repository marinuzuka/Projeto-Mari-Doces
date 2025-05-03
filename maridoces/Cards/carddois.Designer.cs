namespace maridoces.Cards
{
    partial class carddois
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
            pct_imagem = new PictureBox();
            lbl_nomeproduto = new Label();
            lbl_valor = new Label();
            pnl_central = new Panel();
            ((System.ComponentModel.ISupportInitialize)pct_imagem).BeginInit();
            pnl_central.SuspendLayout();
            SuspendLayout();
            // 
            // pct_imagem
            // 
            pct_imagem.ImageLocation = "";
            pct_imagem.Location = new Point(33, 20);
            pct_imagem.Name = "pct_imagem";
            pct_imagem.Size = new Size(80, 80);
            pct_imagem.TabIndex = 0;
            pct_imagem.TabStop = false;
            // 
            // lbl_nomeproduto
            // 
            lbl_nomeproduto.AutoSize = true;
            lbl_nomeproduto.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nomeproduto.ForeColor = Color.FromArgb(67, 36, 24);
            lbl_nomeproduto.Location = new Point(10, 103);
            lbl_nomeproduto.Margin = new Padding(0);
            lbl_nomeproduto.Name = "lbl_nomeproduto";
            lbl_nomeproduto.Size = new Size(132, 20);
            lbl_nomeproduto.TabIndex = 1;
            lbl_nomeproduto.Text = "nome do produto";
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_valor.ForeColor = Color.FromArgb(67, 36, 24);
            lbl_valor.Location = new Point(101, 122);
            lbl_valor.Margin = new Padding(0);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(44, 20);
            lbl_valor.TabIndex = 2;
            lbl_valor.Text = "valor";
            // 
            // pnl_central
            // 
            pnl_central.BackColor = Color.Linen;
            pnl_central.Controls.Add(pct_imagem);
            pnl_central.Controls.Add(lbl_valor);
            pnl_central.Controls.Add(lbl_nomeproduto);
            pnl_central.Cursor = Cursors.Hand;
            pnl_central.Location = new Point(0, 0);
            pnl_central.Name = "pnl_central";
            pnl_central.Size = new Size(150, 150);
            pnl_central.TabIndex = 3;
            // 
            // carddois
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_central);
            Name = "carddois";
            ((System.ComponentModel.ISupportInitialize)pct_imagem).EndInit();
            pnl_central.ResumeLayout(false);
            pnl_central.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pct_imagem;
        private Label lbl_nomeproduto;
        private Label lbl_valor;
        private Panel pnl_central;
    }
}
