using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace maridoces.conexao
{
    public class ConsultaSabores
    {
        public static DataTable listarProdutos()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = "SELECT * FROM  tb_sabores;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);
                // Retornar o objeto dataTable preenchido
                return dataTable;
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
