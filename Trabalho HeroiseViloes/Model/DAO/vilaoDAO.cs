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

namespace HeroisViloes.Model
{
    class vilaoDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            SuperVilao vilao = new SuperVilao();
            vilao = (SuperVilao)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE viloes set nome = '" + vilao.NomePessoa +
                 "', anoNasc = " + vilao.AnoNasc +
                 ", idade = " + vilao.Idade +
                 ", email = '" + vilao.Email +
                 "', caminhoImagem = '" + vilao.caminhoImagem +
                 "', nomeVilao = '" + vilao.NomeVilao +
                 "', planetaOrigem = '" + vilao.PlanetaOrigem +
                 "', parceiro = '" + vilao.Parceiro +
                 "', superPoder = '" + vilao.SuperPoder +
                 "' Where idVilao = " + vilao.IdPessoa;
            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(UPDATE, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Registro atualizado com sucesso");
                       Console.WriteLine("Sucesso na Atualização dos Dados");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Atualização" + ex);
            }
            finally { Conexao.fecharConexao(); }
            return sucesso;

        }

        public void consultar(DataGridView dt_view, string filtro)
        {
            string sql = "SELECT * FROM viloes";
            if (int.TryParse(filtro, out int n))
            {
                sql += " where idVilao = " + n;
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

            public bool excluir(int idVilao)
        {
            bool sucesso = false;
            string DELETE = "DELETE FROM viloes WHERE idVilao = " + idVilao;
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
            SuperVilao vilao = new SuperVilao();
            vilao = (SuperVilao)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO VILOES (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeVilao, planetaOrigem, " +
                "parceiro, superPoder) " +
                "values (' " + vilao.NomePessoa +
                "', '" + vilao.AnoNasc +
                "', '" + vilao.Idade +
                "', '" + vilao.Email +
                "', '" + vilao.caminhoImagem +
                "', '" + vilao.NomeVilao +
                "', '" + vilao.PlanetaOrigem +
                "', '" + vilao.Parceiro +
                "', '" + vilao.SuperPoder +
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