namespace maridoces
{
    partial class Administrador
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
            btn_atualizar = new Button();
            btn_AdicionarProduto = new Button();
            lbl_adm = new Label();
            panel1 = new Panel();
            btn_excluir = new Button();
            btn_editar = new Button();
            dgv_centraladm = new DataGridView();
            pnl_centroadm = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_centraladm).BeginInit();
            pnl_centroadm.SuspendLayout();
            SuspendLayout();
            // 
            // btn_atualizar
            // 
            btn_atualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_atualizar.BackColor = Color.FromArgb(254, 225, 153);
            btn_atualizar.Cursor = Cursors.Hand;
            btn_atualizar.FlatAppearance.BorderSize = 0;
            btn_atualizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_atualizar.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            btn_atualizar.FlatStyle = FlatStyle.Popup;
            btn_atualizar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atualizar.ForeColor = Color.FromArgb(67, 36, 24);
            btn_atualizar.Location = new Point(448, 23);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(70, 23);
            btn_atualizar.TabIndex = 1;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_AdicionarProduto
            // 
            btn_AdicionarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AdicionarProduto.BackColor = Color.FromArgb(117, 209, 197);
            btn_AdicionarProduto.Cursor = Cursors.Hand;
            btn_AdicionarProduto.FlatAppearance.MouseDownBackColor = Color.Tan;
            btn_AdicionarProduto.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_AdicionarProduto.FlatStyle = FlatStyle.Popup;
            btn_AdicionarProduto.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdicionarProduto.ForeColor = Color.FromArgb(67, 36, 24);
            btn_AdicionarProduto.Location = new Point(676, 23);
            btn_AdicionarProduto.Name = "btn_AdicionarProduto";
            btn_AdicionarProduto.Size = new Size(99, 23);
            btn_AdicionarProduto.TabIndex = 2;
            btn_AdicionarProduto.Text = "Adicionar Produto";
            btn_AdicionarProduto.UseVisualStyleBackColor = false;
            btn_AdicionarProduto.Click += btn_AdicionarProduto_Click;
            // 
            // lbl_adm
            // 
            lbl_adm.AutoSize = true;
            lbl_adm.BackColor = Color.Transparent;
            lbl_adm.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_adm.ForeColor = Color.FromArgb(67, 36, 24);
            lbl_adm.Location = new Point(3, 9);
            lbl_adm.Name = "lbl_adm";
            lbl_adm.Size = new Size(206, 30);
            lbl_adm.TabIndex = 3;
            lbl_adm.Text = "Gestão de Produtos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(btn_excluir);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(btn_atualizar);
            panel1.Controls.Add(btn_AdicionarProduto);
            panel1.Controls.Add(lbl_adm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 68);
            panel1.TabIndex = 4;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_excluir.BackColor = Color.FromArgb(255, 130, 124);
            btn_excluir.Cursor = Cursors.Hand;
            btn_excluir.FlatAppearance.MouseDownBackColor = Color.Tan;
            btn_excluir.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_excluir.FlatStyle = FlatStyle.Popup;
            btn_excluir.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_excluir.ForeColor = Color.FromArgb(67, 36, 24);
            btn_excluir.Location = new Point(524, 23);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(70, 23);
            btn_excluir.TabIndex = 4;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.BackColor = Color.FromArgb(254, 225, 153);
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.Tan;
            btn_editar.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_editar.FlatStyle = FlatStyle.Popup;
            btn_editar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.ForeColor = Color.FromArgb(67, 36, 24);
            btn_editar.Location = new Point(600, 23);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(70, 23);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // dgv_centraladm
            // 
            dgv_centraladm.AllowUserToAddRows = false;
            dgv_centraladm.AllowUserToDeleteRows = false;
            dgv_centraladm.AllowUserToOrderColumns = true;
            dgv_centraladm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_centraladm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_centraladm.BackgroundColor = Color.NavajoWhite;
            dgv_centraladm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_centraladm.Location = new Point(8, 8);
            dgv_centraladm.Margin = new Padding(8);
            dgv_centraladm.Name = "dgv_centraladm";
            dgv_centraladm.ReadOnly = true;
            dgv_centraladm.Size = new Size(767, 376);
            dgv_centraladm.TabIndex = 0;
            // 
            // pnl_centroadm
            // 
            pnl_centroadm.BackColor = Color.BlanchedAlmond;
            pnl_centroadm.Controls.Add(dgv_centraladm);
            pnl_centroadm.Dock = DockStyle.Fill;
            pnl_centroadm.Location = new Point(0, 68);
            pnl_centroadm.Name = "pnl_centroadm";
            pnl_centroadm.Size = new Size(783, 392);
            pnl_centroadm.TabIndex = 5;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            Controls.Add(pnl_centroadm);
            Controls.Add(panel1);
            Name = "Administrador";
            Size = new Size(783, 460);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_centraladm).EndInit();
            pnl_centroadm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_atualizar;
        private Button btn_AdicionarProduto;
        private Label lbl_adm;
        private Panel panel1;
        private DataGridView dgv_centraladm;
        private Panel pnl_centroadm;
        private Button btn_excluir;
        private Button btn_editar;
    }
}
