namespace Trabalho_HeroiseViloes.View.FormsAmigoHeroi
{
    partial class fmrConsuAmigo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.dt_viewConsul = new System.Windows.Forms.DataGridView();
            this.bt_incluir = new System.Windows.Forms.Button();
            this.btnConsul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_viewConsul)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(17, 80);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(218, 20);
            this.txt_buscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busca por personagens";
            // 
            // bt_alterar
            // 
            this.bt_alterar.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_edit;
            this.bt_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterar.Location = new System.Drawing.Point(362, 81);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(109, 21);
            this.bt_alterar.TabIndex = 7;
            this.bt_alterar.Text = "Editar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_limp;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Location = new System.Drawing.Point(477, 81);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(109, 21);
            this.bt_excluir.TabIndex = 8;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // dt_viewConsul
            // 
            this.dt_viewConsul.AllowUserToAddRows = false;
            this.dt_viewConsul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_viewConsul.Location = new System.Drawing.Point(17, 105);
            this.dt_viewConsul.Name = "dt_viewConsul";
            this.dt_viewConsul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_viewConsul.Size = new System.Drawing.Size(684, 215);
            this.dt_viewConsul.TabIndex = 9;
            // 
            // bt_incluir
            // 
            this.bt_incluir.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_include;
            this.bt_incluir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_incluir.Location = new System.Drawing.Point(592, 81);
            this.bt_incluir.Name = "bt_incluir";
            this.bt_incluir.Size = new System.Drawing.Size(109, 21);
            this.bt_incluir.TabIndex = 10;
            this.bt_incluir.Text = "Incluir";
            this.bt_incluir.UseVisualStyleBackColor = true;
            this.bt_incluir.Click += new System.EventHandler(this.bt_incluir_Click);
            // 
            // btnConsul
            // 
            this.btnConsul.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_consul;
            this.btnConsul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsul.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsul.Location = new System.Drawing.Point(247, 81);
            this.btnConsul.Name = "btnConsul";
            this.btnConsul.Size = new System.Drawing.Size(109, 21);
            this.btnConsul.TabIndex = 0;
            this.btnConsul.Text = "Consultar";
            this.btnConsul.UseVisualStyleBackColor = true;
            this.btnConsul.Click += new System.EventHandler(this.btnConsul_Click);
            // 
            // fmrConsuAmigo
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.amigo_trab_ofc;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.bt_incluir);
            this.Controls.Add(this.dt_viewConsul);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btnConsul);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fmrConsuAmigo";
            this.Text = "Consultar um Amigo de Heroi";
            ((System.ComponentModel.ISupportInitialize)(this.dt_viewConsul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsul;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.DataGridView dt_viewConsul;
        private System.Windows.Forms.Button bt_incluir;
    }
}