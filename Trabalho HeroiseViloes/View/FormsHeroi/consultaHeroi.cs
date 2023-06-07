using HeroisViloes.Model;
using HeroisViloes.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_HeroiseViloes.Model.DAO;
using Trabalho_HeroiseViloes.View;

namespace Trabalho_HeroiseViloes.View.FormsHeroi
{
    public partial class fmrConsuHeroi : Form
    {
        HeroiDAO DAO;
        SuperHeroi heroi;
        public fmrConsuHeroi()
        {
            InitializeComponent();
            DAO = new HeroiDAO();
            heroi = new SuperHeroi();
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
        }

        private void btnConsul_Click(object sender, EventArgs e)
        {
            DAO.consultar(dt_viewConsul, txt_buscar.Text);
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            heroi.IdPessoa = Convert.ToInt32(dt_viewConsul.SelectedCells[0].Value);
            heroi.NomePessoa = dt_viewConsul.SelectedCells[1].Value.ToString();
            heroi.AnoNasc = Convert.ToInt32(dt_viewConsul.SelectedCells[2].Value);
            heroi.Idade = Convert.ToInt32(dt_viewConsul.SelectedCells[3].Value);
            heroi.Email = dt_viewConsul.SelectedCells[4].Value.ToString();
            heroi.caminhoImagem = dt_viewConsul.SelectedCells[5].Value.ToString();
            heroi.NomeHeroi = dt_viewConsul.SelectedCells[6].Value.ToString();
            heroi.PlanetaOrigem = dt_viewConsul.SelectedCells[7].Value.ToString();
            heroi.AtividadeProfissional = dt_viewConsul.SelectedCells[8].Value.ToString();
            heroi.Parceiro = dt_viewConsul.SelectedCells[9].Value.ToString();
            heroi.SuperPoder = dt_viewConsul.SelectedCells[10].Value.ToString();
            heroi.Grupo = dt_viewConsul.SelectedCells[11].Value.ToString();
            heroi.PontoFraco = dt_viewConsul.SelectedCells[12].Value.ToString();
            fmrAlterHeroi form = new fmrAlterHeroi(heroi);
            form.ShowDialog();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DAO.excluir(Convert.ToInt32(dt_viewConsul.SelectedCells[0].Value));
            DAO.consultar(dt_viewConsul, txt_buscar.Text);
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            fmrIncluHeroi fmrheroi = new fmrIncluHeroi();
            fmrheroi.ShowDialog();
        }
    }
}
