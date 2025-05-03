using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maridoces.DTOs;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace maridoces.conexao
{
    internal class CategoriaDAL
    {
        public static DataTable ListarTodosAsCategorias()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"SELECT * FROM tb_categorias ORDER BY nome_categoria;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable tabela = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(tabela);

                return tabela;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }

    }
}
