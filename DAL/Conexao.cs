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

        SqlConnection con = new SqlConnection();

        public Conexao()
        {

            con.ConnectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True;Trust Server Certificate=True";

        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
    if (con.State == System.Data.ConnectionState.Open)
    {
        con.Close();
    }
        } 


    }
}
