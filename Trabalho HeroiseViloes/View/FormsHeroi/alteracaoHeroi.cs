using HeroisViloes.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_HeroiseViloes.Model.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Trabalho_HeroiseViloes.View.FormsHeroi
{
    public partial class fmrAlterHeroi : Form
    {
        HeroiDAO DAO;
        SuperHeroi heroi;
        public fmrAlterHeroi()
        {
            InitializeComponent();
            DAO = new HeroiDAO();
            heroi = new SuperHeroi();
        }
        public fmrAlterHeroi(object objeto) :this() 
        {
            heroi = objeto as SuperHeroi;
            txtNome.Text = heroi.NomePessoa;
            txtAnoNasc.Text = heroi.AnoNasc.ToString();
            txtEmail.Text = heroi.Email;
            pictureBox1.ImageLocation = heroi.caminhoImagem;
            txtNomeHeroi.Text = heroi.NomeHeroi;
            txtPlanetaOrigem.Text = heroi.PlanetaOrigem;
            txtAtividadeProfissional.Text = heroi.AtividadeProfissional;
            txtParceiro.Text =  heroi.Parceiro;
            txtSuperPoder.Text = heroi.SuperPoder;
            txt_pontoFraco.Text = heroi.PontoFraco;
            txtGrupo.Text = heroi.Grupo;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int n;
            if (txtNome.Text != ""){
                if (txtNomeHeroi.Text != "") {
                    if (txtPlanetaOrigem.Text != ""){
                        heroi.NomePessoa = txtNome.Text;
                        if(txtAnoNasc.Text != "" && int.TryParse(txtAnoNasc.Text, out n)) {
                            heroi.AnoNasc = n;
                            heroi.calcularIdade(2023);
                        } else {
                            MessageBox.Show("Verifique o campo Ano de Nascimento!");
                            return;
                        }
                        heroi.Email = txtEmail.Text;
                        heroi.caminhoImagem = pictureBox1.ImageLocation;
                        heroi.NomeHeroi = txtNomeHeroi.Text;
                        heroi.PlanetaOrigem = txtPlanetaOrigem.Text;
                        heroi.AtividadeProfissional = txtAtividadeProfissional.Text;
                        heroi.Parceiro = txtParceiro.Text;
                        heroi.SuperPoder = txtSuperPoder.Text;
                        heroi.PontoFraco = txt_pontoFraco.Text;
                        heroi.Grupo = txtGrupo.Text;
                        bool teste = DAO.atualizar(heroi);
                        if (teste){
                            Close();
                        }
                    } else{
                        MessageBox.Show("Confirme se foi informado o campo Planeta de Origem!");
                    }
                } else {
                    MessageBox.Show("Confirme se foi informado o campo Nome do Herói!");
                }
            } else {
                MessageBox.Show("Confirme se foi informado o campo Nome!");
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg Files(*.jpg) |*.jpg| png Files(*.png) |*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pictureBox1.ImageLocation = path;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAnoNasc.Clear();
            txtEmail.Clear();
            pictureBox1.ImageLocation = null;
            txtNomeHeroi.Clear();
            txtPlanetaOrigem.Clear();
            txtAtividadeProfissional.Clear();
            txtParceiro.Clear();
            txtSuperPoder.Clear();
            txt_pontoFraco.Clear();
            txtGrupo.Clear();
        }
    }
}
