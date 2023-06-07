using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_HeroiseViloes.View;
using Trabalho_HeroiseViloes.View.FormsAmigoHeroi;
using Trabalho_HeroiseViloes.View.FormsHeroi;
using Trabalho_HeroiseViloes.View.FormsVilao;

namespace Trabalho_HeroiseViloes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MENU HEROI

        private void MenuConsultarHeroi_Click(object sender, EventArgs e)
        {
            fmrConsuHeroi consultaHeroi = new fmrConsuHeroi();
            alterarPainel(consultaHeroi);
        }

        // MENU AMIGO

        private void MenuConsultarAmigo_Click(object sender, EventArgs e)
        {
            fmrConsuAmigo consultaAmigo = new fmrConsuAmigo();
            alterarPainel(consultaAmigo);
        }

        // MENU VILAO

        private void MenuConsultarVilao_Click(object sender, EventArgs e)
        {
            fmrConsuVilao consultaVilao = new fmrConsuVilao();
            alterarPainel(consultaVilao);
        }

        public void alterarPainel(Form form)
        {
            if(pn_principal.Controls.Count > 0)
            {
                pn_principal.Controls.Clear();
            }
            form.TopLevel = false;
            pn_principal.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;   
            form.Show();
        }

    }
}
