namespace TonyTI_Login.Apresentacao
{
    partial class AbrirChamado
    {
        // Armazena componentes gerenciados pelo designer; liberados no Dispose.
        private System.ComponentModel.IContainer components = null;

        // Libera recursos usados pelo componente; executado ao descartar a instância.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Libera componentes criados pelo designer.
            }
            base.Dispose(disposing); // Executa Dispose da classe base.
        }

        #region Código gerado pelo Designer de Componentes

        // Inicializa controles visuais e layout do componente; gerado pelo Designer.
        private void InitializeComponent()
        {
            this.btnNewChamado = new System.Windows.Forms.Button(); // Botão que inicia fluxo de novo chamado.
            this.pnlNewChamado = new System.Windows.Forms.Panel(); // Painel que contém o formulário de abertura.
            this.btnEnviar = new System.Windows.Forms.Button(); // Botão para enviar o chamado.
            this.btnAnexar = new System.Windows.Forms.Button(); // Botão para anexar arquivos ao chamado.
            this.label5 = new System.Windows.Forms.Label(); // Rótulo para campo descrição.
            this.label4 = new System.Windows.Forms.Label(); // Rótulo para urgência.
            this.label3 = new System.Windows.Forms.Label(); // Rótulo para telefone.
            this.label2 = new System.Windows.Forms.Label(); // Rótulo para e-mail.
            this.label1 = new System.Windows.Forms.Label(); // Rótulo para nome.
            this.cbUrgencia = new System.Windows.Forms.ComboBox(); // ComboBox para selecionar grau de urgência.
            this.txtTelefone = new System.Windows.Forms.TextBox(); // Campo de telefone do solicitante.
            this.txtDescricao = new System.Windows.Forms.TextBox(); // Campo de descrição do problema.
            this.txtEmail = new System.Windows.Forms.TextBox(); // Campo de e-mail do solicitante.
            this.txtNome = new System.Windows.Forms.TextBox(); // Campo de nome do solicitante.
            this.btnCancelar = new System.Windows.Forms.Button(); // Botão para cancelar o preenchimento.

            this.pnlNewChamado.SuspendLayout();
            this.SuspendLayout();

            // btnNewChamado
            // Botão visual proeminente que representa a ação de criar um novo chamado.
            this.btnNewChamado.BackColor = System.Drawing.Color.Aqua;
            this.btnNewChamado.BackgroundImage = global::TonyTI_Login.Properties.Resources.btnNewChamado1;
            this.btnNewChamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewChamado.ForeColor = System.Drawing.Color.Black;
            this.btnNewChamado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewChamado.Location = new System.Drawing.Point(20, 3);
            this.btnNewChamado.Name = "btnNewChamado";
            this.btnNewChamado.Size = new System.Drawing.Size(144, 154);
            this.btnNewChamado.TabIndex = 0;
            this.btnNewChamado.Text = "Novo Chamado";
            this.btnNewChamado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewChamado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNewChamado.UseVisualStyleBackColor = false;

            // pnlNewChamado
            // Painel que reúne os campos do formulário de abertura de chamado.
            this.pnlNewChamado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNewChamado.Controls.Add(this.btnCancelar);
            this.pnlNewChamado.Controls.Add(this.btnEnviar);
            this.pnlNewChamado.Controls.Add(this.btnAnexar);
            this.pnlNewChamado.Controls.Add(this.label5);
            this.pnlNewChamado.Controls.Add(this.label4);
            this.pnlNewChamado.Controls.Add(this.label3);
            this.pnlNewChamado.Controls.Add(this.label2);
            this.pnlNewChamado.Controls.Add(this.label1);
            this.pnlNewChamado.Controls.Add(this.cbUrgencia);
            this.pnlNewChamado.Controls.Add(this.txtTelefone);
            this.pnlNewChamado.Controls.Add(this.txtDescricao);
            this.pnlNewChamado.Controls.Add(this.txtEmail);
            this.pnlNewChamado.Controls.Add(this.txtNome);
            this.pnlNewChamado.Location = new System.Drawing.Point(20, 163);
            this.pnlNewChamado.Name = "pnlNewChamado";
            this.pnlNewChamado.Size = new System.Drawing.Size(5538, 421); // Observação: dimensão muito grande pode ser ajuste do designer.
            this.pnlNewChamado.TabIndex = 1;

            // btnEnviar
            // Envia os dados do formulário; deve ser associado a validações antes do envio.
            this.btnEnviar.BackColor = System.Drawing.Color.Lime;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(486, 354);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(143, 43);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar Chamado";
            this.btnEnviar.UseVisualStyleBackColor = false;

            // btnAnexar
            // Aciona seleção de arquivos para anexar ao chamado; validação de tipos/tamanho é recomendada.
            this.btnAnexar.AutoSize = true;
            this.btnAnexar.BackColor = System.Drawing.Color.Transparent;
            this.btnAnexar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnexar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Underline);
            this.btnAnexar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAnexar.Location = new System.Drawing.Point(24, 351);
            this.btnAnexar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(149, 26);
            this.btnAnexar.TabIndex = 11;
            this.btnAnexar.Text = "Anexar Arquivos";
            this.btnAnexar.UseVisualStyleBackColor = false;

            // label5 (Descrição)
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label5.Location = new System.Drawing.Point(18, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diga o motivo do seu chamado:";

            // label4 (Urgência)
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label4.Location = new System.Drawing.Point(18, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grau de Urgência:";

            // label3 (Telefone)
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label3.Location = new System.Drawing.Point(327, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Num. Telefone:";

            // label2 (E-mail)
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail:";

            // label1 (Nome)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";

            // cbUrgencia
            // Deve ser populado com opções como Baixa, Média, Alta; considerar usar enums no backend.
            this.cbUrgencia.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.cbUrgencia.FormattingEnabled = true;
            this.cbUrgencia.Location = new System.Drawing.Point(24, 217);
            this.cbUrgencia.Name = "cbUrgencia";
            this.cbUrgencia.Size = new System.Drawing.Size(276, 39);
            this.cbUrgencia.TabIndex = 5;

            // txtTelefone
            this.txtTelefone.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.txtTelefone.Location = new System.Drawing.Point(333, 139);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(276, 39);
            this.txtTelefone.TabIndex = 4;

            // txtDescricao
            // Campo multilinha para descrever o problema; considerar aumentar altura para melhores entradas.
            this.txtDescricao.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.txtDescricao.Location = new System.Drawing.Point(24, 309);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(585, 39);
            this.txtDescricao.TabIndex = 3;

            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.txtEmail.Location = new System.Drawing.Point(24, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 39);
            this.txtEmail.TabIndex = 1;

            // txtNome
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.txtNome.Location = new System.Drawing.Point(24, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(585, 39);
            this.txtNome.TabIndex = 0;

            // btnCancelar
            // Cancelamento do preenchimento; deve limpar campos ou fechar painel conforme a UX definida.
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(296, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 42);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;

            // AbrirChamado (controle)
            // Configura componentes principais e adiciona controles ao container.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.pnlNewChamado);
            this.Controls.Add(this.btnNewChamado);
            this.Name = "AbrirChamado";
            this.Size = new System.Drawing.Size(5562, 587); // Observação: tamanho do designer parece excessivo para uso real.
            this.pnlNewChamado.ResumeLayout(false);
            this.pnlNewChamado.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Campos privados que representam controles visuais do componente.
        private System.Windows.Forms.Button btnNewChamado;
        private System.Windows.Forms.Panel pnlNewChamado;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUrgencia;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
