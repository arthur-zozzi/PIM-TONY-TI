namespace TonyTI_Login.Apresentacao
{
    partial class ContatoCliente
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

        #region Código gerado pelo Designer de Componentes

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvChamados = new System.Windows.Forms.DataGridView();
            this.pnlDetalhes = new System.Windows.Forms.Panel();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnAbrirAnexo = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblDescricaoTitulo = new System.Windows.Forms.Label();
            this.lblEmailClienteTitulo = new System.Windows.Forms.Label();
            this.lblNomeClienteTitulo = new System.Windows.Forms.Label();
            this.lblIdChamado = new System.Windows.Forms.Label();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.lblTituloDetalhes = new System.Windows.Forms.Label();
            this.pnlResposta = new System.Windows.Forms.Panel();
            this.btnEnviarResposta = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblRespostaTitulo = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            this.pnlDetalhes.SuspendLayout();
            this.pnlResposta.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvChamados
            // 
            this.dgvChamados.AllowUserToAddRows = false;
            this.dgvChamados.AllowUserToDeleteRows = false;
            this.dgvChamados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamados.Location = new System.Drawing.Point(0, 0);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.ReadOnly = true;
            this.dgvChamados.RowHeadersVisible = false;
            this.dgvChamados.RowTemplate.Height = 24;
            this.dgvChamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamados.Size = new System.Drawing.Size(770, 230);
            this.dgvChamados.TabIndex = 0;

            // 
            // pnlDetalhes
            // 
            this.pnlDetalhes.Controls.Add(this.btnResponder);
            this.pnlDetalhes.Controls.Add(this.btnAbrirAnexo);
            this.pnlDetalhes.Controls.Add(this.txtDescricao);
            this.pnlDetalhes.Controls.Add(this.txtEmailCliente);
            this.pnlDetalhes.Controls.Add(this.txtNomeCliente);
            this.pnlDetalhes.Controls.Add(this.lblDescricaoTitulo);
            this.pnlDetalhes.Controls.Add(this.lblEmailClienteTitulo);
            this.pnlDetalhes.Controls.Add(this.lblNomeClienteTitulo);
            this.pnlDetalhes.Controls.Add(this.lblIdChamado);
            this.pnlDetalhes.Controls.Add(this.lblIdTitulo);
            this.pnlDetalhes.Controls.Add(this.lblTituloDetalhes);
            this.pnlDetalhes.Location = new System.Drawing.Point(3, 236);
            this.pnlDetalhes.Name = "pnlDetalhes";
            this.pnlDetalhes.Size = new System.Drawing.Size(766, 340);
            this.pnlDetalhes.TabIndex = 1;
            this.pnlDetalhes.Visible = false;

            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(600, 280);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(150, 40);
            this.btnResponder.TabIndex = 10;
            this.btnResponder.Text = "Responder Chamado";
            this.btnResponder.UseVisualStyleBackColor = true;

            // 
            // btnAbrirAnexo
            // 
            this.btnAbrirAnexo.Location = new System.Drawing.Point(25, 280);
            this.btnAbrirAnexo.Name = "btnAbrirAnexo";
            this.btnAbrirAnexo.Size = new System.Drawing.Size(150, 40);
            this.btnAbrirAnexo.TabIndex = 9;
            this.btnAbrirAnexo.Text = "Abrir Anexo";
            this.btnAbrirAnexo.UseVisualStyleBackColor = true;

            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(29, 210);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(721, 60);
            this.txtDescricao.TabIndex = 8;

            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(200, 170);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.ReadOnly = true;
            this.txtEmailCliente.Size = new System.Drawing.Size(300, 22);
            this.txtEmailCliente.TabIndex = 7;

            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(200, 130);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(300, 22);
            this.txtNomeCliente.TabIndex = 6;

            // 
            // lblDescricaoTitulo
            // 
            this.lblDescricaoTitulo.AutoSize = true;
            this.lblDescricaoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescricaoTitulo.Location = new System.Drawing.Point(25, 190);
            this.lblDescricaoTitulo.Name = "lblDescricaoTitulo";
            this.lblDescricaoTitulo.Size = new System.Drawing.Size(186, 19);
            this.lblDescricaoTitulo.TabIndex = 5;
            this.lblDescricaoTitulo.Text = "Descrição do Chamado:";

            // 
            // lblEmailClienteTitulo
            // 
            this.lblEmailClienteTitulo.AutoSize = true;
            this.lblEmailClienteTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailClienteTitulo.Location = new System.Drawing.Point(25, 170);
            this.lblEmailClienteTitulo.Name = "lblEmailClienteTitulo";
            this.lblEmailClienteTitulo.Size = new System.Drawing.Size(138, 19);
            this.lblEmailClienteTitulo.TabIndex = 4;
            this.lblEmailClienteTitulo.Text = "E-mail do Cliente:";

            // 
            // lblNomeClienteTitulo
            // 
            this.lblNomeClienteTitulo.AutoSize = true;
            this.lblNomeClienteTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNomeClienteTitulo.Location = new System.Drawing.Point(25, 130);
            this.lblNomeClienteTitulo.Name = "lblNomeClienteTitulo";
            this.lblNomeClienteTitulo.Size = new System.Drawing.Size(133, 19);
            this.lblNomeClienteTitulo.TabIndex = 3;
            this.lblNomeClienteTitulo.Text = "Nome do Cliente:";

            // 
            // lblIdChamado
            // 
            this.lblIdChamado.AutoSize = true;
            this.lblIdChamado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIdChamado.Location = new System.Drawing.Point(110, 95);
            this.lblIdChamado.Name = "lblIdChamado";
            this.lblIdChamado.Size = new System.Drawing.Size(0, 19);
            this.lblIdChamado.TabIndex = 2;

            // 
            // lblIdTitulo
            // 
            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdTitulo.Location = new System.Drawing.Point(25, 95);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Size = new System.Drawing.Size(63, 19);
            this.lblIdTitulo.TabIndex = 1;
            this.lblIdTitulo.Text = "Código:";

            // 
            // lblTituloDetalhes
            // 
            this.lblTituloDetalhes.AutoSize = true;
            this.lblTituloDetalhes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloDetalhes.Location = new System.Drawing.Point(25, 20);
            this.lblTituloDetalhes.Name = "lblTituloDetalhes";
            this.lblTituloDetalhes.Size = new System.Drawing.Size(277, 21);
            this.lblTituloDetalhes.TabIndex = 0;
            this.lblTituloDetalhes.Text = "Detalhes do Chamado Selecionado:";

            // 
            // pnlResposta
            // 
            this.pnlResposta.Controls.Add(this.btnEnviarResposta);
            this.pnlResposta.Controls.Add(this.txtResposta);
            this.pnlResposta.Controls.Add(this.lblRespostaTitulo);
            this.pnlResposta.Location = new System.Drawing.Point(3, 582);
            this.pnlResposta.Name = "pnlResposta";
            this.pnlResposta.Size = new System.Drawing.Size(766, 180);
            this.pnlResposta.TabIndex = 2;
            this.pnlResposta.Visible = false;

            // 
            // lblRespostaTitulo
            // 
            this.lblRespostaTitulo.AutoSize = true;
            this.lblRespostaTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRespostaTitulo.Location = new System.Drawing.Point(25, 15);
            this.lblRespostaTitulo.Name = "lblRespostaTitulo";
            this.lblRespostaTitulo.Size = new System.Drawing.Size(157, 19);
            this.lblRespostaTitulo.TabIndex = 0;
            this.lblRespostaTitulo.Text = "Resposta do Técnico:";

            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(29, 40);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.ReadOnly = false;
            this.txtResposta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResposta.Size = new System.Drawing.Size(720, 90);
            this.txtResposta.TabIndex = 1;

            // 
            // btnEnviarResposta
            // 
            this.btnEnviarResposta.Location = new System.Drawing.Point(600, 135);
            this.btnEnviarResposta.Name = "btnEnviarResposta";
            this.btnEnviarResposta.Size = new System.Drawing.Size(150, 35);
            this.btnEnviarResposta.TabIndex = 2;
            this.btnEnviarResposta.Text = "Enviar Resposta";
            this.btnEnviarResposta.UseVisualStyleBackColor = true;

            // 
            // ContatoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlResposta);
            this.Controls.Add(this.pnlDetalhes);
            this.Controls.Add(this.dgvChamados);
            this.Name = "ContatoCliente";
            this.Size = new System.Drawing.Size(778, 770);

            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).EndInit();
            this.pnlDetalhes.ResumeLayout(false);
            this.pnlDetalhes.PerformLayout();
            this.pnlResposta.ResumeLayout(false);
            this.pnlResposta.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamados;
        private System.Windows.Forms.Panel pnlDetalhes;
        private System.Windows.Forms.Panel pnlResposta;
        private System.Windows.Forms.Label lblTituloDetalhes;
        private System.Windows.Forms.Label lblIdTitulo;
        private System.Windows.Forms.Label lblIdChamado;
        private System.Windows.Forms.Label lblNomeClienteTitulo;
        private System.Windows.Forms.Label lblEmailClienteTitulo;
        private System.Windows.Forms.Label lblDescricaoTitulo;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnAbrirAnexo;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblRespostaTitulo;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnEnviarResposta;
    }
}
