namespace TonyTI_Login.Apresentacao
{
    partial class PagInicial
    {
        // Contém componentes gerenciados pelo designer; liberados no Dispose.
        private System.ComponentModel.IContainer components = null;

        // Libera recursos usados pelo formulário; executado ao descartar o formulário.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Libera componentes criados pelo designer.
            }
            base.Dispose(disposing); // Executa Dispose da classe base.
        }

        #region Windows Form Designer generated code

        // Inicializa os controles visuais do formulário; gerado pelo Designer do Windows Forms.
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel(); // Barra lateral de navegação.
            this.bntDetalhes = new System.Windows.Forms.Button(); // Botão para detalhes de chamados.
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Logo no topo da barra lateral.
            this.btnHelp = new System.Windows.Forms.Button(); // Botão de ajuda/FAQ.
            this.btnHome = new System.Windows.Forms.Button(); // Botão que navega para a página principal.
            this.btnExit = new System.Windows.Forms.Button(); // Botão para encerrar sessão ou sair.
            this.btnChamados = new System.Windows.Forms.Button(); // Botão para listar chamados do usuário.
            this.btnAbrirChamado = new System.Windows.Forms.Button(); // Botão para criar novo chamado.
            this.btnContatoCliente = new System.Windows.Forms.Button(); // Botão para contatar cliente.
            this.panelContainer = new System.Windows.Forms.Panel(); // Área principal de conteúdo dinâmico.
            this.pnlAcessoRapido = new System.Windows.Forms.Panel(); // Painel com atalhos e ações rápidas.
            this.pictureBox2 = new System.Windows.Forms.PictureBox(); // Imagem ilustrativa no container.
            this.button6 = new System.Windows.Forms.Button(); // Botão auxiliar de ajuda no painel rápido.
            this.btnSairSistema = new System.Windows.Forms.Button(); // Atalho para sair do sistema.
            this.btnNovoChamado = new System.Windows.Forms.Button(); // Atalho para abrir novo chamado.
            this.btnContatarCliente = new System.Windows.Forms.Button(); // Atalho para contatar cliente.
            this.btnMeusChamados = new System.Windows.Forms.Button(); // Atalho para visualizar meus chamados.
            this.btnPrincipal = new System.Windows.Forms.Button(); // Atalho para ir à página principal.
            this.label1 = new System.Windows.Forms.Label(); // Título "Acesso Rápido" do painel.
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel(); // Painel de layout flexível (não usado visivelmente).
            this.panel1.SuspendLayout(); // Suspende layout da barra lateral para adicionar controles.
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout(); // Suspende layout do container principal.
            this.pnlAcessoRapido.SuspendLayout(); // Suspende layout do painel de acesso rápido.
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout(); // Suspende layout do formulário.

            // panel1
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight; // Define cor da barra lateral.
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; // Borda visual da área.
            this.panel1.Controls.Add(this.bntDetalhes); // Adiciona botão de detalhes.
            this.panel1.Controls.Add(this.pictureBox1); // Adiciona logo.
            this.panel1.Controls.Add(this.btnHelp); // Adiciona botão de ajuda.
            this.panel1.Controls.Add(this.btnHome); // Adiciona botão principal.
            this.panel1.Controls.Add(this.btnExit); // Adiciona botão sair.
            this.panel1.Controls.Add(this.btnChamados); // Adiciona botão meus chamados.
            this.panel1.Controls.Add(this.btnAbrirChamado); // Adiciona botão abrir chamado.
            this.panel1.Controls.Add(this.btnContatoCliente); // Adiciona botão contatar cliente.
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left; // Anexa painel à esquerda da janela.
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 673); // Largura fixa da barra lateral.
            this.panel1.TabIndex = 14;

            // bntDetalhes
            this.bntDetalhes.AutoSize = true; // Ajusta tamanho conforme conteúdo.
            this.bntDetalhes.BackColor = System.Drawing.Color.Transparent; // Mantém fundo transparente.
            this.bntDetalhes.Cursor = System.Windows.Forms.Cursors.Hand; // Indica elemento clicável.
            this.bntDetalhes.FlatAppearance.BorderSize = 5; // Aparência do botão.
            this.bntDetalhes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.bntDetalhes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.bntDetalhes.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.bntDetalhes.Image = global::TonyTI_Login.Properties.Resources.imgChamados; // Ícone do botão.
            this.bntDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // Alinha ícone à esquerda.
            this.bntDetalhes.Location = new System.Drawing.Point(3, 223);
            this.bntDetalhes.Name = "bntDetalhes";
            this.bntDetalhes.Size = new System.Drawing.Size(269, 54); // Tamanho consistente com outros botões.
            this.bntDetalhes.TabIndex = 15;
            this.bntDetalhes.Text = "Detalhes Chamados";
            this.bntDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntDetalhes.UseVisualStyleBackColor = false;

            // pictureBox1
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Permite redimensionamento relativo.
            this.pictureBox1.Image = global::TonyTI_Login.Properties.Resources.LogoSite; // Logo do sistema.
            this.pictureBox1.Location = new System.Drawing.Point(-2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 68); // Área da logo.
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Ajusta logo ao espaço.
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;

            // btnHelp
            this.btnHelp.AutoSize = true;
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 5;
            this.btnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnHelp.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnHelp.Image = global::TonyTI_Login.Properties.Resources.imgAjuda;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(-2, 597);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(269, 54);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Ajuda";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click); // Ativa formulário de ajuda.

            // btnHome
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 5;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::TonyTI_Login.Properties.Resources.icons8_quatro_quadrados_48;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 77);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(264, 54);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Principal";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click); // Navega para content principal.

            // btnExit
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnExit.Image = global::TonyTI_Login.Properties.Resources.imgSair;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-2, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(269, 54);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click); // Encerra sessão ou fecha aplicação.

            // btnChamados
            this.btnChamados.AutoSize = true;
            this.btnChamados.BackColor = System.Drawing.Color.Transparent;
            this.btnChamados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamados.FlatAppearance.BorderSize = 5;
            this.btnChamados.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnChamados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnChamados.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnChamados.Image = global::TonyTI_Login.Properties.Resources.imgChamados;
            this.btnChamados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamados.Location = new System.Drawing.Point(-2, 146);
            this.btnChamados.Name = "btnChamados";
            this.btnChamados.Size = new System.Drawing.Size(269, 54);
            this.btnChamados.TabIndex = 9;
            this.btnChamados.Text = "Meus chamados";
            this.btnChamados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChamados.UseVisualStyleBackColor = false;
            this.btnChamados.Click += new System.EventHandler(this.btnChamados_Click); // Abre lista de chamados do usuário.

            // btnAbrirChamado
            this.btnAbrirChamado.AutoSize = true;
            this.btnAbrirChamado.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirChamado.FlatAppearance.BorderSize = 5;
            this.btnAbrirChamado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnAbrirChamado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnAbrirChamado.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnAbrirChamado.Image = global::TonyTI_Login.Properties.Resources.imgAbrirChamado;
            this.btnAbrirChamado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirChamado.Location = new System.Drawing.Point(-2, 296);
            this.btnAbrirChamado.Name = "btnAbrirChamado";
            this.btnAbrirChamado.Size = new System.Drawing.Size(269, 54);
            this.btnAbrirChamado.TabIndex = 11;
            this.btnAbrirChamado.Text = "Abrir Chamado";
            this.btnAbrirChamado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirChamado.UseVisualStyleBackColor = false;
            this.btnAbrirChamado.Click += new System.EventHandler(this.btnAbrirChamado_Click); // Abre formulário para criar chamado.

            // btnContatoCliente
            this.btnContatoCliente.AutoSize = true;
            this.btnContatoCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnContatoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatoCliente.FlatAppearance.BorderSize = 5;
            this.btnContatoCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.btnContatoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnContatoCliente.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.btnContatoCliente.Image = global::TonyTI_Login.Properties.Resources.imgContatarCliente;
            this.btnContatoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContatoCliente.Location = new System.Drawing.Point(-2, 221);
            this.btnContatoCliente.Name = "btnContatoCliente";
            this.btnContatoCliente.Size = new System.Drawing.Size(269, 54);
            this.btnContatoCliente.TabIndex = 10;
            this.btnContatoCliente.Text = "Contatar Cliente";
            this.btnContatoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContatoCliente.UseVisualStyleBackColor = false;
            this.btnContatoCliente.Click += new System.EventHandler(this.btnContatoCliente_Click); // Abre módulo de contato com cliente.

            // panelContainer
            this.panelContainer.Controls.Add(this.label1); // Adiciona título ao container.
            this.panelContainer.Controls.Add(this.pnlAcessoRapido); // Adiciona painel de atalhos.
            this.panelContainer.Controls.Add(this.pictureBox2); // Adiciona imagem ilustrativa.
            this.panelContainer.Location = new System.Drawing.Point(280, 12); // Posição do container principal.
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(967, 650); // Área onde conteúdos dinâmicos são carregados.
            this.panelContainer.TabIndex = 15;

            // pnlAcessoRapido
            this.pnlAcessoRapido.Controls.Add(this.button6); // Botão de ajuda rápida.
            this.pnlAcessoRapido.Controls.Add(this.btnPrincipal); // Atalho para principal.
            this.pnlAcessoRapido.Controls.Add(this.btnSairSistema); // Atalho sair.
            this.pnlAcessoRapido.Controls.Add(this.btnMeusChamados); // Atalho meus chamados.
            this.pnlAcessoRapido.Controls.Add(this.btnNovoChamado); // Atalho novo chamado.
            this.pnlAcessoRapido.Controls.Add(this.btnContatarCliente); // Atalho contatar cliente.
            this.pnlAcessoRapido.Location = new System.Drawing.Point(10, 509);
            this.pnlAcessoRapido.Name = "pnlAcessoRapido";
            this.pnlAcessoRapido.Size = new System.Drawing.Size(947, 138); // Área para botões grandes de atalho.
            this.pnlAcessoRapido.TabIndex = 6;

            // pictureBox2
            this.pictureBox2.Image = global::TonyTI_Login.Properties.Resources.inicioSistema; // Imagem de introdução ao sistema.
            this.pictureBox2.Location = new System.Drawing.Point(3, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(954, 489); // Ocupa a maior parte do container.
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Ajusta imagem ao espaço.
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;

            // button6
            this.button6.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgAjuda; // Ícone de ajuda.
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(821, 3);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(123, 114); // Botão grande para atalho.
            this.button6.TabIndex = 4;
            this.button6.Text = "Ajuda";
            this.button6.UseVisualStyleBackColor = true;

            // btnSairSistema
            this.btnSairSistema.BackColor = System.Drawing.Color.Transparent;
            this.btnSairSistema.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgSair;
            this.btnSairSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSairSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairSistema.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSairSistema.Location = new System.Drawing.Point(665, 3);
            this.btnSairSistema.Name = "btnSairSistema";
            this.btnSairSistema.Size = new System.Drawing.Size(123, 114);
            this.btnSairSistema.TabIndex = 4;
            this.btnSairSistema.Text = "Sair";
            this.btnSairSistema.UseVisualStyleBackColor = false;

            // btnNovoChamado
            this.btnNovoChamado.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoChamado.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgAbrirChamado;
            this.btnNovoChamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoChamado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNovoChamado.Location = new System.Drawing.Point(498, 3);
            this.btnNovoChamado.Name = "btnNovoChamado";
            this.btnNovoChamado.Size = new System.Drawing.Size(123, 114);
            this.btnNovoChamado.TabIndex = 4;
            this.btnNovoChamado.Text = "Abrir Chamado";
            this.btnNovoChamado.UseVisualStyleBackColor = false;

            // btnContatarCliente (atalho)
            this.btnContatarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnContatarCliente.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgContatarCliente;
            this.btnContatarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContatarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContatarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnContatarCliente.Location = new System.Drawing.Point(335, 3);
            this.btnContatarCliente.Name = "btnContatarCliente";
            this.btnContatarCliente.Size = new System.Drawing.Size(123, 114);
            this.btnContatarCliente.TabIndex = 4;
            this.btnContatarCliente.Text = "Contatar Cliente";
            this.btnContatarCliente.UseVisualStyleBackColor = false;

            // btnMeusChamados
            this.btnMeusChamados.BackColor = System.Drawing.Color.Transparent;
            this.btnMeusChamados.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgChamados;
            this.btnMeusChamados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeusChamados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeusChamados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnMeusChamados.Location = new System.Drawing.Point(173, 3);
            this.btnMeusChamados.Name = "btnMeusChamados";
            this.btnMeusChamados.Size = new System.Drawing.Size(123, 114);
            this.btnMeusChamados.TabIndex = 4;
            this.btnMeusChamados.Text = "Meus Chamados";
            this.btnMeusChamados.UseVisualStyleBackColor = false;

            // btnPrincipal
            this.btnPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnPrincipal.BackgroundImage = global::TonyTI_Login.Properties.Resources.icons8_quatro_quadrados_48;
            this.btnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.btnPrincipal.Location = new System.Drawing.Point(13, 3);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(123, 114);
            this.btnPrincipal.TabIndex = 4;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = false;

            // label1
            this.label1.AutoSize = true; // Ajusta label ao conteúdo.
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(223, 397); // Posição do título de acesso rápido.
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Acesso Rápido:"; // Texto informativo do painel.

            // flowLayoutPanel1
            this.flowLayoutPanel1.Location = new System.Drawing.Point(843, 217); // Pequeno painel de layout que parece não ser usado.
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8); // Dimensões ínfimas; atenção se pretendido.
            this.flowLayoutPanel1.TabIndex = 16;

            // PagInicial (form)
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit; // Herda modo de escala.
            this.AutoSize = true; // Permite redimensionamento automático.
            this.BackColor = System.Drawing.SystemColors.ButtonFace; // Cor de fundo padrão.
            this.ClientSize = new System.Drawing.Size(1262, 673); // Tamanho inicial da janela.
            this.Controls.Add(this.flowLayoutPanel1); // Adiciona painel de layout ao formulário.
            this.Controls.Add(this.panel1); // Adiciona barra lateral.
            this.Controls.Add(this.panelContainer); // Adiciona container principal.
            this.Name = "PagInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centraliza janela ao abrir.
            this.Text = "Tony TI | Home"; // Título da janela.

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout(); // Restaura layout da barra lateral.
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout(); // Restaura layout do container principal.
            this.pnlAcessoRapido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false); // Restaura layout do formulário.

        }

        #endregion

        // Campos privados que representam controles visuais no formulário.
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnChamados;
        private System.Windows.Forms.Button btnContatoCliente;
        private System.Windows.Forms.Button btnAbrirChamado;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntDetalhes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSairSistema;
        private System.Windows.Forms.Button btnNovoChamado;
        private System.Windows.Forms.Button btnContatarCliente;
        private System.Windows.Forms.Button btnMeusChamados;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel pnlAcessoRapido;
    }
}
