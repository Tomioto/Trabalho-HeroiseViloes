using HeroisViloes.Model;
using HeroisViloes.Model.DAO;
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

namespace Trabalho_HeroiseViloes.View.FormsVilao
{
    public partial class fmrConsuVilao : Form
    {
        vilaoDAO DAO;
        SuperVilao vilao;

        public fmrConsuVilao()
        {
            InitializeComponent();
            DAO = new vilaoDAO();
            vilao = new SuperVilao();
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
        }

        private void btnConsul_Click(object sender, EventArgs e)
        {
            DAO.consultar(dt_viewConsul, txt_buscar.Text);
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            vilao.IdPessoa = Convert.ToInt32(dt_viewConsul.SelectedCells[0].Value);
            vilao.NomePessoa = dt_viewConsul.SelectedCells[1].Value.ToString();
            vilao.AnoNasc = Convert.ToInt32(dt_viewConsul.SelectedCells[2].Value);
            vilao.Idade = Convert.ToInt32(dt_viewConsul.SelectedCells[3].Value);
            vilao.Email = dt_viewConsul.SelectedCells[4].Value.ToString();
            vilao.caminhoImagem = dt_viewConsul.SelectedCells[5].Value.ToString();
            vilao.NomeVilao = dt_viewConsul.SelectedCells[6].Value.ToString();
            vilao.PlanetaOrigem = dt_viewConsul.SelectedCells[7].Value.ToString();
            vilao.Parceiro = dt_viewConsul.SelectedCells[8].Value.ToString();
            vilao.SuperPoder = dt_viewConsul.SelectedCells[9].Value.ToString();
            fmrAlterVilao form = new fmrAlterVilao(vilao);
            form.ShowDialog();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DAO.excluir(Convert.ToInt32(dt_viewConsul.SelectedCells[0].Value));
            DAO.consultar(dt_viewConsul, txt_buscar.Text);
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            fmrIncluVilao fmrvilao = new fmrIncluVilao();
            fmrvilao.ShowDialog();
        }
    }
}
