using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TonyTI_Login.Modelo;
using TonyTI_Login.Properties;

namespace TonyTI_Login.Apresentacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtEmailNewUser.Text, txtPassNewUser.Text, txtConfirmNewPass.Text);

            if (controle.tem)
            {
                // Cadastro OK
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha o formulário de cadastro e volta para login
                this.Close();
            }
            else
            {
                // Se for erro de senha ou e-mail inválido → mostra com ícone de erro
                if (mensagem.Contains("A senha precisa") || mensagem.Contains("E-mail inválido"))
                {
                    MessageBox.Show(mensagem, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Outros erros (duplicidade, BD, etc.)
                    MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassNewUser.UseSystemPasswordChar = false;
            viewPass.Image = Resources.showPass;

        }

        private void viewPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassNewUser.UseSystemPasswordChar = true;
            viewPass.Image = Resources.hiddenPass;

        }

        private void verSenha_Click(object sender, EventArgs e)
        {

        }

        private void verSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmNewPass.UseSystemPasswordChar = false;
            viewPass.Image = Resources.showPass;
        }

        private void verSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmNewPass.UseSystemPasswordChar = true;
            viewPass.Image = Resources.hiddenPass;
        }
    }
}
