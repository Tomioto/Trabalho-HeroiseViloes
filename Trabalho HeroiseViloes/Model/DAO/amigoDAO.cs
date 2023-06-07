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
    class AmigoDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE amigosHeroi set nome = '" + amigo.NomePessoa +
                 "', anoNasc = " + amigo.AnoNasc +
                 ", idade = " + amigo.Idade +
                 ", email = '" + amigo.Email +
                 "', caminhoImagem = '" + amigo.caminhoImagem +
                 "', atividadeProfissional = '" + amigo.AtividadeProfissional +
                 "', hobby = '" + amigo.Hobby +
                 "' Where idAmigo = " + amigo.IdPessoa;
            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(UPDATE, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucesso na Atualização dos Dados");
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
            string sql = "SELECT * FROM AMIGOSHEROI";
            if (int.TryParse(filtro, out int n))
            {
                sql += " where idAmigo = " + n;
            } else
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

        public bool excluir(int idAmigo)
        {
            bool sucesso = false;
            string DELETE = "DELETE FROM amigosHeroi WHERE idAmigo = " + idAmigo;
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
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO amigosHeroi (nome, anoNasc, idade, " +
                "email, caminhoImagem, atividadeProfissional, hobby) " +
                "values (' " + amigo.NomePessoa +
                "', '" + amigo.AnoNasc +
                "', '" + amigo.Idade +
                "', '" + amigo.Email +
                "', '" + amigo.caminhoImagem +
                "', '" + amigo.AtividadeProfissional +
                "', '" + amigo.Hobby +
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