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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using HeroisViloes.Model.DAO;

namespace Trabalho_HeroiseViloes.View.FormsAmigoHeroi
{
    public partial class fmrIncluAmigo : Form
    {
        AmigoDAO DAO;
        AmigoHeroi amigoHeroi;
        public fmrIncluAmigo()
        {
            InitializeComponent();
            DAO = new AmigoDAO();
            amigoHeroi = new AmigoHeroi(); 
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAnoNasc.Clear();
            txtEmail.Clear();
            pictureBox1.ImageLocation = null;
            txtHobby.Clear();
            txtAtivProfissional.Clear();
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            int n;
            if(txtNome.Text != "") { 
                if(int.TryParse(txtAnoNasc.Text, out n))
                {
                    amigoHeroi.NomePessoa = txtNome.Text;
                    amigoHeroi.AnoNasc = n;
                    amigoHeroi.calcularIdade(2023);
                    amigoHeroi.Email = txtEmail.Text;
                    amigoHeroi.caminhoImagem = pictureBox1.ImageLocation;
                    amigoHeroi.Hobby = txtHobby.Text;
                    amigoHeroi.AtividadeProfissional = txtAtivProfissional.Text;
                    DAO.inserir(amigoHeroi);
                    MessageBox.Show("Registro inserido com sucesso");
                    this.Close();
                }
                else {
                    MessageBox.Show("Verifique o campo Ano de Nascimento!");
                }
            } else {
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
    }
}