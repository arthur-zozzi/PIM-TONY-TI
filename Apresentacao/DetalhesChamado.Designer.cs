namespace TonyTI_Login.Apresentacao
{
    partial class DetalhesChamado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblUrgencia = new System.Windows.Forms.Label();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtRespostaTecnico = new System.Windows.Forms.TextBox();
            this.btnResolvido = new System.Windows.Forms.Button();
            this.btnNaoResolvido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(23, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalhes do Chamado";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(23, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(91, 23);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código: —";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNome.Location = new System.Drawing.Point(23, 91);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome: —";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(23, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail: —";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelefone.Location = new System.Drawing.Point(23, 144);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(99, 23);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone: —";
            // 
            // lblUrgencia
            // 
            this.lblUrgencia.AutoSize = true;
            this.lblUrgencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUrgencia.Location = new System.Drawing.Point(23, 171);
            this.lblUrgencia.Name = "lblUrgencia";
            this.lblUrgencia.Size = new System.Drawing.Size(104, 23);
            this.lblUrgencia.TabIndex = 5;
            this.lblUrgencia.Text = "Urgência: —";
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDataAbertura.Location = new System.Drawing.Point(23, 197);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(103, 23);
            this.lblDataAbertura.TabIndex = 6;
            this.lblDataAbertura.Text = "Abertura: —";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(23, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 23);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: —";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(27, 290);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(571, 106);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtRespostaTecnico
            // 
            this.txtRespostaTecnico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRespostaTecnico.Location = new System.Drawing.Point(27, 441);
            this.txtRespostaTecnico.Multiline = true;
            this.txtRespostaTecnico.Name = "txtRespostaTecnico";
            this.txtRespostaTecnico.ReadOnly = true;
            this.txtRespostaTecnico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespostaTecnico.Size = new System.Drawing.Size(571, 106);
            this.txtRespostaTecnico.TabIndex = 9;
            // 
            // btnResolvido
            // 
            this.btnResolvido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResolvido.Location = new System.Drawing.Point(27, 565);
            this.btnResolvido.Name = "btnResolvido";
            this.btnResolvido.Size = new System.Drawing.Size(229, 37);
            this.btnResolvido.TabIndex = 10;
            this.btnResolvido.Text = "Marcar como Resolvido";
            this.btnResolvido.UseVisualStyleBackColor = true;
            this.btnResolvido.Click += new System.EventHandler(this.btnResolvido_Click);
            // 
            // btnNaoResolvido
            // 
            this.btnNaoResolvido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNaoResolvido.Location = new System.Drawing.Point(369, 565);
            this.btnNaoResolvido.Name = "btnNaoResolvido";
            this.btnNaoResolvido.Size = new System.Drawing.Size(229, 37);
            this.btnNaoResolvido.TabIndex = 11;
            this.btnNaoResolvido.Text = "Não Resolvido";
            this.btnNaoResolvido.UseVisualStyleBackColor = true;
            this.btnNaoResolvido.Click += new System.EventHandler(this.btnNaoResolvido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(24, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descrição do Problema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(25, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Resposta do Técnico:";
            // 
            // DetalhesChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNaoResolvido);
            this.Controls.Add(this.btnResolvido);
            this.Controls.Add(this.txtRespostaTecnico);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataAbertura);
            this.Controls.Add(this.lblUrgencia);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalhesChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Chamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
