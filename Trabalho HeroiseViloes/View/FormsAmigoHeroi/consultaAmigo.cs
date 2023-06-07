using HeroisViloes.Model;
using HeroisViloes.Model.DAO;
using HeroisViloes.Model.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Trabalho_HeroiseViloes.View;

namespace Trabalho_HeroiseViloes.View.FormsAmigoHeroi
{
    public partial class fmrConsuAmigo : Form
    {
        AmigoDAO DAO;
        AmigoHeroi amigo;
        Object alterarAmigo;

        public fmrConsuAmigo()
        {
            InitializeComponent();
            DAO = new AmigoDAO();
            amigo = new AmigoHeroi();
            alterarAmigo = new Object();
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
        }

        private void btnConsul_Click(object sender, EventArgs e)
        {
            DAO.consultar(dt_viewConsul, txt_buscar.Text);
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            if(dt_viewConsul.SelectedRows.Count == 1)
            {
                amigo.IdPessoa = Convert.ToInt32(dt_viewConsul.SelectedCells[0].Value);
                amigo.NomePessoa = Convert.ToString(dt_viewConsul.SelectedCells[1].Value);
                amigo.AnoNasc = Convert.ToInt32(dt_viewConsul.SelectedCells[2].Value);
                amigo.Idade = Convert.ToInt32(dt_viewConsul.SelectedCells[3].Value);
                amigo.Email = Convert.ToString(dt_viewConsul.SelectedCells[4].Value);
                amigo.caminhoImagem = Convert.ToString(dt_viewConsul.SelectedCells[5].Value);
                amigo.Hobby = Convert.ToString(dt_viewConsul.SelectedCells[6].Value);
                amigo.AtividadeProfissional = Convert.ToString(dt_viewConsul.SelectedCells[7].Value);
                fmrAlterAmigo formAlt = new fmrAlterAmigo(amigo);
                formAlt.Show();

            } else
            {
                MessageBox.Show("Selecione um Amigo do Heroi");
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DAO.excluir(Convert.ToInt32(dt_viewConsul.SelectedCells[0].Value));
            DAO.consultar(dt_viewConsul, txt_buscar.Text);
        }

        private void bt_incluir_Click(object sender, EventArgs e)
        {
            fmrIncluAmigo formIncl = new fmrIncluAmigo();
            formIncl.Show();
        }
    }
}


