namespace TonyTI_Login.Apresentacao
{
    partial class Cadastro
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

        #region Windows Form Designer generated code

        // Inicializa os controles visuais do formulário; gerado pelo Designer.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));

            // Rótulos e campos principais do formulário de cadastro.
            this.label1 = new System.Windows.Forms.Label(); // Label para campo Email.
            this.label2 = new System.Windows.Forms.Label(); // Label para campo Senha.
            this.label3 = new System.Windows.Forms.Label(); // Label para campo Confirmar Senha.
            this.txtEmailNewUser = new System.Windows.Forms.TextBox(); // Campo para inserir e-mail do novo usuário.
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox(); // Campo para confirmação da senha.
            this.txtPassNewUser = new System.Windows.Forms.TextBox(); // Campo para digitar a nova senha.
            this.btnReturn = new System.Windows.Forms.Button(); // Botão para voltar/cancelar cadastro.
            this.btnCadastro = new System.Windows.Forms.Button(); // Botão para efetuar o cadastro.
            this.label4 = new System.Windows.Forms.Label(); // Título do formulário.
            this.verSenha = new System.Windows.Forms.PictureBox(); // Ícone para mostrar/ocultar confirmação de senha.
            this.viewPass = new System.Windows.Forms.PictureBox(); // Ícone para mostrar/ocultar senha principal.
            this.pictureBox5 = new System.Windows.Forms.PictureBox(); // Ícone auxiliar junto ao campo email.
            this.pictureBox3 = new System.Windows.Forms.PictureBox(); // Ícone auxiliar junto ao confirmar senha.
            this.pictureBox4 = new System.Windows.Forms.PictureBox(); // Ícone auxiliar junto ao campo senha.
            this.pictureBox2 = new System.Windows.Forms.PictureBox(); // Ícone de cabeçalho/sistema.
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Imagem ilustrativa lateral.

            ((System.ComponentModel.ISupportInitialize)(this.verSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // label1 (Email)
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right))); // Mantém ancoragem consistente no layout.
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(325, 91); // Posição relativa do rótulo Email.
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:"; // Texto exibido ao usuário.
            this.label1.Click += new System.EventHandler(this.label1_Click); // Evento opcional (gerado pelo designer).

            // label2 (Senha)
            this.label2.Anchor = this.label1.Anchor;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(324, 159); // Posição do rótulo Senha.
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);

            // label3 (Confirmar Senha)
            this.label3.Anchor = this.label1.Anchor;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(324, 228); // Posição do rótulo Confirmar Senha.
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Senha:";

            // txtEmailNewUser
            this.txtEmailNewUser.Anchor = this.label1.Anchor;
            this.txtEmailNewUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtEmailNewUser.Location = new System.Drawing.Point(322, 116); // Campo de entrada para e-mail.
            this.txtEmailNewUser.Name = "txtEmailNewUser";
            this.txtEmailNewUser.Size = new System.Drawing.Size(297, 30);
            this.txtEmailNewUser.TabIndex = 1;

            // txtConfirmNewPass
            this.txtConfirmNewPass.Anchor = this.label1.Anchor;
            this.txtConfirmNewPass.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtConfirmNewPass.Location = new System.Drawing.Point(322, 253); // Campo para confirmar senha (oculto).
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.Size = new System.Drawing.Size(297, 30);
            this.txtConfirmNewPass.TabIndex = 3;
            this.txtConfirmNewPass.UseSystemPasswordChar = true; // Mantém caracteres ocultos por padrão.

            // txtPassNewUser
            this.txtPassNewUser.Anchor = this.label1.Anchor;
            this.txtPassNewUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPassNewUser.Location = new System.Drawing.Point(322, 184); // Campo para digitar a senha (oculto).
            this.txtPassNewUser.Name = "txtPassNewUser";
            this.txtPassNewUser.Size = new System.Drawing.Size(297, 30);
            this.txtPassNewUser.TabIndex = 2;
            this.txtPassNewUser.UseSystemPasswordChar = true; // Usa máscara de senha.

            // btnReturn (Voltar)
            this.btnReturn.Anchor = this.label1.Anchor;
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReturn.Location = new System.Drawing.Point(499, 298); // Botão de cancelar/voltar.
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 38);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click); // Fecha/retorna ao formulário anterior.

            // btnCadastro (Cadastrar)
            this.btnCadastro.Anchor = this.label1.Anchor;
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCadastro.Location = new System.Drawing.Point(311, 298); // Botão para confirmar cadastro.
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(109, 38);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click); // Valida e persiste novo usuário.

            // label4 (Título)
            this.label4.Anchor = this.label1.Anchor;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F);
            this.label4.Location = new System.Drawing.Point(81, 9); // Título destacado do formulário.
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "TONY | TI - CADASTRO DE USUÁRIOS";

            // verSenha (ícone confirmar senha)
            this.verSenha.Anchor = this.label1.Anchor;
            this.verSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verSenha.Image = global::TonyTI_Login.Properties.Resources.hiddenPass; // Ícone padrão (oculto).
            this.verSenha.Location = new System.Drawing.Point(628, 258); // Ícone ao lado do campo confirmar senha.
            this.verSenha.Name = "verSenha";
            this.verSenha.Size = new System.Drawing.Size(20, 20);
            this.verSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.verSenha.TabIndex = 19;
            this.verSenha.TabStop = false;
            this.verSenha.Click += new System.EventHandler(this.verSenha_Click); // Alterna a visibilidade do campo confirmar senha.
            this.verSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.verSenha_MouseDown); // Exibe senha enquanto pressionado.
            this.verSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.verSenha_MouseUp); // Restaura máscara ao soltar.

            // viewPass (ícone senha principal)
            this.viewPass.Anchor = this.label1.Anchor;
            this.viewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPass.Image = global::TonyTI_Login.Properties.Resources.hiddenPass;
            this.viewPass.Location = new System.Drawing.Point(628, 187); // Ícone ao lado do campo senha.
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(20, 20);
            this.viewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.viewPass.TabIndex = 18;
            this.viewPass.TabStop = false;
            this.viewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewPass_MouseDown); // Exibe senha enquanto pressionado.
            this.viewPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewPass_MouseUp); // Restaura máscara ao soltar.

            // pictureBox5 (ícone auxiliar email)
            this.pictureBox5.Anchor = this.label1.Anchor;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image"))); // Ícone auxiliar.
            this.pictureBox5.Location = new System.Drawing.Point(277, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;

            // pictureBox3 (ícone auxiliar confirmar senha)
            this.pictureBox3.Anchor = this.label1.Anchor;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(278, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;

            // pictureBox4 (ícone auxiliar senha)
            this.pictureBox4.Anchor = this.label1.Anchor;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(277, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;

            // pictureBox2 (ícone cabeçalho)
            this.pictureBox2.Anchor = this.label1.Anchor;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;

            // pictureBox1 (imagem lateral)
            this.pictureBox1.Anchor = this.label1.Anchor;
            this.pictureBox1.Image = global::TonyTI_Login.Properties.Resources.LoginDesktop; // Imagem ilustrativa.
            this.pictureBox1.Location = new System.Drawing.Point(14, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;

            // Cadastro (form)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Define escala de DPI.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403); // Tamanho inicial da janela.
            this.Controls.Add(this.verSenha); // Ícone confirmar senha.
            this.Controls.Add(this.viewPass); // Ícone visualizar senha.
            this.Controls.Add(this.pictureBox5); // Ícone auxiliar email.
            this.Controls.Add(this.pictureBox3); // Ícone auxiliar confirmar senha.
            this.Controls.Add(this.pictureBox4); // Ícone auxiliar senha.
            this.Controls.Add(this.pictureBox2); // Ícone cabeçalho.
            this.Controls.Add(this.label4); // Título do formulário.
            this.Controls.Add(this.pictureBox1); // Imagem lateral.
            this.Controls.Add(this.btnCadastro); // Botão cadastrar.
            this.Controls.Add(this.btnReturn); // Botão voltar.
            this.Controls.Add(this.txtPassNewUser); // Campo senha.
            this.Controls.Add(this.txtConfirmNewPass); // Campo confirmar senha.
            this.Controls.Add(this.txtEmailNewUser); // Campo email.
            this.Controls.Add(this.label3); // Rótulo confirmar senha.
            this.Controls.Add(this.label2); // Rótulo senha.
            this.Controls.Add(this.label1); // Rótulo email.
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow; // Janela com borda fixa.
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centraliza ao abrir.
            this.Text = "Tony TI | Cadastro"; // Texto da janela.
            this.Load += new System.EventHandler(this.Cadastro_Load); // Evento de inicialização do formulário.

            ((System.ComponentModel.ISupportInitialize)(this.verSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout(); // Aplica ajustes finais de layout.
        }

        #endregion

        // Campos privados que representam controles visuais no formulário.
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailNewUser;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.TextBox txtPassNewUser;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox viewPass;
        private System.Windows.Forms.PictureBox verSenha;
    }
}
