namespace TonyTI_Login.Apresentacao
{
    partial class Chamados
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvChamados = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoLoginDataSet = new TonyTI_Login.ProjetoLoginDataSet();
            this.chamadosTableAdapter = new TonyTI_Login.ProjetoLoginDataSetTableAdapters.ChamadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamados
            // 
            this.dgvChamados.AllowUserToDeleteRows = false;
            this.dgvChamados.AutoGenerateColumns = false;
            this.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.urgenciaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataAberturaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvChamados.DataSource = this.chamadosBindingSource;
            this.dgvChamados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamados.Location = new System.Drawing.Point(0, 0);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.ReadOnly = true;
            this.dgvChamados.RowHeadersWidth = 51;
            this.dgvChamados.RowTemplate.Height = 24;
            this.dgvChamados.Size = new System.Drawing.Size(563, 345);
            this.dgvChamados.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // urgenciaDataGridViewTextBoxColumn
            // 
            this.urgenciaDataGridViewTextBoxColumn.DataPropertyName = "Urgencia";
            this.urgenciaDataGridViewTextBoxColumn.HeaderText = "Urgencia";
            this.urgenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urgenciaDataGridViewTextBoxColumn.Name = "urgenciaDataGridViewTextBoxColumn";
            this.urgenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.urgenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataAberturaDataGridViewTextBoxColumn
            // 
            this.dataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.HeaderText = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAberturaDataGridViewTextBoxColumn.Name = "dataAberturaDataGridViewTextBoxColumn";
            this.dataAberturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAberturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // chamadosBindingSource
            // 
            this.chamadosBindingSource.DataMember = "Chamados";
            this.chamadosBindingSource.DataSource = this.projetoLoginDataSet;
            // 
            // projetoLoginDataSet
            // 
            this.projetoLoginDataSet.DataSetName = "ProjetoLoginDataSet";
            this.projetoLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chamadosTableAdapter
            // 
            this.chamadosTableAdapter.ClearBeforeFill = true;
            // 
            // Chamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvChamados);
            this.Name = "Chamados";
            this.Size = new System.Drawing.Size(563, 345);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chamadosBindingSource;
        private ProjetoLoginDataSet projetoLoginDataSet;
        private ProjetoLoginDataSetTableAdapters.ChamadosTableAdapter chamadosTableAdapter;
    }
}
