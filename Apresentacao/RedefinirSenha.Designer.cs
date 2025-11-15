namespace TonyTI_Login.Apresentacao
{
    partial class RedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenha));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.viewNewPass = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.viewConfirmPass = new System.Windows.Forms.PictureBox();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConfirmPass)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "TONY | TI - ALTERE SUA SENHA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(136, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // viewNewPass
            // 
            this.viewNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewNewPass.Image = global::TonyTI_Login.Properties.Resources.hiddenPass;
            this.viewNewPass.Location = new System.Drawing.Point(755, 154);
            this.viewNewPass.Name = "viewNewPass";
            this.viewNewPass.Size = new System.Drawing.Size(20, 20);
            this.viewNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.viewNewPass.TabIndex = 20;
            this.viewNewPass.TabStop = false;
            this.viewNewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewNewPass_MouseDown);
            this.viewNewPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewNewPass_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(291, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(521, 153);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(228, 27);
            this.txtNewPassword.TabIndex = 17;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(332, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(158, 26);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "NOVA SENHA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "CONFIRMAR SENHA:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(521, 248);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(228, 27);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(293, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // viewConfirmPass
            // 
            this.viewConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewConfirmPass.Image = global::TonyTI_Login.Properties.Resources.hiddenPass;
            this.viewConfirmPass.Location = new System.Drawing.Point(757, 249);
            this.viewConfirmPass.Name = "viewConfirmPass";
            this.viewConfirmPass.Size = new System.Drawing.Size(20, 20);
            this.viewConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.viewConfirmPass.TabIndex = 20;
            this.viewConfirmPass.TabStop = false;
            this.viewConfirmPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewConfirmPass_MouseDown);
            this.viewConfirmPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewConfirmPass_MouseUp);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.Lime;
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenha.Location = new System.Drawing.Point(396, 329);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(229, 45);
            this.btnAlterarSenha.TabIndex = 21;
            this.btnAlterarSenha.Text = "ALTERAR SENHA";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click_1);
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(206, 191);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(10, 30);
            this.email.TabIndex = 23;
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.viewConfirmPass);
            this.Controls.Add(this.viewNewPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Name = "RedefinirSenha";
            this.Text = "RedefinirSenha";
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