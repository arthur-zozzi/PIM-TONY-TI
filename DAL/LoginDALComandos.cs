using System;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace TonyTI_Login.DAL
{
    class LoginDALComandos
    {
        public bool tem = false;
        public string mensagem = "";

        public bool verificarLogin(string login, string senha)
        {
            tem = false;
            mensagem = "";

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM Usuarios WHERE email = @login AND senha = @senha";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                Conexao con = new Conexao();

                try
                {
                    cmd.Connection = con.conectar();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            tem = true;
                        }
                        dr.Close();
                    }
                    con.desconectar();
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro com o Banco de Dados: " + ex.Message;
                }
            }

            return tem;
        }

        public string cadastrar(string email, string senha, string confSenha)
        {
            tem = false;
            mensagem = "";

            // Valida o e-mail
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                this.mensagem = "E-mail inválido! Digite um e-mail válido.";
                return mensagem;
            }

            // Confirmação de senha
            if (!senha.Equals(confSenha))
            {
                this.mensagem = "Senhas não conferem!";
                return mensagem;
            }

            // Validação da senha (mínimo 8 caracteres, letras e números)
            bool contemLetra = Regex.IsMatch(senha, @"[a-zA-Z]");
            bool contemNumero = Regex.IsMatch(senha, @"\d");
            if (senha.Length < 8 || !contemLetra || !contemNumero)
            {
                this.mensagem = "A senha precisa conter mais de 8 dígitos e ser composta por letras e números!";
                return mensagem;
            }

            // Verifica se já existe o e-mail
            using (SqlCommand checkCmd = new SqlCommand())
            {
                checkCmd.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE email = @e";
                checkCmd.Parameters.AddWithValue("@e", email);

                Conexao con = new Conexao();
                try
                {
                    checkCmd.Connection = con.conectar();
                    int count = (int)checkCmd.ExecuteScalar();
                    con.desconectar();

                    if (count > 0)
                    {
                        this.mensagem = "Já existe um usuário com esse e-mail!";
                        return mensagem;
                    }
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro ao verificar usuário: " + ex.Message;
                    return mensagem;
                }
            }

            //  Se passou em todas as validações → cadastra
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Usuarios (email, senha) VALUES (@e, @s)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                Conexao con = new Conexao();
                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();

                    this.mensagem = "Cadastro realizado com sucesso!";
                    tem = true;
                }
                catch (SqlException ex)
                {
                    this.mensagem = "Erro com o Banco de Dados: " + ex.Message;
                }
            }

            return mensagem;
        }
    }
}
