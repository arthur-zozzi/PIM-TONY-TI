using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonyTI_Login.DAL
{
    public class Conexao
    {
        // Mantém a instância da conexão; usada para abrir e fechar ao longo das operações.
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            // Define a string de conexão
            con.ConnectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True;Trust Server Certificate=True";
        }

        public SqlConnection conectar()
        {
            // Abre a conexão somente quando está fechada; evita exceção de estado inválido.
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con; // Retorna a conexão ativa para uso no repositório.
        }

        public void desconectar()
        {
            // Fecha a conexão somente quando está aberta; reduz risco de exceções.
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
