namespace maridoces.conexao
{
    partial class controledois
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
            btn_zero = new Button();
            pnl_pao = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnl_pao.SuspendLayout();
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
            btn_Todos.TabIndex = 1;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = false;
            // 
            // btn_zero
            // 
            btn_zero.BackColor = Color.Linen;
            btn_zero.Cursor = Cursors.Hand;
            btn_zero.FlatAppearance.BorderSize = 0;
            btn_zero.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_zero.FlatAppearance.MouseOverBackColor = Color.White;
            btn_zero.FlatStyle = FlatStyle.Flat;
            btn_zero.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_zero.ForeColor = Color.FromArgb(67, 36, 24);
            btn_zero.Location = new Point(90, 3);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(81, 33);
            btn_zero.TabIndex = 3;
            btn_zero.Text = "Low carb";
            btn_zero.UseVisualStyleBackColor = false;
            // 
            // pnl_pao
            // 
            pnl_pao.AutoScroll = true;
            pnl_pao.BackColor = Color.BlanchedAlmond;
            pnl_pao.Controls.Add(btn_zero);
            pnl_pao.Controls.Add(btn_Todos);
            pnl_pao.Dock = DockStyle.Top;
            pnl_pao.Location = new Point(0, 0);
            pnl_pao.Margin = new Padding(0);
            pnl_pao.Name = "pnl_pao";
            pnl_pao.Size = new Size(802, 43);
            pnl_pao.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.BlanchedAlmond;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 43);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(802, 461);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // controledois
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnl_pao);
            Name = "controledois";
            Size = new Size(802, 504);
            pnl_pao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_zero;
        private Panel pnl_pao;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
