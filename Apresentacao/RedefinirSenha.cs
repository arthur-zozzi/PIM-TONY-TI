using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TonyTI_Login.Properties;
using System.Data.SqlClient;


namespace TonyTI_Login.Apresentacao
{
    public partial class RedefinirSenha : Form
    {
        private string emailUsuario;
        public RedefinirSenha(string email)
        {
            InitializeComponent();
            emailUsuario = email;
        }
        private void viewNewPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
            viewNewPass.Image = Resources.showPass;
        }

        private void viewNewPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            viewNewPass.Image = Resources.hiddenPass;
        }

        private void viewConfirmPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
            viewConfirmPass.Image = Resources.hiddenPass;
        }

        private void viewConfirmPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
            viewConfirmPass.Image = Resources.showPass;
        }

        private void btnAlterarSenha_Click_1(object sender, EventArgs e)
        {
            string novaSenha = txtNewPassword.Text.Trim();
            string confirmarSenha = txtConfirmPassword.Text.Trim();

            // Validação dos campos
            if (string.IsNullOrEmpty(novaSenha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação de padrão forte de senha
            // Pelo menos 8 caracteres, com letras e números
            if (!System.Text.RegularExpressions.Regex.IsMatch(novaSenha, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                MessageBox.Show("A senha precisa conter mais 8 dígitos e precisa ser composta por letras e números.", "Senha fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Atualiza a senha no banco
            try
            {
                string connectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE Usuarios SET senha = @senha WHERE email = @email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@senha", novaSenha);
                        cmd.Parameters.AddWithValue("@email", emailUsuario);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível redefinir a senha. Verifique o e-mail do usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}