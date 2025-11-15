namespace TonyTI_Login.Apresentacao
{
    partial class SenhaRecover
    {
        // Contém componentes gerenciados pelo designer; liberados no Dispose.
        private System.ComponentModel.IContainer components = null;

        // Libera recursos usados pelo formulário; executado pelo GC quando necessário.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Libera componentes criados pelo designer.
            }
            base.Dispose(disposing); // Mantém o fluxo padrão de descarte.
        }

        #region Windows Form Designer generated code

        // Inicializa todos os controles do formulário; gerado pelo Windows Forms Designer.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container(); // Armazena serviços e componentes do formulário.
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenhaRecover));
            this.pictureBox2 = new System.Windows.Forms.PictureBox(); // Exibe ícone superior.
            this.label4 = new System.Windows.Forms.Label(); // Título principal do formulário.
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Imagem ilustrativa lateral.
            this.label1 = new System.Windows.Forms.Label(); // Texto de instrução para inserir o e-mail.
            this.txtEmailRec = new System.Windows.Forms.TextBox(); // Entrada do e-mail cadastrado.
            this.btnPassRecover = new System.Windows.Forms.Button(); // Botão para solicitar envio de código.
            this.lblPassRec = new System.Windows.Forms.Label(); // Exibe contagem para novo envio.
            this.lblMensagem = new System.Windows.Forms.Label(); // Exibe mensagens de validação ou erro.
            this.panelEmail = new System.Windows.Forms.Panel(); // Agrupa controles da etapa de e-mail.
            this.panelRec = new System.Windows.Forms.Panel(); // Agrupa controles da etapa de validação do código.
            this.btnValidarCodigo = new System.Windows.Forms.Button(); // Botão para confirmar o código digitado.
            this.txtCodigo = new System.Windows.Forms.TextBox(); // Campo para entrada do código de recuperação.
            this.lblRec = new System.Windows.Forms.Label(); // Texto instruindo inserção do código.
            this.timerRec = new System.Windows.Forms.Timer(this.components); // Controla intervalo para reenviar código.
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter(); // Contador de performance não utilizado aqui.

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit(); // Inicializa config da pictureBox.
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEmail.SuspendLayout(); // Aplicado antes de adicionar controles ao painel.
            this.panelRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout(); // Suspende layout para aplicar ajustes.

            // pictureBox2
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image"))); // Carrega recurso de imagem.
            this.pictureBox2.Location = new System.Drawing.Point(129, 9); // Define posição relativa no formulário.
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43); // Define dimensões da imagem.
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Ajusta imagem ao espaço disponível.
            this.pictureBox2.TabIndex = 13; // Mantém ordem de tabulação.
            this.pictureBox2.TabStop = false; // Não permite foco via Tab.

            // label4
            this.label4.AutoSize = true; // Ajusta a label ao tamanho do texto.
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F); // Define estilo do título.
            this.label4.Location = new System.Drawing.Point(192, 9); // Posição do título na tela.
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 37); // Tamanho estimado do texto.
            this.label4.TabIndex = 12;
            this.label4.Text = "TONY | TI - RESETAR SENHA"; // Título exibido ao usuário.

            // pictureBox1
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image"))); // Imagem ilustrativa.
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Evita distorção.
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;

            // label1
            this.label1.AutoSize = true; // Ajusta ao texto.
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F); // Estilo da instrução.
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digite seu E-mail cadastrado:"; // Instrução principal da primeira etapa.

            // txtEmailRec
            this.txtEmailRec.Font = new System.Drawing.Font("Times New Roman", 13.8F); // Estilo de entrada do e-mail.
            this.txtEmailRec.Location = new System.Drawing.Point(40, 60);
            this.txtEmailRec.Name = "txtEmailRec";
            this.txtEmailRec.Size = new System.Drawing.Size(344, 34); // Largura adequada para e-mails comuns.
            this.txtEmailRec.TabIndex = 16; // Ordem de tabulação da entrada.
            this.txtEmailRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; // Centraliza texto digitado.

            // btnPassRecover
            this.btnPassRecover.BackColor = System.Drawing.Color.Lime; // Cor de destaque do botão.
            this.btnPassRecover.Cursor = System.Windows.Forms.Cursors.Hand; // Apresenta cursor “mão”.
            this.btnPassRecover.Font = new System.Drawing.Font("Times New Roman", 12F); // Estilo do texto do botão.
            this.btnPassRecover.Location = new System.Drawing.Point(106, 130);
            this.btnPassRecover.Name = "btnPassRecover";
            this.btnPassRecover.Size = new System.Drawing.Size(230, 45); // Tamanho confortável para toque ou clique.
            this.btnPassRecover.TabIndex = 17;
            this.btnPassRecover.Text = "ENVIAR CÓDIGO"; // Texto do botão.
            this.btnPassRecover.UseVisualStyleBackColor = false; // Mantém cor personalizada.
            this.btnPassRecover.Click += new System.EventHandler(this.btnPassRecover_Click); // Evento disparado ao clicar.

            // lblPassRec
            this.lblPassRec.AutoSize = true;
            this.lblPassRec.Font = new System.Drawing.Font("Times New Roman", 19.8F); // Estilo do contador.
            this.lblPassRec.Location = new System.Drawing.Point(37, 190);
            this.lblPassRec.Name = "lblPassRec";
            this.lblPassRec.Size = new System.Drawing.Size(353, 37);
            this.lblPassRec.TabIndex = 18;
            this.lblPassRec.Text = "Reenviar código em: 0:30"; // Contador inicial antes de novo envio.

            // lblMensagem
            this.lblMensagem.AutoSize = true; // Exibe respostas curtas ao usuário.
            this.lblMensagem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensagem.Location = new System.Drawing.Point(40, 97);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 23); // Inicialmente vazio.
            this.lblMensagem.TabIndex = 19;

            // panelEmail
            this.panelEmail.Controls.Add(this.label1); // Adiciona controles à etapa de e-mail.
            this.panelEmail.Controls.Add(this.lblMensagem);
            this.panelEmail.Controls.Add(this.txtEmailRec);
            this.panelEmail.Controls.Add(this.lblPassRec);
            this.panelEmail.Controls.Add(this.btnPassRecover);
            this.panelEmail.Location = new System.Drawing.Point(282, 84);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(473, 323); // Agrupa controles de forma organizada.
            this.panelEmail.TabIndex = 20;

            // panelRec
            this.panelRec.Controls.Add(this.btnValidarCodigo); // Contém elementos da segunda etapa.
            this.panelRec.Controls.Add(this.txtCodigo);
            this.panelRec.Controls.Add(this.lblRec);
            this.panelRec.Location = new System.Drawing.Point(282, 84);
            this.panelRec.Name = "panelRec";
            this.panelRec.Size = new System.Drawing.Size(470, 320);
            this.panelRec.TabIndex = 20;
            this.panelRec.Visible = false; // Começa oculto até a primeira etapa ser concluída.

            // btnValidarCodigo
            this.btnValidarCodigo.BackColor = System.Drawing.Color.Chartreuse; // Cor de destaque para validação.
            this.btnValidarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarCodigo.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnValidarCodigo.Location = new System.Drawing.Point(143, 140);
            this.btnValidarCodigo.Name = "btnValidarCodigo";
            this.btnValidarCodigo.Size = new System.Drawing.Size(128, 47);
            this.btnValidarCodigo.TabIndex = 2;
            this.btnValidarCodigo.Text = "Validar Código"; // Aciona validação.
            this.btnValidarCodigo.UseVisualStyleBackColor = false;
            this.btnValidarCodigo.Click += new System.EventHandler(this.btnValidarCodigo_Click);

            // txtCodigo
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.txtCodigo.Location = new System.Drawing.Point(88, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(248, 39); // Espaço suficiente para códigos numéricos.
            this.txtCodigo.TabIndex = 1;

            // lblRec
            this.lblRec.AutoSize = true;
            this.lblRec.BackColor = System.Drawing.Color.Transparent;
            this.lblRec.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.lblRec.Location = new System.Drawing.Point(31, 25);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(370, 33);
            this.lblRec.TabIndex = 0;
            this.lblRec.Text = "Insira o código de Recuperação:"; // Instrução da etapa final.

            // SenhaRecover
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Ajuste automático proporcional.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Usa escala padrão.
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRec); // Adiciona painel de validação.
            this.Controls.Add(this.panelEmail); // Adiciona painel inicial.
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Name = "SenhaRecover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centraliza na abertura.
            this.Text = "SenhaRecover"; // Título da janela.

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit(); // Finaliza inicialização.
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelRec.ResumeLayout(false);
            this.panelRec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout(); // Retoma gerenciamento do layout.
        }

        #endregion

        // Campos privados usados no formulário; representam controles visuais.
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailRec;
        private System.Windows.Forms.Button btnPassRecover;
        private System.Windows.Forms.Label lblPassRec;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Panel panelRec;
        private System.Windows.Forms.Button btnValidarCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Timer timerRec;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}
