using System;
using Trabalho_HeroiseViloes.Model.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroisViloes.Model.Entities;
using HeroisViloes.Model;

namespace Trabalho_HeroiseViloes.View.FormsHeroi
{
    public partial class fmrIncluHeroi : Form
    {
        HeroiDAO DAO;
        SuperHeroi Heroi;
        public fmrIncluHeroi()
        {
            InitializeComponent();
            DAO = new HeroiDAO();
            Heroi = new SuperHeroi();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAnoNasc.Clear();
            txtEmail.Clear();
            pictureBox1.Image = null;
            txtNomeHeroi.Clear();
            txtPlanetaOrigem.Clear();
            txtAtividadeProfissional.Clear();
            txtParceiro.Clear();
            txtSuperPoder.Clear();
            txtGrupo.Clear();
            txt_pontoFraco.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int n;
            if (txtNome.Text != "")
            {
                if (txtNomeHeroi.Text != "")
                {
                    if (txtPlanetaOrigem.Text != "")
                    {
                        Heroi.NomePessoa = txtNome.Text;
                        if (int.TryParse(txtAnoNasc.Text, out n))
                        {
                            Heroi.AnoNasc = n;
                            Heroi.calcularIdade(2023);
                        }
                        else
                        {
                            MessageBox.Show("Verifique o campo Ano de Nascimento!");
                            return;
                        }
                        Heroi.Email = txtEmail.Text;
                        Heroi.caminhoImagem = pictureBox1.ImageLocation;
                        Heroi.NomeHeroi = txtNomeHeroi.Text;
                        Heroi.PlanetaOrigem = txtPlanetaOrigem.Text;
                        Heroi.AtividadeProfissional = txtAtividadeProfissional.Text;
                        Heroi.Parceiro = txtParceiro.Text;
                        Heroi.SuperPoder = txtSuperPoder.Text;
                        Heroi.PontoFraco = txt_pontoFraco.Text;
                        Heroi.Grupo = txtGrupo.Text;
                        DAO.inserir(Heroi);
                        MessageBox.Show("Registro inserido com sucesso");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Confirme se foi informado o campo Planeta de Origem!");
                    }
                }
                else
                {
                    MessageBox.Show("Confirme se foi informado o campo Nome do Herói!");
                }
            }
            else
            {
                MessageBox.Show("Confirme se foi informado o campo Nome!");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg Files(*.jpg) |*.jpg| png Files(*.png) |*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pictureBox1.ImageLocation = path;
            }
        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
