using System;
using System.Windows.Forms;
using TonyTI_Login.Apresentacao;

namespace TonyTI_Login
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cria o formulário de login
            Login loginForm = new Login();

            // Mostra o login de forma modal
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Recupera o e-mail e o perfil do usuário logado
                string emailLogado = loginForm.EmailUsuario;
                string perfilLogado = loginForm.PerfilUsuario;

                //  Passa ambos para a página inicial
                Application.Run(new PagInicial(emailLogado, perfilLogado));
            }
            else
            {
                // Fecha o app se o login for cancelado
                Application.Exit();
            }
        }
    }
}
