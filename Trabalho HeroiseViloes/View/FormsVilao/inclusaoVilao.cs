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

namespace Trabalho_HeroiseViloes.View.FormsVilao
{
    public partial class fmrIncluVilao : Form
    {

        vilaoDAO DAO;
        SuperVilao vilao;
        public fmrIncluVilao()
        {
            InitializeComponent();
            DAO = new vilaoDAO();
            vilao = new SuperVilao();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAnoNasc.Clear();
            txtEmail.Clear();
            pictureBox1.ImageLocation = null;
            txtNomeVilao.Clear();
            txtPlanetaOrigem.Clear();
            txtParceiro.Clear();
            txtSuperPoder.Clear();

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (txtNomeVilao.Text != "")
                {
                    if (txtPlanetaOrigem.Text != "")
                    {
                        int n;
                        vilao.NomePessoa = txtNome.Text;
                        if (int.TryParse(txtAnoNasc.Text, out n))
                        {
                            vilao.AnoNasc = n;
                            vilao.calcularIdade(2023);
                        }
                        else
                        {
                            MessageBox.Show("Verifique o campo Ano de Nascimento!");
                            return;
                        }
                        vilao.Email = txtEmail.Text;
                        vilao.caminhoImagem = pictureBox1.ImageLocation;
                        vilao.NomeVilao = txtNomeVilao.Text;
                        vilao.PlanetaOrigem = txtPlanetaOrigem.Text;
                        vilao.Parceiro = txtParceiro.Text;
                        vilao.SuperPoder = txtSuperPoder.Text;
                        DAO.inserir(vilao);
                        MessageBox.Show("Registro inserido com sucesso");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Verifique o campo Planeta de Origem!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o campo Nome Vilão!");
                }

            }
            else
            {
                MessageBox.Show("Verifique o campo nome!");
            }
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

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}