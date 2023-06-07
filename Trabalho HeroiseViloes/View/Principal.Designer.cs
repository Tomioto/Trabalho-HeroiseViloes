namespace Trabalho_HeroiseViloes
{
    partial class frmPrincipal
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
            this.pn_principal = new System.Windows.Forms.Panel();
            this.MenuInserirHeroi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInserirAmigo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInserirVilao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExcluirHeroi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExcluirAmigo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExcluirVilao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlterarHeroi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlterarAmigo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlterarVilao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_principal
            // 
            this.pn_principal.BackColor = System.Drawing.Color.Transparent;
            this.pn_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_principal.Location = new System.Drawing.Point(0, 24);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(800, 426);
            this.pn_principal.TabIndex = 1;
            // 
            // MenuInserirHeroi
            // 
            this.MenuInserirHeroi.Name = "MenuInserirHeroi";
            this.MenuInserirHeroi.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuInserirAmigo
            // 
            this.MenuInserirAmigo.Name = "MenuInserirAmigo";
            this.MenuInserirAmigo.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuInserirVilao
            // 
            this.MenuInserirVilao.Name = "MenuInserirVilao";
            this.MenuInserirVilao.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuExcluirHeroi
            // 
            this.MenuExcluirHeroi.Name = "MenuExcluirHeroi";
            this.MenuExcluirHeroi.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuExcluirAmigo
            // 
            this.MenuExcluirAmigo.Name = "MenuExcluirAmigo";
            this.MenuExcluirAmigo.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuExcluirVilao
            // 
            this.MenuExcluirVilao.Name = "MenuExcluirVilao";
            this.MenuExcluirVilao.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuAlterarHeroi
            // 
            this.MenuAlterarHeroi.Name = "MenuAlterarHeroi";
            this.MenuAlterarHeroi.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuAlterarAmigo
            // 
            this.MenuAlterarAmigo.Name = "MenuAlterarAmigo";
            this.MenuAlterarAmigo.Size = new System.Drawing.Size(32, 19);
            // 
            // MenuAlterarVilao
            // 
            this.MenuAlterarVilao.Name = "MenuAlterarVilao";
            this.MenuAlterarVilao.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInserir,
            this.MenuExcluir,
            this.MenuAlterar});
            this.inserirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.inserirToolStripMenuItem.Image = global::Trabalho_HeroiseViloes.Properties.Resources.casa;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.inserirToolStripMenuItem.Text = "Menu";
            // 
            // MenuInserir
            // 
            this.MenuInserir.Image = global::Trabalho_HeroiseViloes.Properties.Resources.super_heroi;
            this.MenuInserir.Name = "MenuInserir";
            this.MenuInserir.Size = new System.Drawing.Size(142, 22);
            this.MenuInserir.Text = "Heroi";
            this.MenuInserir.Click += new System.EventHandler(this.MenuConsultarHeroi_Click);
            // 
            // MenuExcluir
            // 
            this.MenuExcluir.Image = global::Trabalho_HeroiseViloes.Properties.Resources.super_vilao;
            this.MenuExcluir.Name = "MenuExcluir";
            this.MenuExcluir.Size = new System.Drawing.Size(142, 22);
            this.MenuExcluir.Text = "Vilao";
            this.MenuExcluir.Click += new System.EventHandler(this.MenuConsultarVilao_Click);
            // 
            // MenuAlterar
            // 
            this.MenuAlterar.Image = global::Trabalho_HeroiseViloes.Properties.Resources.amizade;
            this.MenuAlterar.Name = "MenuAlterar";
            this.MenuAlterar.Size = new System.Drawing.Size(142, 22);
            this.MenuAlterar.Text = "Amigo Heroi";
            this.MenuAlterar.Click += new System.EventHandler(this.MenuConsultarAmigo_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuSair.Image = global::Trabalho_HeroiseViloes.Properties.Resources.sair__1_;
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(54, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.sairMenu_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.menu_princi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_principal);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuInserir;
        private System.Windows.Forms.ToolStripMenuItem MenuInserirHeroi;
        private System.Windows.Forms.ToolStripMenuItem MenuInserirAmigo;
        private System.Windows.Forms.ToolStripMenuItem MenuInserirVilao;
        private System.Windows.Forms.ToolStripMenuItem MenuExcluir;
        private System.Windows.Forms.ToolStripMenuItem MenuExcluirHeroi;
        private System.Windows.Forms.ToolStripMenuItem MenuExcluirAmigo;
        private System.Windows.Forms.ToolStripMenuItem MenuExcluirVilao;
        private System.Windows.Forms.ToolStripMenuItem MenuAlterar;
        private System.Windows.Forms.ToolStripMenuItem MenuAlterarHeroi;
        private System.Windows.Forms.ToolStripMenuItem MenuAlterarAmigo;
        private System.Windows.Forms.ToolStripMenuItem MenuAlterarVilao;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Panel pn_principal;
    }
}

