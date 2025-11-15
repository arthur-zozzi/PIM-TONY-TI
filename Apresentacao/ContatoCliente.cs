using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TonyTI_Login.Apresentacao
{
    public partial class ContatoCliente : UserControl
    {
        private string emailUsuario; // técnico logado
        private string idChamadoSelecionado = ""; // armazena o ID do chamado atual

        public ContatoCliente(string emailLogado)
        {
            InitializeComponent();
            emailUsuario = emailLogado;

            // Inicializa layout
            pnlDetalhes.Visible = false;
            pnlResposta.Visible = false;

            ConfigurarDataGridView();

            // Liga eventos
            dgvChamados.CellClick += dgvChamados_CellClick;
            btnAbrirAnexo.Click += btnAbrirAnexo_Click;
            btnResponder.Click += btnResponder_Click;
            btnEnviarResposta.Click += btnEnviarResposta_Click;

            CarregarChamadosAbertos();
        }

        // ============================================
        // CONFIGURA VISUAL DA DATAGRIDVIEW
        // ============================================
        private void ConfigurarDataGridView()
        {
            dgvChamados.ReadOnly = true;
            dgvChamados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamados.MultiSelect = false;
            dgvChamados.AllowUserToAddRows = false;
            dgvChamados.AllowUserToDeleteRows = false;
            dgvChamados.AllowUserToResizeRows = false;
            dgvChamados.RowHeadersVisible = false;
            dgvChamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvChamados.BackgroundColor = Color.White;
            dgvChamados.GridColor = Color.DarkGray;
            dgvChamados.DefaultCellStyle.BackColor = Color.White;
            dgvChamados.DefaultCellStyle.ForeColor = Color.Black;
            dgvChamados.DefaultCellStyle.SelectionBackColor = Color.Black;
            dgvChamados.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvChamados.BorderStyle = BorderStyle.FixedSingle;
            dgvChamados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvChamados.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvChamados.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvChamados.EnableHeadersVisualStyles = false;
            dgvChamados.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
        }

        // ============================================
        // CARREGAR CHAMADOS (todos os abertos ou não resolvidos)
        // ============================================
        private void CarregarChamadosAbertos()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT Id, Nome, Email, Telefone, Urgencia, Descricao, DataAbertura, Status
                                     FROM Chamados
                                     WHERE Status NOT IN ('Encerrado', 'Resolvido')
                                     ORDER BY DataAbertura DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvChamados.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        // SELECIONAR CHAMADO (MOSTRA DETALHES)
        // ============================================
        private void dgvChamados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvChamados.Rows[e.RowIndex];
                idChamadoSelecionado = row.Cells["Id"].Value.ToString();

                lblIdChamado.Text = idChamadoSelecionado;
                txtNomeCliente.Text = row.Cells["Nome"].Value.ToString();
                txtEmailCliente.Text = row.Cells["Email"].Value.ToString();
                txtDescricao.Text = row.Cells["Descricao"].Value.ToString();

                pnlDetalhes.Visible = true;
                pnlResposta.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir detalhes do chamado: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        // ABRIR ANEXO (exemplo de diretório fixo)
        // ============================================
        private void btnAbrirAnexo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idChamadoSelecionado))
                {
                    MessageBox.Show("Selecione um chamado primeiro.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string pastaAnexos = @"C:\Projetos\AnexosChamados\";
                string[] arquivos = System.IO.Directory.GetFiles(pastaAnexos, $"chamado_{idChamadoSelecionado}.*");

                if (arquivos.Length > 0)
                {
                    System.Diagnostics.Process.Start(arquivos[0]);
                }
                else
                {
                    MessageBox.Show("Nenhum anexo encontrado para este chamado.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir anexo: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================
        // ABRIR PAINEL DE RESPOSTA
        // ============================================
        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idChamadoSelecionado))
            {
                MessageBox.Show("Selecione um chamado antes de responder.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pnlDetalhes.Visible = true;
            pnlResposta.Visible = true;
            txtResposta.Clear();
        }

        // ============================================
        // ENVIAR RESPOSTA AO CLIENTE
        // ============================================
        private void btnEnviarResposta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResposta.Text.Trim()))
            {
                MessageBox.Show("Digite uma resposta antes de enviar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Chamados 
                                     SET Status = 'Respondido',
                                         RespostaTecnico = @Resposta
                                     WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Resposta", txtResposta.Text.Trim());
                        cmd.Parameters.AddWithValue("@Id", idChamadoSelecionado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Resposta enviada com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlResposta.Visible = false;
                pnlDetalhes.Visible = false;
                CarregarChamadosAbertos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar resposta: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
