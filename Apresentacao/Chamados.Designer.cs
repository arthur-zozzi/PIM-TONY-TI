namespace TonyTI_Login.Apresentacao
{
    partial class Chamados
    {
        // Armazena componentes gerenciados pelo designer; liberados no Dispose.
        private System.ComponentModel.IContainer components = null;

        // Libera recursos usados pelo componente; executado ao descartar a instância.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Libera componentes criados pelo designer.
            }
            base.Dispose(disposing); // Executa Dispose da classe base.
        }

        #region Código gerado pelo Designer de Componentes

        // Inicializa controles visuais e vinculadores de dados; gerado pelo Designer.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container(); // Contêiner para componentes não visuais.
            this.dgvChamados = new System.Windows.Forms.DataGridView(); // Grade que lista chamados.
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna Id.
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna Nome.
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna Email.
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna Telefone.
            this.urgenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna Urgencia.
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna Descricao.
            this.dataAberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna DataAbertura.
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Coluna Status.
            this.chamadosBindingSource = new System.Windows.Forms.BindingSource(this.components); // BindingSource para dados.
            this.projetoLoginDataSet = new TonyTI_Login.ProjetoLoginDataSet(); // DataSet gerado para o projeto.
            this.chamadosTableAdapter = new TonyTI_Login.ProjetoLoginDataSetTableAdapters.ChamadosTableAdapter(); // TableAdapter para CRUD.

            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).BeginInit();
            this.SuspendLayout(); // Suspende layout enquanto configura controles.

            // 
            // dgvChamados
            // 
            // Configura a DataGridView para exibir a lista de chamados; leitura apenas.
            this.dgvChamados.AllowUserToDeleteRows = false;
            this.dgvChamados.AutoGenerateColumns = false; // Usa colunas definidas manualmente.
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
            this.dgvChamados.DataSource = this.chamadosBindingSource; // Vincula a fonte de dados.
            this.dgvChamados.Dock = System.Windows.Forms.DockStyle.Fill; // Ocupa todo o espaço do controle pai.
            this.dgvChamados.Location = new System.Drawing.Point(0, 0);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.ReadOnly = true; // Evita edição direta na grade.
            this.dgvChamados.RowHeadersWidth = 51;
            this.dgvChamados.RowTemplate.Height = 24;
            this.dgvChamados.Size = new System.Drawing.Size(563, 345);
            this.dgvChamados.TabIndex = 0;

            // 
            // idDataGridViewTextBoxColumn
            // 
            // Coluna que exibe o identificador do chamado.
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;

            // 
            // nomeDataGridViewTextBoxColumn
            // 
            // Coluna que exibe o nome do solicitante.
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;

            // 
            // emailDataGridViewTextBoxColumn
            // 
            // Coluna que exibe o e-mail do solicitante.
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;

            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            // Coluna que exibe telefone de contato.
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;

            // 
            // urgenciaDataGridViewTextBoxColumn
            // 
            // Coluna que exibe nível de urgência do chamado.
            this.urgenciaDataGridViewTextBoxColumn.DataPropertyName = "Urgencia";
            this.urgenciaDataGridViewTextBoxColumn.HeaderText = "Urgencia";
            this.urgenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urgenciaDataGridViewTextBoxColumn.Name = "urgenciaDataGridViewTextBoxColumn";
            this.urgenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.urgenciaDataGridViewTextBoxColumn.Width = 125;

            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            // Coluna que exibe resumo da descrição do problema.
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 125;

            // 
            // dataAberturaDataGridViewTextBoxColumn
            // 
            // Coluna que exibe data/hora de abertura.
            this.dataAberturaDataGridViewTextBoxColumn.DataPropertyName = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.HeaderText = "DataAbertura";
            this.dataAberturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAberturaDataGridViewTextBoxColumn.Name = "dataAberturaDataGridViewTextBoxColumn";
            this.dataAberturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAberturaDataGridViewTextBoxColumn.Width = 125;

            // 
            // statusDataGridViewTextBoxColumn
            // 
            // Coluna que exibe o status atual do chamado.
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;

            // 
            // chamadosBindingSource
            // 
            // Vincula a tabela 'Chamados' do DataSet ao BindingSource.
            this.chamadosBindingSource.DataMember = "Chamados";
            this.chamadosBindingSource.DataSource = this.projetoLoginDataSet;

            // 
            // projetoLoginDataSet
            // 
            // Instância do DataSet gerado a partir do banco de dados.
            this.projetoLoginDataSet.DataSetName = "ProjetoLoginDataSet";
            this.projetoLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // 
            // chamadosTableAdapter
            // 
            // TableAdapter responsável por preencher e persistir dados da tabela Chamados.
            this.chamadosTableAdapter.ClearBeforeFill = true;

            // 
            // Chamados (controle)
            // 
            // Configurações finais do componente de listagem de chamados.
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); // Dimensões padrões de escala.
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvChamados); // Adiciona DataGridView ao controle.
            this.Name = "Chamados";
            this.Size = new System.Drawing.Size(563, 345); // Tamanho padrão do controle.

            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSet)).EndInit();
            this.ResumeLayout(false); // Restaura layout.
        }

        #endregion

        // Campos privados que representam controles visuais e de dados.
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
