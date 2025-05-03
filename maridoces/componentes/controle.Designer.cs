namespace maridoces.componentes
{
    partial class controle
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
            btn_chocolate = new Button();
            btn_Branca = new Button();
            btn_lowcarb = new Button();
            panel1 = new Panel();
            flp_Bolos = new FlowLayoutPanel();
            panel1.SuspendLayout();
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
            btn_Todos.TabIndex = 0;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = false;
            // 
            // btn_chocolate
            // 
            btn_chocolate.BackColor = Color.Linen;
            btn_chocolate.Cursor = Cursors.Hand;
            btn_chocolate.FlatAppearance.BorderSize = 0;
            btn_chocolate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_chocolate.FlatAppearance.MouseOverBackColor = Color.White;
            btn_chocolate.FlatStyle = FlatStyle.Flat;
            btn_chocolate.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chocolate.ForeColor = Color.FromArgb(67, 36, 24);
            btn_chocolate.Location = new Point(213, 3);
            btn_chocolate.Name = "btn_chocolate";
            btn_chocolate.Size = new Size(156, 33);
            btn_chocolate.TabIndex = 2;
            btn_chocolate.Text = "Massa de chocolate";
            btn_chocolate.UseVisualStyleBackColor = false;
            // 
            // btn_Branca
            // 
            btn_Branca.BackColor = Color.Linen;
            btn_Branca.Cursor = Cursors.Hand;
            btn_Branca.FlatAppearance.BorderSize = 0;
            btn_Branca.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Branca.FlatAppearance.MouseOverBackColor = Color.White;
            btn_Branca.FlatStyle = FlatStyle.Flat;
            btn_Branca.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Branca.ForeColor = Color.FromArgb(67, 36, 24);
            btn_Branca.Location = new Point(90, 3);
            btn_Branca.Name = "btn_Branca";
            btn_Branca.Size = new Size(117, 33);
            btn_Branca.TabIndex = 3;
            btn_Branca.Text = "Massa Branca";
            btn_Branca.UseVisualStyleBackColor = false;
            // 
            // btn_lowcarb
            // 
            btn_lowcarb.BackColor = Color.Linen;
            btn_lowcarb.Cursor = Cursors.Hand;
            btn_lowcarb.FlatAppearance.BorderSize = 0;
            btn_lowcarb.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_lowcarb.FlatAppearance.MouseOverBackColor = Color.White;
            btn_lowcarb.FlatStyle = FlatStyle.Flat;
            btn_lowcarb.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_lowcarb.ForeColor = Color.FromArgb(67, 36, 24);
            btn_lowcarb.Location = new Point(375, 3);
            btn_lowcarb.Name = "btn_lowcarb";
            btn_lowcarb.Size = new Size(96, 33);
            btn_lowcarb.TabIndex = 4;
            btn_lowcarb.Text = "Low carb";
            btn_lowcarb.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(btn_lowcarb);
            panel1.Controls.Add(btn_Todos);
            panel1.Controls.Add(btn_chocolate);
            panel1.Controls.Add(btn_Branca);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 44);
            panel1.TabIndex = 5;
            // 
            // flp_Bolos
            // 
            flp_Bolos.AutoScroll = true;
            flp_Bolos.BackColor = Color.BlanchedAlmond;
            flp_Bolos.Dock = DockStyle.Fill;
            flp_Bolos.Location = new Point(0, 44);
            flp_Bolos.Margin = new Padding(0);
            flp_Bolos.Name = "flp_Bolos";
            flp_Bolos.Size = new Size(727, 492);
            flp_Bolos.TabIndex = 6;
            // 
            // controle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flp_Bolos);
            Controls.Add(panel1);
            Name = "controle";
            Size = new Size(727, 536);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_chocolate;
        private Button btn_Branca;
        private Button btn_lowcarb;
        private Panel panel1;
        private FlowLayoutPanel flp_Bolos;
    }
}
