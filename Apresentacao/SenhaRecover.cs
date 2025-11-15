using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TonyTI_Login.Apresentacao
{
    public partial class SenhaRecover : Form
    {
        private string codigoGerado = "";
        private string emailUsuario = "";
        private int tempoRestante = 180; // 3 minutos (em segundos)

        public SenhaRecover()
        {
            InitializeComponent();

            lblMensagem.Visible = false;
            lblPassRec.Visible = false;

            panelEmail.Visible = true;
            panelRec.Visible = false;

            // Configura o Timer
            timerRec.Interval = 1000; // 1 segundo
            timerRec.Tick += TimerRec_Tick;
        }

        // BOTÃO: Enviar código de verificação
        private void btnPassRecover_Click(object sender, EventArgs e)
        {
            string email = txtEmailRec.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MostrarMensagem("Campo obrigatório");
                return;
            }

            if (!EmailValido(email))
            {
                MostrarMensagem("Digite um e-mail válido!");
                return;
            }

            if (EmailRegistrado(email))
            {
                codigoGerado = GerarCodigoVerificacao(8);
                emailUsuario = email;

                try
                {
                    EnviarCodigoPorEmail(email, codigoGerado);
                    MostrarMensagem("Código enviado! Verifique seu e-mail.", Color.Green);

                    // Mostra o painel de verificação
                    panelEmail.Visible = false;
                    panelRec.Visible = true;

                    // Inicia a contagem regressiva
                    tempoRestante = 180;
                    lblPassRec.Visible = true;
                    AtualizarLabelTimer();
                    timerRec.Start();
                }
                catch (Exception ex)
                {
                    MostrarMensagem("Erro ao enviar e-mail: " + ex.Message);
                }
            }
            else
            {
                MostrarMensagem("E-mail não encontrado no sistema.");
            }
        }


        // BOTÃO: Reenviar código
        private void btnReenviarCodigo_Click(object sender, EventArgs e)
        {
            if (tempoRestante > 0)
            {
                MostrarMensagem($"Aguarde {tempoRestante / 60:D2}:{tempoRestante % 60:D2} para reenviar o código.");
                return;
            }

            try
            {
                codigoGerado = GerarCodigoVerificacao(8);
                EnviarCodigoPorEmail(emailUsuario, codigoGerado);
                MostrarMensagem("Novo código enviado com sucesso!", Color.Green);

                // Reinicia o timer
                tempoRestante = 180;
                AtualizarLabelTimer();
                timerRec.Start();
            }
            catch (Exception ex)
            {
                MostrarMensagem("Erro ao reenviar e-mail: " + ex.Message);
            }
        }

        // EVENTO DO TIMER
        private void TimerRec_Tick(object sender, EventArgs e)
        {
            tempoRestante--;

            if (tempoRestante > 0)
            {
                AtualizarLabelTimer();
            }
            else
            {
                timerRec.Stop();
                lblPassRec.Text = "Você já pode reenviar o código.";
                lblPassRec.ForeColor = Color.Blue;
            }
        }

        // MÉTODOS AUXILIARES

        private void AtualizarLabelTimer()
        {
            int minutos = tempoRestante / 60;
            int segundos = tempoRestante % 60;
            lblPassRec.Text = $"Reenviar código em {minutos:D2}:{segundos:D2}";
            lblPassRec.ForeColor = Color.Gray;
        }

        private void MostrarMensagem(string msg, Color? cor = null)
        {
            lblMensagem.Text = msg;
            lblMensagem.ForeColor = cor ?? Color.Red;
            lblMensagem.Visible = true;
        }

        private bool EmailValido(string email)
        {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        private bool EmailRegistrado(string email)
        {
            string connectionString = "Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT COUNT(*) FROM dbo.Usuarios WHERE Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensagem("Erro no banco: " + ex.Message);
                    return false;
                }
            }
        }

        private string GerarCodigoVerificacao(int tamanho)
        {
            Random rnd = new Random();
            string codigo = "";
            for (int i = 0; i < tamanho; i++)
                codigo += rnd.Next(0, 10).ToString();
            return codigo;
        }

        private void EnviarCodigoPorEmail(string emailDestino, string codigo)
        {
            string remetenteEmail = "gatogamer123xd@gmail.com"; // seu Gmail
            string remetenteSenha = "etqx busl fchy warw"; // senha gerada no Gmail

            string assunto = "Código de Recuperação Tony TI | Sistema de Chamados";
            string corpo = $@"
                <h2>Olá! Segue o Código de Verificação</h2>
                <p>Seu código para redefinir a senha é:</p>
                <h1>{codigo}</h1>
                <p> Este código irá expirar automaticamente em 5 minutos</p>
                <p>Digite esse código no sistema para continuar o processo de verificação.</p>
                <p> Se você não solicitou a redefinição, por favor ignore essa mensagem.</p>
                <p>Sua conta permanecerá segura.</p>
                <br><p>Atenciosamente - Equipe de Suporte.</p>";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(remetenteEmail, remetenteSenha),
                EnableSsl = true
            };

            MailMessage mensagem = new MailMessage
            {
                From = new MailAddress(remetenteEmail, "Sistema de Chamados"),
                Subject = assunto,
                Body = corpo,
                IsBodyHtml = true
            };

            mensagem.To.Add(emailDestino);
            smtp.Send(mensagem);
        }

        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {
            string codigoInformado = txtCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoInformado))
            {
                MostrarMensagem("Digite o código recebido!");
                return;
            }

            // Verifica se o código informado é igual ao que foi gerado
            if (codigoInformado == codigoGerado)
            {
                MostrarMensagem("Código validado com sucesso!", Color.Green);

                MessageBox.Show("Código correto! Agora você pode redefinir sua senha.",
                                "Verificação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔹 Abre o formulário de redefinição de senha
                RedefinirSenha redefinirForm = new RedefinirSenha(emailUsuario);
                redefinirForm.Show();

                // Fecha a tela atual de recuperação
                this.Close();
            }
            else
            {
                lblMensagem.Parent = panelRec;
                lblMensagem.BringToFront();
                MostrarMensagem("Código incorreto! Tente novamente.");
            }
        }
    }
}

