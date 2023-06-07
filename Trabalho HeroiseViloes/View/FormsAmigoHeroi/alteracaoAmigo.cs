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

namespace Trabalho_HeroiseViloes.View.FormsAmigoHeroi
{
    public partial class fmrAlterAmigo : Form
    {
        AmigoHeroi amigoHeroi;
        AmigoDAO DAO;
        public fmrAlterAmigo()
        {
            InitializeComponent();
            amigoHeroi = new AmigoHeroi();
            DAO = new AmigoDAO();
        }
        public fmrAlterAmigo(Object amigo): this()
        {
            amigoHeroi = amigo as AmigoHeroi;
            txtNome.Text = amigoHeroi.NomePessoa;
            txtAnoNasc.Text = amigoHeroi.AnoNasc.ToString();
            txtEmail.Text = amigoHeroi.Email;
            txtAtivProfissional.Text = amigoHeroi.AtividadeProfissional;
            txtHobby.Text = amigoHeroi.Hobby;
            pictureBox1.ImageLocation = amigoHeroi.caminhoImagem;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int n;
            if (txtNome.Text != "")
            {
                if (int.TryParse(txtAnoNasc.Text, out n))
                {
                    amigoHeroi.NomePessoa = txtNome.Text;
                    amigoHeroi.AnoNasc = n;
                    amigoHeroi.calcularIdade(2023);
                    amigoHeroi.Email = txtEmail.Text;
                    amigoHeroi.caminhoImagem = pictureBox1.ImageLocation;
                    amigoHeroi.Hobby = txtHobby.Text;
                    amigoHeroi.AtividadeProfissional = txtAtivProfissional.Text;
                    bool teste = DAO.atualizar(amigoHeroi);
                    if (teste)
                    {
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Verifique o campo Ano de Nascimento!");
                }
            }
            else
            {
                MessageBox.Show("Verifique o campo Nome!");
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAnoNasc.Clear();
            txtEmail.Clear();
            txtAtivProfissional.Clear();
            txtHobby.Clear();
            pictureBox1.ImageLocation = null;
        }
    }
}
