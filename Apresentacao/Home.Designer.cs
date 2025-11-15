namespace TonyTI_Login
{
    partial class Login
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

        // Inicializa os controles visuais do formulário; gerado pelo Designer do Windows Forms.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnExit = new System.Windows.Forms.Button(); // Botão para sair do aplicativo.
            this.btnLogin = new System.Windows.Forms.Button(); // Botão para autenticar usuário.
            this.lblLogin = new System.Windows.Forms.Label(); // Label do campo de login.
            this.lblPassword = new System.Windows.Forms.Label(); // Label do campo de senha.
            this.txtPassword = new System.Windows.Forms.TextBox(); // Campo de entrada de senha.
            this.txtLogin = new System.Windows.Forms.TextBox(); // Campo de entrada de usuário/login.
            this.btnFirstAcess = new System.Windows.Forms.Button(); // Botão para primeiro acesso/registro.
            this.label4 = new System.Windows.Forms.Label(); // Título do formulário.
            this.btnForgotPass = new System.Windows.Forms.Button(); // Botão para recuperar senha.
            this.viewPass = new System.Windows.Forms.PictureBox(); // Ícone para mostrar/ocultar senha.
            this.pictureBox4 = new System.Windows.Forms.PictureBox(); // Ícone auxiliar ao lado da senha.
            this.pictureBox3 = new System.Windows.Forms.PictureBox(); // Ícone auxiliar ao lado do login.
            this.pictureBox2 = new System.Windows.Forms.PictureBox(); // Ícone do cabeçalho.
            this.pictureBox1 = new System.Windows.Forms.PictureBox(); // Imagem ilustrativa lateral.
            ((System.ComponentModel.ISupportInitialize)(this.viewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout(); // Suspende layout durante a configuração.

            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.Red; // Destaca ação de saída em vermelho.
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand; // Indica interatividade.
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnExit.Location = new System.Drawing.Point(540, 228); // Posição do botão sair.
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 30); // Tamanho confortável para clique.
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "SAIR"; // Texto do botão.
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click); // Fecha aplicação ou sessão.

            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.Lime; // Destaca ação principal em verde.
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLogin.Location = new System.Drawing.Point(377, 228); // Posição do botão entrar.
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ENTRAR"; // Aciona autenticação.
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click); // Dispara validação de credenciais.

            // lblLogin
            this.lblLogin.AutoSize = true; // Ajusta ao conteúdo do texto.
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblLogin.Location = new System.Drawing.Point(325, 113); // Posição da label login.
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 22);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "LOGIN:"; // Identifica o campo de login.
            this.lblLogin.Click += new System.EventHandler(this.label1_Click); // Evento opcional associado.

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPassword.Location = new System.Drawing.Point(325, 158); // Posição da label senha.
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 22);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "SENHA:"; // Identifica o campo de senha.

            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtPassword.Location = new System.Drawing.Point(412, 159); // Campo de entrada da senha.
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true; // Oculta caracteres por padrão.

            // txtLogin
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtLogin.Location = new System.Drawing.Point(412, 113); // Campo de entrada do login.
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(228, 27);
            this.txtLogin.TabIndex = 1;

            // btnFirstAcess
            this.btnFirstAcess.BackColor = System.Drawing.Color.Red; // Cor de destaque secundário.
            this.btnFirstAcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstAcess.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnFirstAcess.Location = new System.Drawing.Point(393, 309); // Posição do botão primeiro acesso.
            this.btnFirstAcess.Name = "btnFirstAcess";
            this.btnFirstAcess.Size = new System.Drawing.Size(247, 50); // Botão largo para chamar atenção.
            this.btnFirstAcess.TabIndex = 5;
            this.btnFirstAcess.Text = "Primeiro Acesso ?"; // Rota para fluxo de registro/primeiro acesso.
            this.btnFirstAcess.UseVisualStyleBackColor = false;
            this.btnFirstAcess.Click += new System.EventHandler(this.btnFirstAcess_Click); // Abre formulário de primeiro acesso.

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F);
            this.label4.Location = new System.Drawing.Point(277, 9); // Posição do título do formulário.
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "TONY | TI - LOGIN"; // Título exibido ao usuário.
            this.label4.Click += new System.EventHandler(this.label4_Click); // Evento opcional associado.

            // btnForgotPass
            this.btnForgotPass.BackColor = System.Drawing.Color.Transparent; // Aparência de link.
            this.btnForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPass.FlatAppearance.BorderSize = 0; // Remove borda para parecer link.
            this.btnForgotPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline);
            this.btnForgotPass.ForeColor = System.Drawing.SystemColors.Highlight; // Cor de link.
            this.btnForgotPass.Location = new System.Drawing.Point(421, 366); // Posição do link "Esqueci Senha".
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(189, 38);
            this.btnForgotPass.TabIndex = 6;
            this.btnForgotPass.Text = "Esqueci Senha"; // Acessa fluxo de recuperação de senha.
            this.btnForgotPass.UseVisualStyleBackColor = false;
            this.btnForgotPass.Click += new System.EventHandler(this.btnForgotPass_Click); // Abre fluxo de recuperação.

            // viewPass
            this.viewPass.Cursor = System.Windows.Forms.Cursors.Hand; // Indica que pode ser clicado/pressionado.
            this.viewPass.Image = global::TonyTI_Login.Properties.Resources.hiddenPass; // Ícone padrão oculto.
            this.viewPass.Location = new System.Drawing.Point(648, 160); // Ícone ao lado do campo de senha.
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(20, 20);
            this.viewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.viewPass.TabIndex = 15;
            this.viewPass.TabStop = false;
            this.viewPass.Click += new System.EventHandler(this.viewPass_Click); // Alterna visibilidade da senha.
            this.viewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewPass_MouseDown); // Mostra senha enquanto pressionado.
            this.viewPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewPass_MouseUp); // Oculta ao soltar.

            // pictureBox4
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image"))); // Ícone auxiliar.
            this.pictureBox4.Location = new System.Drawing.Point(291, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;

            // pictureBox3
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image"))); // Ícone auxiliar.
            this.pictureBox3.Location = new System.Drawing.Point(290, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;

            // pictureBox2
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image"))); // Ícone do cabeçalho.
            this.pictureBox2.Location = new System.Drawing.Point(228, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;

            // pictureBox1
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image"))); // Imagem lateral ilustrativa.
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click); // Evento opcional associado.

            // Login (form)
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Define escala de DPI.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace; // Cor de fundo do formulário.
            this.ClientSize = new System.Drawing.Size(800, 494); // Tamanho inicial da janela.
            this.Controls.Add(this.viewPass); // Adiciona ícone de visualizar senha.
            this.Controls.Add(this.pictureBox4); // Adiciona ícone auxiliar.
            this.Controls.Add(this.pictureBox3); // Adiciona ícone auxiliar.
            this.Controls.Add(this.btnForgotPass); // Adiciona botão esqueci senha.
            this.Controls.Add(this.pictureBox2); // Adiciona ícone do cabeçalho.
            this.Controls.Add(this.label4); // Adiciona título.
            this.Controls.Add(this.btnFirstAcess); // Adiciona botão primeiro acesso.
            this.Controls.Add(this.txtLogin); // Adiciona campo login.
            this.Controls.Add(this.txtPassword); // Adiciona campo senha.
            this.Controls.Add(this.lblPassword); // Adiciona label senha.
            this.Controls.Add(this.lblLogin); // Adiciona label login.
            this.Controls.Add(this.btnLogin); // Adiciona botão entrar.
            this.Controls.Add(this.btnExit); // Adiciona botão sair.
            this.Controls.Add(this.pictureBox1); // Adiciona imagem lateral.
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow; // Janela com borda fixa.
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centraliza janela ao abrir.
            this.Text = "Tony Ti | Login"; // Texto do título da janela.
            this.Load += new System.EventHandler(this.Form1_Load); // Evento de inicialização do formulário.
            ((System.ComponentModel.ISupportInitialize)(this.viewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout(); // Retoma layout e aplica ajustes finais.
        }

        #endregion

        // Campos privados que representam controles visuais no formulário.
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnFirstAcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnForgotPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox viewPass;
    }
}
