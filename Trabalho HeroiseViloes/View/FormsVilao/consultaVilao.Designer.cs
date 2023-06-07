namespace Trabalho_HeroiseViloes.View.FormsVilao
{
    partial class fmrConsuVilao
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
            this.dt_viewConsul = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsul = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_incluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_viewConsul)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_viewConsul
            // 
            this.dt_viewConsul.AllowUserToAddRows = false;
            this.dt_viewConsul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_viewConsul.Location = new System.Drawing.Point(15, 132);
            this.dt_viewConsul.Name = "dt_viewConsul";
            this.dt_viewConsul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_viewConsul.Size = new System.Drawing.Size(684, 215);
            this.dt_viewConsul.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Busca por personagnes";
            // 
            // btnConsul
            // 
            this.btnConsul.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_consul;
            this.btnConsul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsul.Location = new System.Drawing.Point(242, 107);
            this.btnConsul.Name = "btnConsul";
            this.btnConsul.Size = new System.Drawing.Size(110, 21);
            this.btnConsul.TabIndex = 7;
            this.btnConsul.Text = "Consultar";
            this.btnConsul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsul.UseVisualStyleBackColor = true;
            this.btnConsul.Click += new System.EventHandler(this.btnConsul_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(18, 108);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(218, 20);
            this.txt_buscar.TabIndex = 8;
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_limp;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Location = new System.Drawing.Point(474, 107);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(110, 22);
            this.bt_excluir.TabIndex = 13;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_edit;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Location = new System.Drawing.Point(358, 107);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(110, 22);
            this.bt_editar.TabIndex = 12;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_incluir
            // 
            this.bt_incluir.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.color_include;
            this.bt_incluir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_incluir.Location = new System.Drawing.Point(590, 107);
            this.bt_incluir.Name = "bt_incluir";
            this.bt_incluir.Size = new System.Drawing.Size(110, 22);
            this.bt_incluir.TabIndex = 14;
            this.bt_incluir.Text = "Incluir";
            this.bt_incluir.UseVisualStyleBackColor = true;
            this.bt_incluir.Click += new System.EventHandler(this.bt_incluir_Click);
            // 
            // fmrConsuVilao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabalho_HeroiseViloes.Properties.Resources.vilao_trab_ofc;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_incluir);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.dt_viewConsul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btnConsul);
            this.Name = "fmrConsuVilao";
            this.Text = "Consultar um Vilao";
            ((System.ComponentModel.ISupportInitialize)(this.dt_viewConsul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dt_viewConsul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsul;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_incluir;
    }
}