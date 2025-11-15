using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TonyTI_Login.Apresentacao
{
    public partial class DetalhesChamado : Form
    {
        private readonly string _connectionString =
            @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";

        private readonly string _perfilUsuario;
        private readonly string _idChamado;

        public DetalhesChamado(
            string id,
            string nome,
            string email,
            string telefone,
            string urgencia,
            string descricao,
            string dataAbertura,
            string status,
            string resposta,
            string perfilUsuario)
        {
            InitializeComponent();

            _perfilUsuario = perfilUsuario;
            _idChamado = id;

            // 🔹 Preenche os campos com rótulos formatados
            lblCodigo.Text = $"Código: {id}";
            lblNome.Text = $"Nome: {nome}";
            lblEmail.Text = $"E-mail: {email}";
            lblTelefone.Text = $"Telefone: {telefone}";
            lblUrgencia.Text = $"Urgência: {urgencia}";
            lblDataAbertura.Text = $"Abertura: {dataAbertura}";
            lblStatus.Text = $"Status: {status}";

            txtDescricao.Text = string.IsNullOrEmpty(descricao)
                ? "(sem descrição fornecida)"
                : descricao;

            txtRespostaTecnico.Text = string.IsNullOrEmpty(resposta)
                ? "⏳ Ainda não há resposta do técnico."
                : resposta;

            // 🔹 Oculta botões para técnicos
            bool isTecnico = perfilUsuario.Equals("Técnico", StringComparison.OrdinalIgnoreCase);
            btnResolvido.Visible = !isTecnico;
            btnNaoResolvido.Visible = !isTecnico;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // ✅ Clique em "Marcar como Resolvido"
        private void btnResolvido_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Deseja marcar este chamado como resolvido e encerrá-lo?",
                "Confirmar ação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                AtualizarStatus("Encerrado");
                MessageBox.Show("Chamado marcado como resolvido e encerrado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // ✅ Clique em "Não Resolvido"
        private void btnNaoResolvido_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Deseja marcar este chamado como NÃO resolvido e reenviá-lo ao técnico?",
                "Confirmar ação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                AtualizarStatus("Reaberto");
                MessageBox.Show("Chamado reaberto e reenviado ao técnico.",
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // ✅ Atualiza o status do chamado no banco
        private void AtualizarStatus(string novoStatus)
        {
            if (string.IsNullOrEmpty(_idChamado))
            {
                MessageBox.Show("ID do chamado inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Chamados SET Status = @Status WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", novoStatus);
                        cmd.Parameters.AddWithValue("@Id", _idChamado);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o status: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
