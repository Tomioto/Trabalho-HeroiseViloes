using HeroisViloes.Model.DAO;
using HeroisViloes.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_HeroiseViloes.Model.DAO
{
    class HeroiDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            SuperHeroi heroi = new SuperHeroi();
            heroi = (SuperHeroi)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE herois set nome = '" + heroi.NomePessoa +
                 "', anoNasc =" + heroi.AnoNasc +
                 ", idade = " + heroi.Idade +
                 ", email = '" + heroi.Email +
                 "', caminhoImagem = '" + heroi.caminhoImagem +
                 "', nomeHeroi = '" + heroi.NomeHeroi +
                 "', planetaOrigem = '" + heroi.PlanetaOrigem +
                 "', atividadeProfissional = '" + heroi.AtividadeProfissional +
                 "', parceiro = '" + heroi.Parceiro +
                 "', superPoder = '" + heroi.SuperPoder +
                 "', grupo = '" + heroi.Grupo +
                 "', pontoFraco = '" + heroi.PontoFraco +
                 "' Where idHeroi =" + heroi.IdPessoa;
            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(UPDATE, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Dados  do herói atualizados com sucesso!");
                    Console.WriteLine("Sucesso na Atualização dos Dados");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro na Atualização" + ex);
            }
            finally { Conexao.fecharConexao(); }
            return sucesso;

        }

        public void consultar(DataGridView dt_view,string filtro)
        {
            string sql = "SELECT * FROM HEROIS";
            if (int.TryParse(filtro, out int n))
            {
                sql += " where idHeroi = " + n;
            }
            else
            {
                sql += " WHERE nome LIKE '%" + filtro + "%'";
            }

            SqlConnection conexaoDB = Conexao.obterConexao();
            SqlCommand sconect = new SqlCommand(sql, conexaoDB);
            SqlDataAdapter adapter = new SqlDataAdapter(sconect);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dt_view.ReadOnly = true;
            dt_view.DataSource = ds.Tables[0];
        }

        public bool excluir(int idHeroi)
        {
            bool sucesso = false;
            string DELETE = "DELETE FROM herois WHERE idHeroi = " + idHeroi;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, conexaoDB);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Command.Dispose();
                    sucesso = true;
                    MessageBox.Show("Registro excluido com sucesso");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de exclusão" + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }

        public bool inserir(object objeto)
        {
            SuperHeroi heroi = new SuperHeroi();
            heroi = (SuperHeroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO herois (nome, anoNasc, idade, " +
                "email, nomeHeroi, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder,pontoFraco, grupo, caminhoImagem) " +
                "values (' " + heroi.NomePessoa +
                "', '" + heroi.AnoNasc +
                "', '" + heroi.Idade +
                "', '" + heroi.Email +
                "', '" + heroi.NomeHeroi +
                "', '" + heroi.PlanetaOrigem +
                "', '" + heroi.AtividadeProfissional +
                "', '" + heroi.Parceiro +
                "', '" + heroi.SuperPoder +
                "', '" + heroi.PontoFraco+
                "', '" + heroi.Grupo +
                "', '" + heroi.caminhoImagem +
                "' )";

            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Inscrição");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de Inserção " + ex);
            }

            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
    }
}