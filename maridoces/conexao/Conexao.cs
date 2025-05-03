using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace maridoces.conexao
{
    internal class Conexao
    {
        // Gerando a string de conexão do nosso banco de dados
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "127.0.0.1",       // nome do servidor (Ex: "127.0.0.1")
            Port = 3306,                // porta do servidor (Ex: 3306) (é do tipo uint)
            UserID = "root",            // nome de usuario (string)
            Password = "",              // senha de usuario (string)
            Database = "db_doceria2",    // nome da base de dados (string)
        };

        // Variavel que irar receber a nossa string de conexão
        private MySqlConnection connection;

        // Metodo construtor da nosssa classe
        public Conexao()
        {
            // Gerando a conexão
            this.connection = new MySqlConnection(builder.ConnectionString);
        }

        // Função/metodo de abrir a nossa conexão
        public MySqlConnection Start()
        {
            // SE o estado da conexão for "fechada" abrir uma nova conexão
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // SENAO retornar a conexao que já esta aberta
            return connection;
        }

        // Função/metodo de fechar a nossa conexão
        public void Close()
        {
            // SE a conexão estiver aberta
            if (connection.State == ConnectionState.Open)
            {
                //Fechar conexao
                connection.Close();
            }
        }
    }
}
