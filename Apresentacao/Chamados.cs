using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TonyTI_Login.Apresentacao
{
    public partial class Chamados : UserControl
    {
        private string emailUsuario;
        private string perfilUsuario;
        private bool modoDetalhes;

        public Chamados(string emailLogado, string perfil, bool detalhes = false)
        {
            InitializeComponent();
            emailUsuario = emailLogado;
            perfilUsuario = perfil;
            modoDetalhes = detalhes;

            ConfigurarDataGridView();

            dgvChamados.CellFormatting += DgvChamados_CellFormatting;
            dgvChamados.CellClick += dgvChamados_CellClick;
            dgvChamados.CellDoubleClick += dgvChamados_CellDoubleClick;

            CarregarChamadosDoUsuario();
        }

        // ===========================
        // Configuração visual do grid
        // ===========================
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

        // ===========================
        // Coloração da urgência
        // ===========================
        private void DgvChamados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var col = dgvChamados.Columns[e.ColumnIndex];
            if (col == null) return;

            if (col.Name.Equals("Urgencia", StringComparison.OrdinalIgnoreCase) ||
                col.HeaderText.Equals("Urgência", StringComparison.OrdinalIgnoreCase) ||
                col.DataPropertyName.Equals("Urgencia", StringComparison.OrdinalIgnoreCase))
            {
                if (e.Value == null) return;
                string urgencia = e.Value.ToString().Trim();
                char nivelChar = urgencia.FirstOrDefault(char.IsDigit);
                int nivel = nivelChar == '\0' ? 0 : (int)char.GetNumericValue(nivelChar);

                if (nivel == 1 || nivel == 2)
                    e.CellStyle.BackColor = Color.FromArgb(210, 255, 210);
                else if (nivel == 3 || nivel == 4)
                    e.CellStyle.BackColor = Color.FromArgb(255, 230, 180);
                else if (nivel == 5)
                    e.CellStyle.BackColor = Color.FromArgb(255, 190, 190);

                e.CellStyle.ForeColor = Color.Black;
            }
        }

        // ===========================
        // Carregar chamados do BD
        // ===========================
        private void CarregarChamadosDoUsuario()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    bool tecnico = perfilUsuario.Equals("Técnico", StringComparison.OrdinalIgnoreCase);
                    string query = tecnico
                        ? @"SELECT Id, Nome, Email, Telefone, Urgencia, Descricao, DataAbertura, Status, RespostaTecnico
                            FROM Chamados
                            ORDER BY DataAbertura DESC"
                        : @"SELECT Id, Nome, Email, Telefone, Urgencia, Descricao, DataAbertura, Status, RespostaTecnico
                            FROM Chamados
                            WHERE Email = @Email
                            ORDER BY DataAbertura DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!tecnico)
                            cmd.Parameters.AddWithValue("@Email", emailUsuario ?? string.Empty);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Diagnóstico (opcional)
                        // MessageBox.Show("Colunas encontradas: " + string.Join(", ", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));

                        dgvChamados.AutoGenerateColumns = true;
                        dgvChamados.DataSource = dt;

                        if (dgvChamados.Columns.Contains("Id"))
                            dgvChamados.Columns["Id"].HeaderText = "Código";
                        if (dgvChamados.Columns.Contains("Urgencia"))
                            dgvChamados.Columns["Urgencia"].HeaderText = "Urgência";
                        if (dgvChamados.Columns.Contains("Descricao"))
                            dgvChamados.Columns["Descricao"].HeaderText = "Descrição";
                        if (dgvChamados.Columns.Contains("DataAbertura"))
                            dgvChamados.Columns["DataAbertura"].HeaderText = "Abertura";
                        if (dgvChamados.Columns.Contains("Status"))
                            dgvChamados.Columns["Status"].HeaderText = "Status";
                        if (dgvChamados.Columns.Contains("RespostaTecnico"))
                            dgvChamados.Columns["RespostaTecnico"].HeaderText = "Resposta do Técnico";
                    }
                }

                dgvChamados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===========================
        // Clique único: abre DetalhesChamado (somente cliente)
        // ===========================
        private void dgvChamados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!perfilUsuario.Equals("Cliente", StringComparison.OrdinalIgnoreCase)) return;

            try
            {
                var row = dgvChamados.Rows[e.RowIndex];

                string id = BuscarValor(row, "Id", "id", "id_chamado", "codigo", "cod");
                string nome = BuscarValor(row, "Nome", "nome", "Cliente", "usuario");
                string email = BuscarValor(row, "Email", "email", "e_mail");
                string telefone = BuscarValor(row, "Telefone", "telefone", "tel");
                string urgencia = BuscarValor(row, "Urgencia", "urgência", "nivel");
                string descricao = BuscarValor(row, "Descricao", "descricao", "detalhes", "mensagem");
                string dataAbertura = BuscarValor(row, "DataAbertura", "Abertura", "data");
                string status = BuscarValor(row, "Status", "status", "situacao");
                string resposta = BuscarValor(row, "RespostaTecnico", "resposta_tecnico", "resposta");

                DetalhesChamado detalhesForm = new DetalhesChamado(
                    id, nome, email, telefone, urgencia, descricao, dataAbertura, status, resposta, perfilUsuario);

                detalhesForm.ShowDialog();
                CarregarChamadosDoUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir detalhes do chamado: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===========================
        // Duplo clique: técnico encerra chamado
        // ===========================
        private void dgvChamados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!perfilUsuario.Equals("Técnico", StringComparison.OrdinalIgnoreCase)) return;

            try
            {
                var row = dgvChamados.Rows[e.RowIndex];
                string id = BuscarValor(row, "Id", "id", "id_chamado", "codigo", "cod");
                string status = BuscarValor(row, "Status", "status", "situacao");

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Não foi possível identificar o ID do chamado.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (status.Equals("Encerrado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Este chamado já está encerrado.",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult confirm = MessageBox.Show("Deseja encerrar este chamado?",
                    "Encerrar Chamado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                    EncerrarChamado(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encerrar chamado: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===========================
        // Atualiza status (Encerrar)
        // ===========================
        private void EncerrarChamado(string idChamado)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-96C27F7;Initial Catalog=ProjetoLogin;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Chamados SET Status = 'Encerrado' WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idChamado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Chamado encerrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarChamadosDoUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encerrar chamado: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // MÉTODOS AUXILIARES DE BUSCA DE COLUNAS/VALORES
        // =====================================================

        // Busca a coluna do grid que tenha algum dos nomes candidatos
        private DataGridViewColumn EncontrarColuna(params string[] candidatos)
        {
            foreach (var c in dgvChamados.Columns.Cast<DataGridViewColumn>())
            {
                string combined = (c.Name ?? "") + "|" + (c.DataPropertyName ?? "") + "|" + (c.HeaderText ?? "");
                foreach (var cand in candidatos)
                {
                    if (combined.IndexOf(cand, StringComparison.OrdinalIgnoreCase) >= 0)
                        return c;
                }
            }
            return null;
        }

        // Busca o valor da célula com base nos nomes candidatos
        private string BuscarValor(DataGridViewRow row, params string[] candidatos)
        {
            var col = EncontrarColuna(candidatos);
            if (col == null) return string.Empty;
            return row.Cells[col.Name].Value?.ToString() ?? string.Empty;
        }

        // Retorna um dicionário com todos os dados do chamado selecionado
        public System.Collections.Generic.Dictionary<string, string> ObterDadosChamadoSelecionado()
        {
            dgvChamados.EndEdit();

            if (dgvChamados.CurrentRow == null)
                return null;

            var row = dgvChamados.CurrentRow;
            var dict = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (DataGridViewCell cell in row.Cells)
            {
                string colName = dgvChamados.Columns[cell.ColumnIndex].Name;
                string valor = cell.Value?.ToString() ?? string.Empty;
                dict[colName.ToLower()] = valor;
            }

            return dict;
        }
    }
}
