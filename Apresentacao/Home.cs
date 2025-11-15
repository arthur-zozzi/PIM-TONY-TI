using System;
using System.Windows.Forms;
using TonyTI_Login.Apresentacao;
using TonyTI_Login.Modelo;
using TonyTI_Login.Properties;

namespace TonyTI_Login
{
    public partial class Login : Form
    {
        // Propriedades públicas para passar dados ao Program.cs
        public string EmailUsuario { get; private set; }
        public string PerfilUsuario { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------
        // Eventos gerados pelo Designer (mantidos para compatibilidade)
        // ------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            // Pode ficar vazio — preserva o vínculo com o Designer
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handler vazio para evitar erro do Designer.
            // Se quiser, aqui você pode abrir uma imagem em tamanho maior etc.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handler vazio — usado pelo Designer se você vinculou o evento.
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Handler vazio — usado pelo Designer se você vinculou o evento.
        }

        private void viewPass_Click(object sender, EventArgs e)
        {
            // Handler vazio — deixei mouse down/up para mostrar/ocultar senha.
            // Este evento click não é necessário, mas o Designer pode referenciar.
        }

        // ============================================================
        // === BOTÃO: LOGIN ===========================================
        // ============================================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtPassword.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Bem-vindo(a) ao sistema!",
                        "Acesso liberado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Salva o e-mail logado
                    EmailUsuario = txtLogin.Text.Trim();

                    // Salva o perfil retornado pelo Controle
                    PerfilUsuario = string.IsNullOrEmpty(controle.perfilUsuario)
                        ? "Cliente" // fallback seguro
                        : controle.perfilUsuario;

                    // Fecha o formulário de login informando sucesso
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login não encontrado. Verifique Login e Senha.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        // ============================================================
        // === BOTÃO: CADASTRAR NOVO USUÁRIO ==========================
        // ============================================================
        private void btnFirstAcess_Click(object sender, EventArgs e)
        {
            Cadastro cadForm = new Cadastro();
            cadForm.ShowDialog();
        }

        // ============================================================
        // === BOTÃO: SAIR ============================================
        // ============================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ============================================================
        // === BOTÃO: ESQUECI MINHA SENHA =============================
        // ============================================================
        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            SenhaRecover resetSenha = new SenhaRecover();
            resetSenha.ShowDialog();
        }

        // ============================================================
        // === VISUALIZAR SENHA (mouse down / mouse up) ===============
        // ============================================================
        private void viewPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            viewPass.Image = Resources.showPass;
        }

        private void viewPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            viewPass.Image = Resources.hiddenPass;
        }
    }
}
