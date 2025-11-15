namespace TonyTI_Login.Apresentacao
{
    partial class RedefinirSenha
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
            base.Dispose(disposing); // Executa o Dispose da classe base.
        }

        #region Windows Form Designer generated code

        // Inicializa os controles visuais do formulário; gerado pelo Designer do Windows Forms.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            this.label4 = new System.Windows.Forms.Label(); // Título principal da tela.
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Imagem ilustrativa lateral.
            this.pictureBox2 = new System.Windows.Forms.PictureBox(); // Ícone próximo ao título.
            this.viewNewPass = new System.Windows.Forms.PictureBox(); // Ícone para mostrar/ocultar nova senha.
            this.pictureBox4 = new System.Windows.Forms.PictureBox(); // Ícone junto ao campo de nova senha.
            this.txtNewPassword = new System.Windows.Forms.TextBox(); // Campo para digitar a nova senha.
            this.lblPassword = new System.Windows.Forms.Label(); // Label do campo nova senha.
            this.label1 = new System.Windows.Forms.Label(); // Label do campo confirmar senha.
            this.txtConfirmPassword = new System.Windows.Forms.TextBox(); // Campo para confirmar a nova senha.
            this.pictureBox3 = new System.Windows.Forms.PictureBox(); // Ícone junto ao campo confirmar senha.
            this.viewConfirmPass = new System.Windows.Forms.PictureBox(); // Ícone para mostrar/ocultar confirmação.
            this.btnAlterarSenha = new System.Windows.Forms.Button(); // Botão que confirma alteração de senha.
            this.email = new System.Windows.Forms.TextBox(); // Campo oculto usado para transportar e-mail entre formulários.

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConfirmPass)).BeginInit();
            this.SuspendLayout();

            // label4
            this.label4.AutoSize = true; // Ajusta o controle ao conteúdo do texto.
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F); // Define fonte do título.
            this.label4.Location = new System.Drawing.Point(199, 21); // Posição do título na tela.
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "TONY | TI - ALTERE SUA SENHA"; // Texto exibido ao usuário.

            // pictureBox1
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image"))); // Carrega recurso visual.
            this.pictureBox1.Location = new System.Drawing.Point(12, 114); // Posição da imagem lateral.
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 260); // Dimensões da imagem.
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Ajusta imagem ao espaço.
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;

            // pictureBox2
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image"))); // Ícone do cabeçalho.
            this.pictureBox2.Location = new System.Drawing.Point(136, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;

            // viewNewPass
            this.viewNewPass.Cursor = System.Windows.Forms.Cursors.Hand; // Indica que é interativo.
            this.viewNewPass.Image = global::TonyTI_Login.Properties.Resources.hiddenPass; // Ícone padrão de ocultar senha.
            this.viewNewPass.Location = new System.Drawing.Point(755, 154); // Posição do ícone de visualização.
            this.viewNewPass.Name = "viewNewPass";
            this.viewNewPass.Size = new System.Drawing.Size(20, 20);
            this.viewNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.viewNewPass.TabIndex = 20;
            this.viewNewPass.TabStop = false;
            this.viewNewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewNewPass_MouseDown); // Exibe senha enquanto pressionado.
            this.viewNewPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewNewPass_MouseUp); // Oculta senha ao soltar.

            // pictureBox4
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image"))); // Ícone informativo ao lado do campo.
            this.pictureBox4.Location = new System.Drawing.Point(291, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;

            // txtNewPassword
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F); // Fonte do campo de senha.
            this.txtNewPassword.Location = new System.Drawing.Point(521, 153); // Posição do campo nova senha.
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(228, 27); // Largura confortável para entrada.
            this.txtNewPassword.TabIndex = 17;
            this.txtNewPassword.UseSystemPasswordChar = true; // Oculta caracteres por padrão.

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F); // Fonte da label do campo.
            this.lblPassword.Location = new System.Drawing.Point(332, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(158, 26);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "NOVA SENHA:"; // Indica o propósito do campo.

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F); // Fonte menor para confirmação.
            this.label1.Location = new System.Drawing.Point(332, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "CONFIRMAR SENHA:"; // Orienta o usuário a confirmar senha.

            // txtConfirmPassword
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(521, 248); // Posição do campo de confirmação.
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(228, 27);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.UseSystemPasswordChar = true; // Mantém ocultação por padrão.

            // pictureBox3
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image"))); // Ícone ao lado do campo de confirmação.
            this.pictureBox3.Location = new System.Drawing.Point(293, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;

            // viewConfirmPass
            this.viewConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand; // Ícone interativo para confirmação.
            this.viewConfirmPass.Image = global::TonyTI_Login.Properties.Resources.hiddenPass; // Ícone padrão.
            this.viewConfirmPass.Location = new System.Drawing.Point(757, 249);
            this.viewConfirmPass.Name = "viewConfirmPass";
            this.viewConfirmPass.Size = new System.Drawing.Size(20, 20);
            this.viewConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.viewConfirmPass.TabIndex = 20;
            this.viewConfirmPass.TabStop = false;
            this.viewConfirmPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewConfirmPass_MouseDown); // Exibe senha enquanto pressionado.
            this.viewConfirmPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewConfirmPass_MouseUp); // Oculta senha ao soltar.

            // btnAlterarSenha
            this.btnAlterarSenha.BackColor = System.Drawing.Color.Lime; // Cor de destaque do botão.
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand; // Indica clicável.
            this.btnAlterarSenha.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAlterarSenha.Location = new System.Drawing.Point(396, 329); // Posição do botão confirmar.
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(229, 45); // Tamanho confortável para clique.
            this.btnAlterarSenha.TabIndex = 21;
            this.btnAlterarSenha.Text = "ALTERAR SENHA"; // Texto de ação.
            this.btnAlterarSenha.UseVisualStyleBackColor = false; // Mantém cor personalizada.
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click_1); // Evento que dispara a lógica de alteração.

            // email
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Mantém ancoragem dependendo do layout.
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F); // Fonte do campo auxiliar.
            this.email.Location = new System.Drawing.Point(206, 191); // Posição atual do campo; tamanho pequeno intencional.
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(10, 30); // Campo praticamente oculto; usado para transporte de dados entre formulários.
            this.email.TabIndex = 23;

            // RedefinirSenha
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Define escala de DPI.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // Usa modo de escala padrão.
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterarSenha); // Adiciona botão ao formulário.
            this.Controls.Add(this.viewConfirmPass); // Adiciona ícone de visualização de confirmação.
            this.Controls.Add(this.viewNewPass); // Adiciona ícone de visualização de nova senha.
            this.Controls.Add(this.pictureBox3); // Adiciona ícone auxiliar.
            this.Controls.Add(this.pictureBox4); // Adiciona ícone auxiliar.
            this.Controls.Add(this.txtConfirmPassword); // Adiciona campo confirmar senha.
            this.Controls.Add(this.label1); // Adiciona label confirmar senha.
            this.Controls.Add(this.txtNewPassword); // Adiciona campo nova senha.
            this.Controls.Add(this.lblPassword); // Adiciona label nova senha.
            this.Controls.Add(this.pictureBox1); // Adiciona imagem lateral.
            this.Controls.Add(this.pictureBox2); // Adiciona ícone do cabeçalho.
            this.Controls.Add(this.label4); // Adiciona título.
            this.Controls.Add(this.email); // Adiciona campo auxiliar de e-mail.
            this.Name = "RedefinirSenha";
            this.Text = "RedefinirSenha"; // Texto da janela.

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConfirmPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Campos privados que representam controles visuais.
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox viewNewPass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox viewConfirmPass;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.TextBox email;
    }
}
