namespace TonyTI_Login.Apresentacao
{
    partial class Ajuda
    {
        private System.ComponentModel.IContainer components = null;

        #region Código gerado pelo Designer

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.btnEnviarPergunta = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblTitulo.Location = new System.Drawing.Point(392, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(455, 69);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AJUDA COM IA";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPergunta.Location = new System.Drawing.Point(40, 120);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(807, 63);
            this.txtPergunta.TabIndex = 1;
            // 
            // btnEnviarPergunta
            // 
            this.btnEnviarPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEnviarPergunta.Location = new System.Drawing.Point(704, 119);
            this.btnEnviarPergunta.Name = "btnEnviarPergunta";
            this.btnEnviarPergunta.Size = new System.Drawing.Size(200, 64);
            this.btnEnviarPergunta.TabIndex = 2;
            this.btnEnviarPergunta.Text = "PERGUNTAR";
            this.btnEnviarPergunta.UseVisualStyleBackColor = true;
            this.btnEnviarPergunta.Click += new System.EventHandler(this.btnEnviarPergunta_Click);
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtResposta.Location = new System.Drawing.Point(40, 240);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.ReadOnly = true;
            this.txtResposta.Size = new System.Drawing.Size(1222, 477);
            this.txtResposta.TabIndex = 3;
            // 
            // Ajuda
            // 
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.btnEnviarPergunta);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Ajuda";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Button btnEnviarPergunta;
        private System.Windows.Forms.TextBox txtResposta;
    }
}
