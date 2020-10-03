namespace AppBasquete
{
    partial class FormMain
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarJogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadorToolStripMenuItem,
            this.jogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogadorToolStripMenuItem
            // 
            this.jogadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarJogadorToolStripMenuItem,
            this.consultarJogadoresToolStripMenuItem});
            this.jogadorToolStripMenuItem.Name = "jogadorToolStripMenuItem";
            this.jogadorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.jogadorToolStripMenuItem.Text = "Jogador";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarJogoToolStripMenuItem,
            this.consultarJogoToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // cadastrarJogadorToolStripMenuItem
            // 
            this.cadastrarJogadorToolStripMenuItem.Name = "cadastrarJogadorToolStripMenuItem";
            this.cadastrarJogadorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarJogadorToolStripMenuItem.Text = "Cadastrar Jogador";
            // 
            // consultarJogadoresToolStripMenuItem
            // 
            this.consultarJogadoresToolStripMenuItem.Name = "consultarJogadoresToolStripMenuItem";
            this.consultarJogadoresToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultarJogadoresToolStripMenuItem.Text = "Consultar Jogadores";
            // 
            // cadastrarJogoToolStripMenuItem
            // 
            this.cadastrarJogoToolStripMenuItem.Name = "cadastrarJogoToolStripMenuItem";
            this.cadastrarJogoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarJogoToolStripMenuItem.Text = "Cadastrar Jogo";
            // 
            // consultarJogoToolStripMenuItem
            // 
            this.consultarJogoToolStripMenuItem.Name = "consultarJogoToolStripMenuItem";
            this.consultarJogoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarJogoToolStripMenuItem.Text = "Consultar Jogos";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 304);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "AppBasquete";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarJogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarJogoToolStripMenuItem;
    }
}

