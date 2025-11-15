namespace TonyTI_Login.Apresentacao
{
    partial class SenhaRecover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenhaRecover));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailRec = new System.Windows.Forms.TextBox();
            this.btnPassRecover = new System.Windows.Forms.Button();
            this.lblPassRec = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.panelRec = new System.Windows.Forms.Panel();
            this.btnValidarCodigo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRec = new System.Windows.Forms.Label();
            this.timerRec = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEmail.SuspendLayout();
            this.panelRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "TONY | TI - RESETAR SENHA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Digite seu E-mail cadastrado:";
            // 
            // txtEmailRec
            // 
            this.txtEmailRec.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRec.Location = new System.Drawing.Point(40, 60);
            this.txtEmailRec.Name = "txtEmailRec";
            this.txtEmailRec.Size = new System.Drawing.Size(344, 34);
            this.txtEmailRec.TabIndex = 16;
            this.txtEmailRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPassRecover
            // 
            this.btnPassRecover.BackColor = System.Drawing.Color.Lime;
            this.btnPassRecover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassRecover.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassRecover.Location = new System.Drawing.Point(106, 130);
            this.btnPassRecover.Name = "btnPassRecover";
            this.btnPassRecover.Size = new System.Drawing.Size(230, 45);
            this.btnPassRecover.TabIndex = 17;
            this.btnPassRecover.Text = "ENVIAR CÓDIGO";
            this.btnPassRecover.UseVisualStyleBackColor = false;
            this.btnPassRecover.Click += new System.EventHandler(this.btnPassRecover_Click);
            // 
            // lblPassRec
            // 
            this.lblPassRec.AutoSize = true;
            this.lblPassRec.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassRec.Location = new System.Drawing.Point(37, 190);
            this.lblPassRec.Name = "lblPassRec";
            this.lblPassRec.Size = new System.Drawing.Size(353, 37);
            this.lblPassRec.TabIndex = 18;
            this.lblPassRec.Text = "Reenviar código em: 0:30";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(40, 97);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 23);
            this.lblMensagem.TabIndex = 19;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.label1);
            this.panelEmail.Controls.Add(this.lblMensagem);
            this.panelEmail.Controls.Add(this.txtEmailRec);
            this.panelEmail.Controls.Add(this.lblPassRec);
            this.panelEmail.Controls.Add(this.btnPassRecover);
            this.panelEmail.Location = new System.Drawing.Point(282, 84);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(473, 323);
            this.panelEmail.TabIndex = 20;
            // 
            // panelRec
            // 
            this.panelRec.Controls.Add(this.btnValidarCodigo);
            this.panelRec.Controls.Add(this.txtCodigo);
            this.panelRec.Controls.Add(this.lblRec);
            this.panelRec.Location = new System.Drawing.Point(282, 84);
            this.panelRec.Name = "panelRec";
            this.panelRec.Size = new System.Drawing.Size(470, 320);
            this.panelRec.TabIndex = 20;
            this.panelRec.Visible = false;
            // 
            // btnValidarCodigo
            // 
            this.btnValidarCodigo.BackColor = System.Drawing.Color.Chartreuse;
            this.btnValidarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarCodigo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarCodigo.Location = new System.Drawing.Point(143, 140);
            this.btnValidarCodigo.Name = "btnValidarCodigo";
            this.btnValidarCodigo.Size = new System.Drawing.Size(128, 47);
            this.btnValidarCodigo.TabIndex = 2;
            this.btnValidarCodigo.Text = "Validar Código";
            this.btnValidarCodigo.UseVisualStyleBackColor = false;
            this.btnValidarCodigo.Click += new System.EventHandler(this.btnValidarCodigo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(88, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(248, 39);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.BackColor = System.Drawing.Color.Transparent;
            this.lblRec.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRec.Location = new System.Drawing.Point(31, 25);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(370, 33);
            this.lblRec.TabIndex = 0;
            this.lblRec.Text = "Insira o código de Recuperação:";
            // 
            // SenhaRecover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRec);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Name = "SenhaRecover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenhaRecover";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelRec.ResumeLayout(false);
            this.panelRec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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