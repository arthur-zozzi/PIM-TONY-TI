namespace TonyTI_Login.Apresentacao
{
    partial class InicioSistema
    {
        // Armazena componentes gerenciados pelo designer; liberados no Dispose.
        private System.ComponentModel.IContainer components = null;

        // Libera recursos usados pelo componente; chamado ao descartar.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Libera componentes criados pelo designer.
            }
            base.Dispose(disposing); // Executa Dispose da classe base.
        }

        #region Código gerado pelo Designer de Componentes

        // Inicializa controles visuais do componente; gerado pelo Designer.
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel(); // Contêiner principal do controle.
            this.panel1 = new System.Windows.Forms.Panel(); // Painel interno que agrupa conteúdo.
            this.pictureBox2 = new System.Windows.Forms.PictureBox(); // Imagem de apresentação do sistema.
            this.button6 = new System.Windows.Forms.Button(); // Atalho/atalho de ajuda.
            this.button5 = new System.Windows.Forms.Button(); // Atalho para sair do sistema.
            this.button4 = new System.Windows.Forms.Button(); // Atalho para abrir chamado.
            this.button3 = new System.Windows.Forms.Button(); // Atalho para contatar cliente.
            this.button2 = new System.Windows.Forms.Button(); // Atalho para meus chamados.
            this.button1 = new System.Windows.Forms.Button(); // Atalho para página principal.
            this.label1 = new System.Windows.Forms.Label(); // Rótulo "Acesso Rápido".
            this.panelContainer.SuspendLayout(); // Suspende layout ao adicionar controles.
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            // panelContainer
            this.panelContainer.Controls.Add(this.button6); // Adiciona botão de ajuda ao container.
            this.panelContainer.Controls.Add(this.panel1); // Adiciona painel interno ao container.
            this.panelContainer.Location = new System.Drawing.Point(-29, -88); // Posicionamento do container.
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1171, 720); // Dimensão do container.
            this.panelContainer.TabIndex = 17;

            // panel1
            this.panel1.Controls.Add(this.pictureBox2); // Adiciona imagem principal ao painel.
            this.panel1.Controls.Add(this.button5); // Adiciona atalho sair.
            this.panel1.Controls.Add(this.button4); // Adiciona atalho abrir chamado.
            this.panel1.Controls.Add(this.button3); // Adiciona atalho contatar cliente.
            this.panel1.Controls.Add(this.button2); // Adiciona atalho meus chamados.
            this.panel1.Controls.Add(this.button1); // Adiciona atalho principal.
            this.panel1.Controls.Add(this.label1); // Adiciona rótulo de seção.
            this.panel1.Location = new System.Drawing.Point(102, 35); // Posição relativa dentro do container.
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 650); // Dimensão do painel interno.
            this.panel1.TabIndex = 17;

            // pictureBox2
            this.pictureBox2.Image = global::TonyTI_Login.Properties.Resources.inicioSistema; // Recurso visual de apresentação.
            this.pictureBox2.Location = new System.Drawing.Point(3, 17); // Posição da imagem.
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1043, 401); // Dimensão da imagem.
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Ajusta imagem ao espaço.
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;

            // button6
            this.button6.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgAjuda; // Ícone de ajuda.
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; // Ajusta ícone.
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand; // Indica interatividade.
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(1014, 560); // Posição do botão de ajuda no container.
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(134, 121); // Tamanho do botão de atalho.
            this.button6.TabIndex = 4;
            this.button6.Text = "Ajuda"; // Texto do atalho.
            this.button6.UseVisualStyleBackColor = true;

            // button5
            this.button5.BackColor = System.Drawing.Color.Transparent; // Mantém fundo transparente.
            this.button5.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgSair; // Ícone sair.
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand; // Indica clicável.
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(730, 529); // Posição do atalho sair.
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 121); // Dimensão do botão.
            this.button5.TabIndex = 4;
            this.button5.Text = "Sair"; // Texto visível no botão.
            this.button5.UseVisualStyleBackColor = false;

            // button4
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgAbrirChamado; // Ícone abrir chamado.
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(544, 526); // Posição do atalho abrir chamado.
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 121);
            this.button4.TabIndex = 4;
            this.button4.Text = "Abrir Chamado"; // Texto do atalho.
            this.button4.UseVisualStyleBackColor = false;

            // button3
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgContatarCliente; // Ícone contatar cliente.
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(364, 529); // Posição do atalho contatar cliente.
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 121);
            this.button3.TabIndex = 4;
            this.button3.Text = "Contatar Cliente"; // Texto do atalho.
            this.button3.UseVisualStyleBackColor = false;

            // button2
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::TonyTI_Login.Properties.Resources.imgChamados; // Ícone meus chamados.
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(186, 529); // Posição do atalho meus chamados.
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 121);
            this.button2.TabIndex = 4;
            this.button2.Text = "Meus Chamados"; // Texto do atalho.
            this.button2.UseVisualStyleBackColor = false;

            // button1
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::TonyTI_Login.Properties.Resources.icons8_quatro_quadrados_48; // Ícone principal.
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(2, 526); // Posição do atalho principal.
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 121);
            this.button1.TabIndex = 4;
            this.button1.Text = "Principal"; // Texto do atalho.
            this.button1.UseVisualStyleBackColor = false;

            // label1
            this.label1.AutoSize = true; // Ajusta o controle ao texto.
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 437); // Posição do rótulo "Acesso Rápido".
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Acesso Rápido:"; // Texto informativo.

            // InicioSistema (controle)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Dimensões de escala.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Modo de escala.
            this.Controls.Add(this.panelContainer); // Adiciona container ao controle.
            this.Name = "InicioSistema";
            this.Size = new System.Drawing.Size(1200, 594); // Tamanho padrão do controle.
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout(); // Restaura layout do painel interno.
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false); // Restaura layout do controle.
        }

        #endregion

        // Campos privados que representam controles visuais no componente.
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
