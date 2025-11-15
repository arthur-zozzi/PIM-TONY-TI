using System;
using Microsoft.Data.SqlClient;
using System.Linq;
using TonyTI_Login.DAL;

namespace TonyTI_Login.Modelo
{
    public class Controle
    {
        public bool tem; // Indica se o login foi encontrado
        public string mensagem = ""; //  Guarda mensagens de erro
        public string perfilUsuario = ""; // Guarda o perfil retornado do banco (Cliente/Técnico)

        // MÉTODO: VERIFICA LOGIN E RETORNA PERFIL
        public bool acessar(string login, string senha)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            // ✅ Corrigido: campos e nomes consistentes com seu banco
            cmd.CommandText = @"
                SELECT TOP 1 Perfil 
                FROM Usuarios 
                WHERE Email = @Email AND Senha = @Senha";

            cmd.Parameters.AddWithValue("@Email", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    tem = true;
                    while (reader.Read())
                    {
                        // Lê o valor do campo "Perfil" e salva
                        perfilUsuario = reader["Perfil"].ToString().Trim();

                        // Caso venha vazio ou nulo, define Cliente como padrão
                        if (string.IsNullOrEmpty(perfilUsuario))
                            perfilUsuario = "Cliente";
                    }
                }
                else
                {
                    tem = false;
                }

                con.desconectar();
            }
            catch (SqlException ex)
            {
                this.mensagem = "Erro ao acessar o banco de dados: " + ex.Message;
            }

            return tem;
        }

        // MÉTODO: CADASTRAR NOVO USUÁRIO
        public string cadastrar(string email, string senha, string confirmarSenha, string perfil = "Cliente")
        {
            //  Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(confirmarSenha))
            {
                this.tem = false;
                return "Preencha todos os campos obrigatórios.";
            }

            //  Verifica se as senhas coincidem
            if (!senha.Equals(confirmarSenha))
            {
                this.tem = false;
                return "As senhas não coincidem.";
            }

            // Verifica força mínima da senha
            if (senha.Length < 8 || !senha.Any(char.IsLetter) || !senha.Any(char.IsDigit))
            {
                this.tem = false;
                return "A senha precisa conter mais de 8 dígitos e ser composta por letras e números.";
            }

            try
            {
                Conexao con = new Conexao();

                // Verifica se o e-mail já está cadastrado
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Email = @Email", con.conectar()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)cmd.ExecuteScalar();
                    con.desconectar();

                    if (count > 0)
                    {
                        this.tem = false;
                        return "Este e-mail já está cadastrado.";
                    }
                }

                // Cadastra novo usuário com perfil (Cliente por padrão)
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (Email, Senha, Perfil) VALUES (@Email, @Senha, @Perfil)", con.conectar()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    cmd.Parameters.AddWithValue("@Perfil", perfil);
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                }

                this.tem = true;
                return "Usuário cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                this.tem = false;
                return "Erro ao cadastrar usuário: " + ex.Message;
            }
        }
    }
}
