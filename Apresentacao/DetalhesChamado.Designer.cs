namespace TonyTI_Login.Apresentacao
{
    partial class DetalhesChamado
    {
        // Armazena componentes gerenciados pelo designer; liberados no Dispose.
        private System.ComponentModel.IContainer components = null;

        // Libera recursos usados pelo formulário; executado ao descartar a instância.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Libera componentes criados pelo designer.
            }
            base.Dispose(disposing); // Executa Dispose da classe base.
        }

        #region Código gerado pelo Windows Form Designer

        // Inicializa controles visuais do formulário; gerado pelo Designer.
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label(); // Título da tela.
            this.lblCodigo = new System.Windows.Forms.Label(); // Exibe código do chamado.
            this.lblNome = new System.Windows.Forms.Label(); // Exibe nome do solicitante.
            this.lblEmail = new System.Windows.Forms.Label(); // Exibe e-mail do solicitante.
            this.lblTelefone = new System.Windows.Forms.Label(); // Exibe telefone do solicitante.
            this.lblUrgencia = new System.Windows.Forms.Label(); // Exibe nível de urgência.
            this.lblDataAbertura = new System.Windows.Forms.Label(); // Exibe data de abertura.
            this.lblStatus = new System.Windows.Forms.Label(); // Exibe status atual do chamado.
            this.txtDescricao = new System.Windows.Forms.TextBox(); // Mostra descrição do problema (somente leitura).
            this.txtRespostaTecnico = new System.Windows.Forms.TextBox(); // Mostra resposta do técnico (somente leitura).
            this.btnResolvido = new System.Windows.Forms.Button(); // Ação para marcar como resolvido.
            this.btnNaoResolvido = new System.Windows.Forms.Button(); // Ação para marcar como não resolvido.
            this.label1 = new System.Windows.Forms.Label(); // Rótulo para descrição do problema.
            this.label2 = new System.Windows.Forms.Label(); // Rótulo para resposta do técnico.
            this.SuspendLayout(); // Suspende layout durante a configuração.

            // lblTitulo
            this.lblTitulo.AutoSize = true; // Ajusta tamanho ao conteúdo.
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); // Estilo de destaque.
            this.lblTitulo.Location = new System.Drawing.Point(23, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalhes do Chamado"; // Texto fixo do cabeçalho.

            // lblCodigo
            this.lblCodigo.AutoSize = true; // Ajusta ao texto.
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(23, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(91, 23);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código: —"; // Valor substituído em tempo de execução.

            // lblNome
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNome.Location = new System.Drawing.Point(23, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome: —"; // Valor substituído em tempo de execução.

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(23, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail: —"; // Valor substituído em tempo de execução.

            // lblTelefone
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelefone.Location = new System.Drawing.Point(23, 144);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(99, 23);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone: —"; // Valor substituído em tempo de execução.

            // lblUrgencia
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUrgencia.Location = new System.Drawing.Point(23, 171);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(104, 23);
            this.lblUrgencia.TabIndex = 5;
            this.lblUrgencia.Text = "Urgência: —"; // Valor substituído em tempo de execução.

            // lblDataAbertura
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDataAbertura.Location = new System.Drawing.Point(23, 197);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(103, 23);
            this.lblDataAbertura.TabIndex = 6;
            this.lblDataAbertura.Text = "Abertura: —"; // Valor substituído em tempo de execução.

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(23, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 23);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: —"; // Valor substituído em tempo de execução.

            // txtDescricao
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(27, 290);
            this.txtDescricao.Multiline = true; // Permite múltiplas linhas para descrição.
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true; // Impede edição do conteúdo pelo usuário.
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Habilita rolagem vertical.
            this.txtDescricao.Size = new System.Drawing.Size(571, 106);
            this.txtDescricao.TabIndex = 8;

            // txtRespostaTecnico
            this.txtRespostaTecnico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRespostaTecnico.Location = new System.Drawing.Point(27, 441);
            this.txtRespostaTecnico.Multiline = true; // Permite múltiplas linhas para resposta do técnico.
            this.txtRespostaTecnico.Name = "txtRespostaTecnico";
            this.txtRespostaTecnico.ReadOnly = true; // Impede edição direta; usado para exibir histórico/resposta.
            this.txtRespostaTecnico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Habilita rolagem vertical.
            this.txtRespostaTecnico.Size = new System.Drawing.Size(571, 106);
            this.txtRespostaTecnico.TabIndex = 9;

            // btnResolvido
            this.btnResolvido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResolvido.Location = new System.Drawing.Point(27, 565);
            this.btnResolvido.Name = "btnResolvido";
            this.btnResolvido.Size = new System.Drawing.Size(229, 37);
            this.btnResolvido.TabIndex = 10;
            this.btnResolvido.Text = "Marcar como Resolvido"; // Ação para concluir o chamado.
            this.btnResolvido.UseVisualStyleBackColor = true;
            this.btnResolvido.Click += new System.EventHandler(this.btnResolvido_Click); // Evento de clique.

            // btnNaoResolvido
            this.btnNaoResolvido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNaoResolvido.Location = new System.Drawing.Point(369, 565);
            this.btnNaoResolvido.Name = "btnNaoResolvido";
            this.btnNaoResolvido.Size = new System.Drawing.Size(229, 37);
            this.btnNaoResolvido.TabIndex = 11;
            this.btnNaoResolvido.Text = "Não Resolvido"; // Ação alternativa para status.
            this.btnNaoResolvido.UseVisualStyleBackColor = true;
            this.btnNaoResolvido.Click += new System.EventHandler(this.btnNaoResolvido_Click); // Evento de clique.

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(24, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descrição do Problema:"; // Rótulo explicativo.

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(25, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Resposta do Técnico:"; // Rótulo explicativo.

            // DetalhesChamado (form)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Define escala de DPI.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Usa modo de escala padrão.
            this.ClientSize = new System.Drawing.Size(644, 623); // Tamanho da janela.
            this.Controls.Add(this.label2); // Adiciona rótulo resposta.
            this.Controls.Add(this.label1); // Adiciona rótulo descrição.
            this.Controls.Add(this.btnNaoResolvido); // Adiciona botão não resolvido.
            this.Controls.Add(this.btnResolvido); // Adiciona botão resolvido.
            this.Controls.Add(this.txtRespostaTecnico); // Adiciona campo resposta do técnico.
            this.Controls.Add(this.txtDescricao); // Adiciona campo descrição.
            this.Controls.Add(this.lblStatus); // Adiciona label status.
            this.Controls.Add(this.lblDataAbertura); // Adiciona label data de abertura.
            this.Controls.Add(this.lblUrgencia); // Adiciona label urgência.
            this.Controls.Add(this.lblTelefone); // Adiciona label telefone.
            this.Controls.Add(this.lblEmail); // Adiciona label email.
            this.Controls.Add(this.lblNome); // Adiciona label nome.
            this.Controls.Add(this.lblCodigo); // Adiciona label código.
            this.Controls.Add(this.lblTitulo); // Adiciona título.
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Janela modal fixa.
            this.MaximizeBox = false; // Desabilita maximizar.
            this.MinimizeBox = false; // Desabilita minimizar.
            this.Name = "DetalhesChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centraliza janela.
            this.Text = "Detalhes do Chamado"; // Texto do título da janela.
            this.ResumeLayout(false); // Retoma layout.
            this.PerformLayout(); // Aplica ajustes finais de layout.
        }

        #endregion

        // Campos privados que representam controles visuais do formulário.
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblUrgencia;
        private System.Windows.Forms.Label lblDataAbertura;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtRespostaTecnico;
        private System.Windows.Forms.Button btnResolvido;
        private System.Windows.Forms.Button btnNaoResolvido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
