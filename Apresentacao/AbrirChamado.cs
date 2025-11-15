using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TonyTI_Login.Apresentacao
{
    public partial class AbrirChamado : UserControl
    {
        private string emailUsuario; // E-mail do usuário logado
        private List<string> _anexos = new List<string>(); // Guarda os arquivos anexados

        public AbrirChamado(string emailLogado)
        {
            InitializeComponent();
            emailUsuario = emailLogado;

            // ✅ Painel começa oculto
            pnlNewChamado.Visible = false;

            // Define o e-mail do usuário no campo e o torna somente leitura
            txtEmail.Text = emailUsuario;
            txtEmail.ReadOnly = true;

            // ✅ Popula a ComboBox de urgência
            cbUrgencia.Items.Clear();
            cbUrgencia.Items.AddRange(new object[]
            {
                "1 - Baixa",
                "2 - Média",
                "3 - Moderada",
                "4 - Grave",
                "5 - Urgente"
            });
            cbUrgencia.SelectedIndex = -1;
            cbUrgencia.DropDownStyle = ComboBoxStyle.DropDownList;

            // ✅ Liga os eventos
            btnEnviar.Click += btnEnviar_Click;
            btnNewChamado.Click += btnNewChamado_Click;
            btnAnexar.Click += btnAnexar_Click;
            btnCancelar.Click += btnCancelar_Click;

            // ✅ Permitir apenas números no campo de telefone
            txtTelefone.KeyPress += txtTelefone_KeyPress;
        }

        // ============================================
        // BOTÃO: ENVIAR (ABRIR) CHAMADO
        // ============================================
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Validação antes do envio
                if (!ValidarCamposObrigatorios(out string mensagemErro))
                {
                    MessageBox.Show($"Por favor, corrija os seguintes campos antes de enviar:\n\n{mensagemErro}",
                                    "Campos obrigatórios",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Chamados 
                                    (Nome, Email, Telefone, Urgencia, Descricao, DataAbertura, Status)
                                     VALUES (@Nome, @Email, @Telefone, @Urgencia, @Descricao, GETDATE(), 'Aberto')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Urgencia", cbUrgencia.Text.Trim());
                        cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                // ✅ Mostra mensagem de sucesso
                MessageBox.Show("Chamado aberto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Limpa e oculta o painel
                LimparCampos();
                pnlNewChamado.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir chamado: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        // BOTÃO: ANEXAR ARQUIVOS
        // ============================================
        private void btnAnexar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione o(s) arquivo(s) para anexar";
                ofd.Filter = "Todos os arquivos (*.*)|*.*";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _anexos.AddRange(ofd.FileNames);
                    MessageBox.Show($"{ofd.FileNames.Length} arquivo(s) anexado(s) com sucesso.",
                                    "Anexo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ============================================
        // BOTÃO: NOVO CHAMADO
        // ============================================
        private void btnNewChamado_Click(object sender, EventArgs e)
        {
            pnlNewChamado.Visible = true;
            LimparCampos();
        }

        // ============================================
        // BOTÃO: CANCELAR (OCULTA O PAINEL)
        // ============================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Deseja cancelar a abertura do chamado?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LimparCampos();
                pnlNewChamado.Visible = false;
            }
        }

        // ============================================
        // MÉTODO: VALIDAR CAMPOS OBRIGATÓRIOS
        // ============================================
        private bool ValidarCamposObrigatorios(out string mensagemErro)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNome.Text))
                erros.Add("• Nome não preenchido.");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                erros.Add("• E-mail não preenchido.");
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
                erros.Add("• Telefone não preenchido.");
            if (cbUrgencia.SelectedIndex == -1)
                erros.Add("• Grau de urgência não selecionado.");
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                erros.Add("• Descrição do problema não preenchida.");

            mensagemErro = string.Join("\n", erros);
            return erros.Count == 0;
        }

        // ============================================
        // MÉTODO: BLOQUEAR LETRAS NO CAMPO TELEFONE
        // ============================================
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ✅ Permite apenas números, backspace e teclas de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ============================================
        // MÉTODO: LIMPAR CAMPOS
        // ============================================
        private void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            cbUrgencia.SelectedIndex = -1;
            txtDescricao.Clear();
            _anexos.Clear();
        }

        // ============================================
        // MÉTODO: CARREGAR CHAMADOS DO USUÁRIO
        // ============================================
        private void CarregarChamadosDoUsuario()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT Id, Nome, Email, Telefone, Urgencia, Descricao, DataAbertura, Status 
                                     FROM Chamados
                                     WHERE Email = @Email
                                     ORDER BY DataAbertura DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailUsuario);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
