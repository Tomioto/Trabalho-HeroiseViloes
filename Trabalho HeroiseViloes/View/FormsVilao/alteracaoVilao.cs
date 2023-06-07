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
using Trabalho_HeroiseViloes.View.FormsHeroi;
using Trabalho_HeroiseViloes.Model.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Trabalho_HeroiseViloes.View.FormsVilao
{
    public partial class fmrAlterVilao : Form
    {
        vilaoDAO DAO;
        SuperVilao vilao;

        public fmrAlterVilao()
        {
            InitializeComponent();
            DAO = new vilaoDAO();
            vilao = new SuperVilao();
        }

        public fmrAlterVilao(object objeto) : this()
        {
            vilao = objeto as SuperVilao;
            txtNome.Text = vilao.NomePessoa;
            txtAnoNasc.Text = vilao.AnoNasc.ToString();
            txtEmail.Text = vilao.Email;
            pictureBox1.ImageLocation = vilao.caminhoImagem;
            txtNomeVilao.Text = vilao.NomeVilao;
            txtPlanetaOrigem.Text = vilao.PlanetaOrigem;
            txtParceiro.Text = vilao.Parceiro;
            txtSuperPoder.Text = vilao.SuperPoder;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "") {
                if(txtNomeVilao.Text != "") { 
                    if(txtPlanetaOrigem.Text != "")
                    {
                        int n;
                        vilao.NomePessoa = txtNome.Text;
                        if (txtAnoNasc.Text != "" && int.TryParse(txtAnoNasc.Text, out n))
                        {
                            vilao.AnoNasc = n;
                            vilao.calcularIdade(2023);
                        }
                        else { 
                            MessageBox.Show("Verifique o campo Ano de Nascimento!");
                            return;
                        }
                        vilao.Email = txtEmail.Text;
                        vilao.caminhoImagem = pictureBox1.ImageLocation;
                        vilao.NomeVilao = txtNomeVilao.Text;
                        vilao.PlanetaOrigem = txtPlanetaOrigem.Text;
                        vilao.Parceiro = txtParceiro.Text;
                        vilao.SuperPoder = txtSuperPoder.Text;
                        DAO.atualizar(vilao);
                        Close();
                    } else {
                        MessageBox.Show("Verifique o campo Planeta de Origem!");
                    }
                } else { 
                    MessageBox.Show("Verifique o campo Nome Vilão!"); 
                }
                
            } else { 
                MessageBox.Show("Verifique o campo nome!"); 
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
            txtNomeVilao.Clear();
            txtPlanetaOrigem.Clear();
            txtSuperPoder.Clear();
            pictureBox1.ImageLocation = null;
            txtParceiro.Clear();
        }
    }
}
