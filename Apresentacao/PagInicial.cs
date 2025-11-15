using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TonyTI_Login.Apresentacao
{
    public partial class PagInicial : Form
    {
        private readonly string emailLogado;    // ✅ E-mail do usuário logado
        private readonly string perfilUsuario;  // ✅ Perfil do usuário logado (Técnico ou Cliente)

        // =====================================================
        // === CONSTRUTOR PRINCIPAL ===
        // =====================================================
        public PagInicial(string email, string perfil)
        {
            InitializeComponent();
            emailLogado = email;
            perfilUsuario = string.IsNullOrEmpty(perfil) ? "Cliente" : perfil;
            AtivarBotao(btnHome);

            // define visibilidade inicial dos botões que só certos perfis devem ver
            btnContatoCliente.Visible = perfilUsuario.Equals("Técnico", StringComparison.OrdinalIgnoreCase);
            bntDetalhes.Visible = perfilUsuario.Equals("Cliente", StringComparison.OrdinalIgnoreCase);

            // vincula quick-buttons aos handlers já existentes
            try
            {
                btnPrincipal.Click += btnHome_Click;
                btnMeusChamados.Click += btnChamados_Click;
                btnContatarCliente.Click += btnContatoCliente_Click;
                btnNovoChamado.Click += btnAbrirChamado_Click;
                btnSairSistema.Click += btnExit_Click;
            }
            catch
            {
                // se algum botão não existir no designer, ignora (não quebra)
            }

            Text = "Tony TI | Home";

            // abrir Home e mostrar quick buttons
            // nota: não usar CarregarTela aqui (para evitar recursão), usamos LoadUserControl
            LoadUserControl(new InicioSistema(), true);
        }

        // ✅ Construtor sem parâmetros (usado apenas no modo Design do VS)
        public PagInicial()
        {
            InitializeComponent();

            // vinculações tentativas (quando usado no Designer podem ser nulos)
            try
            {
                btnPrincipal.Click += btnHome_Click;
                btnMeusChamados.Click += btnChamados_Click;
                btnContatarCliente.Click += btnContatoCliente_Click;
                btnNovoChamado.Click += btnAbrirChamado_Click;
                btnSairSistema.Click += btnExit_Click;
            }
            catch { }
        }

        // =====================================================
        // === MÉTODOS AUXILIARES VISUAIS ===
        // =====================================================
        private IEnumerable<Button> EnumerarBotoes(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (c is Button b) yield return b;
                if (c.HasChildren)
                {
                    foreach (var b2 in EnumerarBotoes(c))
                        yield return b2;
                }
            }
        }

        private void ResetarCoresBotoes()
        {
            foreach (var btn in EnumerarBotoes(this))
            {
                if (btn.Name == "btnExit") continue; // mantém botão de saída intacto
                btn.UseVisualStyleBackColor = true;
                btn.FlatStyle = FlatStyle.Standard;
                btn.BackColor = SystemColors.Control;
            }
        }

        private void AtivarBotao(Button btn)
        {
            if (btn == null) return;

            ResetarCoresBotoes();
            btn.UseVisualStyleBackColor = false;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.PowderBlue;
        }

        // =====================================================
        // === QUICK BUTTONS SHOW/HIDE ===
        // =====================================================
        // lista dos controles rápidos que existem dentro do panelContainer (conforme seu Designer)
        private void ToggleQuickButtons(bool visible)
        {
            // botão/controles do acesso rápido que você declarou no Designer
            var quick = new Control[]
            {
                btnPrincipal, btnMeusChamados, btnContatarCliente, btnNovoChamado, btnSairSistema,
                label1, pictureBox2, button6
            };

            foreach (var c in quick)
            {
                if (c == null) continue; // p/ segurança se não existir no Designer
                c.Visible = visible;
            }
        }

        // =====================================================
        // === LOAD USERCONTROL (não remove quick buttons) ===
        // =====================================================
        // carrega apenas UserControls em panelContainer; preserva outros controles (quick buttons, picturebox, label)
        private void LoadUserControl(UserControl tela, bool showQuickButtons)
        {
            if (panelContainer == null) return;

            try
            {
                // remove apenas os UserControls atuais (preserva pictureboxes, labels e botões rápidos)
                var existentes = panelContainer.Controls.OfType<UserControl>().ToList();
                foreach (var ctrl in existentes)
                    panelContainer.Controls.Remove(ctrl);

                // adiciona o novo UserControl
                if (tela != null)
                {
                    tela.Dock = DockStyle.Fill;
                    panelContainer.Controls.Add(tela);
                }

                // mostra/oculta quick buttons
                ToggleQuickButtons(showQuickButtons);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tela: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // compatibilidade: método antigo CarregarTela(UserControl) chama LoadUserControl ocultando quick buttons
        private void CarregarTela(UserControl tela)
        {
            // por padrão, quando chamam CarregarTela legacy, ocultamos os quick buttons
            LoadUserControl(tela, false);
        }

        // =====================================================
        // === EVENTOS DE BOTÕES ===
        // =====================================================

        private void btnHome_Click(object sender, EventArgs e)
        {
            Text = "Tony TI | Home";
            AtivarBotao(sender as Button);
            // ativa visual do quick button também se existir
            try { AtivarBotao(btnPrincipal); } catch { }
            LoadUserControl(new InicioSistema(), true); // Home mostra quick buttons
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            Text = "Tony TI | Meus Chamados";
            AtivarBotao(sender as Button);
            try { AtivarBotao(btnMeusChamados); } catch { }
            if (!string.IsNullOrWhiteSpace(emailLogado) && !string.IsNullOrWhiteSpace(perfilUsuario))
            {
                // oculta quick buttons ao abrir Chamados
                LoadUserControl(new Chamados(emailLogado, perfilUsuario), false);
            }
            else
            {
                MessageBox.Show("Erro: dados do usuário incompletos (e-mail ou perfil ausente).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnContatoCliente_Click(object sender, EventArgs e)
        {
            if (!perfilUsuario.Equals("Técnico", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Apenas técnicos podem acessar esta área.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Text = "Tony TI | Contatar Cliente";
            AtivarBotao(sender as Button);
            try { AtivarBotao(btnContatarCliente); } catch { }
            // ContatoCliente => ocultar quick buttons
            LoadUserControl(new ContatoCliente(emailLogado), false);
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            Text = "Tony TI | Abrir Chamado";
            AtivarBotao(sender as Button);
            try { AtivarBotao(btnNovoChamado); } catch { }

            if (!string.IsNullOrEmpty(emailLogado))
            {
                LoadUserControl(new AbrirChamado(emailLogado), false);
            }
            else
            {
                MessageBox.Show("Erro: e-mail do usuário não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // BOTÃO: Detalhes (somente clientes) - abre Chamados no modo detalhes (oculta quick buttons)
        private void bntDetalhes_Click(object sender, EventArgs e)
        {
            if (!perfilUsuario.Equals("Cliente", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Apenas clientes podem acessar os detalhes dos chamados.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Text = "Tony TI | Detalhes do Chamado";
            AtivarBotao(sender as Button);
            LoadUserControl(new Chamados(emailLogado, perfilUsuario, true), false);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Text = "Tony TI | Ajuda";
            AtivarBotao(sender as Button);
            LoadUserControl(new Ajuda(), false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show(
                "Deseja mesmo sair do sistema?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (Exit == DialogResult.Yes)
                Application.Exit();
        }

        // =====================================================
        // === EVENTOS DO FORMULÁRIO ===
        // =====================================================

        private void PagInicial_Load(object sender, EventArgs e)
        {
            // garantimos que iniciamos na Home com quick buttons visíveis
            Text = "Tony TI | Home";
            LoadUserControl(new InicioSistema(), true);

            // Revalida visibilidade (por segurança)
            try
            {
                btnContatoCliente.Visible = perfilUsuario.Equals("Técnico", StringComparison.OrdinalIgnoreCase);
                bntDetalhes.Visible = perfilUsuario.Equals("Cliente", StringComparison.OrdinalIgnoreCase);
            }
            catch { }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            // evento visual (pode ficar vazio)
        }
    }
}
