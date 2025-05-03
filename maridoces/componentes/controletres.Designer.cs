namespace maridoces.conexao
{
    partial class controletres
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
            btn_Todos = new Button();
            btn_escpecial = new Button();
            btn_aniversario = new Button();
            pnl_promo = new Panel();
            flp_promo = new FlowLayoutPanel();
            pnl_promo.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Todos
            // 
            btn_Todos.BackColor = Color.Linen;
            btn_Todos.Cursor = Cursors.Hand;
            btn_Todos.FlatAppearance.BorderSize = 0;
            btn_Todos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Todos.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Todos.FlatStyle = FlatStyle.Flat;
            btn_Todos.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Todos.ForeColor = Color.FromArgb(67, 36, 24);
            btn_Todos.Location = new Point(3, 3);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(81, 33);
            btn_Todos.TabIndex = 2;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = false;
            // 
            // btn_escpecial
            // 
            btn_escpecial.BackColor = Color.Linen;
            btn_escpecial.Cursor = Cursors.Hand;
            btn_escpecial.FlatAppearance.BorderSize = 0;
            btn_escpecial.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_escpecial.FlatAppearance.MouseOverBackColor = Color.White;
            btn_escpecial.FlatStyle = FlatStyle.Flat;
            btn_escpecial.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_escpecial.ForeColor = Color.FromArgb(67, 36, 24);
            btn_escpecial.Location = new Point(90, 3);
            btn_escpecial.Name = "btn_escpecial";
            btn_escpecial.Size = new Size(132, 33);
            btn_escpecial.TabIndex = 3;
            btn_escpecial.Text = "Especial páscoa";
            btn_escpecial.UseVisualStyleBackColor = false;
            // 
            // btn_aniversario
            // 
            btn_aniversario.BackColor = Color.Linen;
            btn_aniversario.Cursor = Cursors.Hand;
            btn_aniversario.FlatAppearance.BorderSize = 0;
            btn_aniversario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_aniversario.FlatAppearance.MouseOverBackColor = Color.White;
            btn_aniversario.FlatStyle = FlatStyle.Flat;
            btn_aniversario.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_aniversario.ForeColor = Color.FromArgb(67, 36, 24);
            btn_aniversario.Location = new Point(228, 3);
            btn_aniversario.Name = "btn_aniversario";
            btn_aniversario.Size = new Size(109, 33);
            btn_aniversario.TabIndex = 4;
            btn_aniversario.Text = "Aniversário";
            btn_aniversario.UseVisualStyleBackColor = false;
            // 
            // pnl_promo
            // 
            pnl_promo.BackColor = Color.BlanchedAlmond;
            pnl_promo.Controls.Add(btn_aniversario);
            pnl_promo.Controls.Add(btn_Todos);
            pnl_promo.Controls.Add(btn_escpecial);
            pnl_promo.Dock = DockStyle.Top;
            pnl_promo.Location = new Point(0, 0);
            pnl_promo.Margin = new Padding(0);
            pnl_promo.Name = "pnl_promo";
            pnl_promo.Size = new Size(712, 42);
            pnl_promo.TabIndex = 5;
            // 
            // flp_promo
            // 
            flp_promo.AutoScroll = true;
            flp_promo.BackColor = Color.BlanchedAlmond;
            flp_promo.Dock = DockStyle.Fill;
            flp_promo.Location = new Point(0, 42);
            flp_promo.Name = "flp_promo";
            flp_promo.Size = new Size(712, 449);
            flp_promo.TabIndex = 6;
            // 
            // controletres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_promo);
            Controls.Add(pnl_promo);
            Name = "controletres";
            Size = new Size(712, 491);
            pnl_promo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_escpecial;
        private Button btn_aniversario;
        private Panel pnl_promo;
        private FlowLayoutPanel flp_promo;
    }
}
