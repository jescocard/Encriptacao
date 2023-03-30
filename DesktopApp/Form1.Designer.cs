namespace DesktopApp
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelPathAspNetRegiis;
            this.labelPathArquivoConfig = new System.Windows.Forms.Label();
            this.PathArquivoConfig = new System.Windows.Forms.TextBox();
            this.PathAspNetRegiis = new System.Windows.Forms.TextBox();
            this.buscadorDePastaAspNetRegiis = new System.Windows.Forms.FolderBrowserDialog();
            this.buscadorDePastaArquivoConfig = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Criptografar = new System.Windows.Forms.CheckBox();
            this.Replace = new System.Windows.Forms.CheckBox();
            this.Descriptografar = new System.Windows.Forms.CheckBox();
            this.replaceBox = new System.Windows.Forms.GroupBox();
            this.botaoRemoverGrid = new System.Windows.Forms.Button();
            this.replaceGrid = new System.Windows.Forms.DataGridView();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.novoValor = new System.Windows.Forms.TextBox();
            this.novoValorLabel = new System.Windows.Forms.Label();
            this.valorAtual = new System.Windows.Forms.TextBox();
            this.valorAtualLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ColunaValorAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNovoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            labelPathAspNetRegiis = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.replaceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPathAspNetRegiis
            // 
            labelPathAspNetRegiis.AutoSize = true;
            labelPathAspNetRegiis.Location = new System.Drawing.Point(10, 24);
            labelPathAspNetRegiis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelPathAspNetRegiis.Name = "labelPathAspNetRegiis";
            labelPathAspNetRegiis.Size = new System.Drawing.Size(96, 13);
            labelPathAspNetRegiis.TabIndex = 0;
            labelPathAspNetRegiis.Text = "PathAspNetRegiis:";
            labelPathAspNetRegiis.Click += new System.EventHandler(this.labelPathAspNetRegiis_Click);
            // 
            // labelPathArquivoConfig
            // 
            this.labelPathArquivoConfig.AutoSize = true;
            this.labelPathArquivoConfig.Location = new System.Drawing.Point(10, 50);
            this.labelPathArquivoConfig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPathArquivoConfig.Name = "labelPathArquivoConfig";
            this.labelPathArquivoConfig.Size = new System.Drawing.Size(98, 13);
            this.labelPathArquivoConfig.TabIndex = 1;
            this.labelPathArquivoConfig.Text = "PathArquivoConfig:";
            this.labelPathArquivoConfig.Click += new System.EventHandler(this.labelPathArquivoConfig_Click);
            // 
            // PathArquivoConfig
            // 
            this.PathArquivoConfig.Location = new System.Drawing.Point(106, 50);
            this.PathArquivoConfig.Margin = new System.Windows.Forms.Padding(2);
            this.PathArquivoConfig.Name = "PathArquivoConfig";
            this.PathArquivoConfig.ReadOnly = true;
            this.PathArquivoConfig.Size = new System.Drawing.Size(486, 20);
            this.PathArquivoConfig.TabIndex = 2;
            this.PathArquivoConfig.Click += new System.EventHandler(this.PathArquivoConfig_Click);
            // 
            // PathAspNetRegiis
            // 
            this.PathAspNetRegiis.Location = new System.Drawing.Point(106, 24);
            this.PathAspNetRegiis.Margin = new System.Windows.Forms.Padding(2);
            this.PathAspNetRegiis.Name = "PathAspNetRegiis";
            this.PathAspNetRegiis.ReadOnly = true;
            this.PathAspNetRegiis.Size = new System.Drawing.Size(486, 20);
            this.PathAspNetRegiis.TabIndex = 3;
            this.PathAspNetRegiis.Click += new System.EventHandler(this.PathAspNetRegiis_Click);
            // 
            // buscadorDePastaAspNetRegiis
            // 
            this.buscadorDePastaAspNetRegiis.ShowNewFolderButton = false;
            this.buscadorDePastaAspNetRegiis.HelpRequest += new System.EventHandler(this.buscadorDePastaAspNetRegiis_HelpRequest);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Criptografar);
            this.groupBox1.Controls.Add(this.Replace);
            this.groupBox1.Controls.Add(this.Descriptografar);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(455, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funções";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Criptografar
            // 
            this.Criptografar.AutoSize = true;
            this.Criptografar.Location = new System.Drawing.Point(331, 17);
            this.Criptografar.Margin = new System.Windows.Forms.Padding(2);
            this.Criptografar.Name = "Criptografar";
            this.Criptografar.Size = new System.Drawing.Size(80, 17);
            this.Criptografar.TabIndex = 2;
            this.Criptografar.Text = "Criptografar";
            this.Criptografar.UseVisualStyleBackColor = true;
            // 
            // Replace
            // 
            this.Replace.AutoSize = true;
            this.Replace.Location = new System.Drawing.Point(196, 17);
            this.Replace.Margin = new System.Windows.Forms.Padding(2);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(66, 17);
            this.Replace.TabIndex = 1;
            this.Replace.Text = "Replace";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.CheckedChanged += new System.EventHandler(this.Replace_CheckedChanged);
            // 
            // Descriptografar
            // 
            this.Descriptografar.AutoSize = true;
            this.Descriptografar.Location = new System.Drawing.Point(26, 17);
            this.Descriptografar.Margin = new System.Windows.Forms.Padding(2);
            this.Descriptografar.Name = "Descriptografar";
            this.Descriptografar.Size = new System.Drawing.Size(98, 17);
            this.Descriptografar.TabIndex = 0;
            this.Descriptografar.Text = "Descriptografar";
            this.Descriptografar.UseVisualStyleBackColor = true;
            // 
            // replaceBox
            // 
            this.replaceBox.Controls.Add(this.botaoRemoverGrid);
            this.replaceBox.Controls.Add(this.replaceGrid);
            this.replaceBox.Controls.Add(this.adicionarButton);
            this.replaceBox.Controls.Add(this.novoValor);
            this.replaceBox.Controls.Add(this.novoValorLabel);
            this.replaceBox.Controls.Add(this.valorAtual);
            this.replaceBox.Controls.Add(this.valorAtualLabel);
            this.replaceBox.Location = new System.Drawing.Point(12, 136);
            this.replaceBox.Margin = new System.Windows.Forms.Padding(2);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Padding = new System.Windows.Forms.Padding(2);
            this.replaceBox.Size = new System.Drawing.Size(579, 219);
            this.replaceBox.TabIndex = 5;
            this.replaceBox.TabStop = false;
            this.replaceBox.Text = "Replace";
            this.replaceBox.Visible = false;
            this.replaceBox.Enter += new System.EventHandler(this.replaceBox_Enter);
            // 
            // botaoRemoverGrid
            // 
            this.botaoRemoverGrid.Location = new System.Drawing.Point(469, 28);
            this.botaoRemoverGrid.Name = "botaoRemoverGrid";
            this.botaoRemoverGrid.Size = new System.Drawing.Size(66, 19);
            this.botaoRemoverGrid.TabIndex = 6;
            this.botaoRemoverGrid.Text = "Remover";
            this.botaoRemoverGrid.UseVisualStyleBackColor = true;
            // 
            // replaceGrid
            // 
            this.replaceGrid.AllowUserToAddRows = false;
            this.replaceGrid.AllowUserToResizeColumns = false;
            this.replaceGrid.AllowUserToResizeRows = false;
            this.replaceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.replaceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaValorAtual,
            this.ColunaNovoValor,
            this.colunaCheckbox});
            this.replaceGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.replaceGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.replaceGrid.Location = new System.Drawing.Point(35, 67);
            this.replaceGrid.Margin = new System.Windows.Forms.Padding(2);
            this.replaceGrid.Name = "replaceGrid";
            this.replaceGrid.RowHeadersVisible = false;
            this.replaceGrid.RowHeadersWidth = 51;
            this.replaceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.replaceGrid.RowTemplate.Height = 24;
            this.replaceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.replaceGrid.Size = new System.Drawing.Size(500, 122);
            this.replaceGrid.TabIndex = 5;
            this.replaceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(400, 28);
            this.adicionarButton.Margin = new System.Windows.Forms.Padding(2);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(64, 19);
            this.adicionarButton.TabIndex = 4;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // novoValor
            // 
            this.novoValor.Location = new System.Drawing.Point(270, 27);
            this.novoValor.Margin = new System.Windows.Forms.Padding(2);
            this.novoValor.Name = "novoValor";
            this.novoValor.Size = new System.Drawing.Size(126, 20);
            this.novoValor.TabIndex = 3;
            // 
            // novoValorLabel
            // 
            this.novoValorLabel.AutoSize = true;
            this.novoValorLabel.Location = new System.Drawing.Point(203, 30);
            this.novoValorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.novoValorLabel.Name = "novoValorLabel";
            this.novoValorLabel.Size = new System.Drawing.Size(63, 13);
            this.novoValorLabel.TabIndex = 2;
            this.novoValorLabel.Text = "Novo Valor:";
            this.novoValorLabel.Click += new System.EventHandler(this.novoValorLabel_Click);
            // 
            // valorAtual
            // 
            this.valorAtual.Location = new System.Drawing.Point(66, 26);
            this.valorAtual.Margin = new System.Windows.Forms.Padding(2);
            this.valorAtual.Name = "valorAtual";
            this.valorAtual.Size = new System.Drawing.Size(133, 20);
            this.valorAtual.TabIndex = 1;
            // 
            // valorAtualLabel
            // 
            this.valorAtualLabel.AutoSize = true;
            this.valorAtualLabel.Location = new System.Drawing.Point(4, 26);
            this.valorAtualLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valorAtualLabel.Name = "valorAtualLabel";
            this.valorAtualLabel.Size = new System.Drawing.Size(61, 13);
            this.valorAtualLabel.TabIndex = 0;
            this.valorAtualLabel.Text = "Valor Atual:";
            this.valorAtualLabel.Click += new System.EventHandler(this.valorAtualLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ColunaValorAtual
            // 
            this.ColunaValorAtual.HeaderText = "Valor Atual";
            this.ColunaValorAtual.MinimumWidth = 6;
            this.ColunaValorAtual.Name = "ColunaValorAtual";
            this.ColunaValorAtual.ReadOnly = true;
            this.ColunaValorAtual.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColunaValorAtual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColunaValorAtual.Width = 235;
            // 
            // ColunaNovoValor
            // 
            this.ColunaNovoValor.HeaderText = "Novo Valor";
            this.ColunaNovoValor.MinimumWidth = 6;
            this.ColunaNovoValor.Name = "ColunaNovoValor";
            this.ColunaNovoValor.ReadOnly = true;
            this.ColunaNovoValor.Width = 235;
            // 
            // colunaCheckbox
            // 
            this.colunaCheckbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaCheckbox.DataPropertyName = "Remover";
            this.colunaCheckbox.HeaderText = "";
            this.colunaCheckbox.Name = "colunaCheckbox";
            this.colunaCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colunaCheckbox.Width = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PathAspNetRegiis);
            this.Controls.Add(this.PathArquivoConfig);
            this.Controls.Add(this.labelPathArquivoConfig);
            this.Controls.Add(labelPathAspNetRegiis);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Encriptação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.replaceBox.ResumeLayout(false);
            this.replaceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replaceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPathArquivoConfig;
        private System.Windows.Forms.TextBox PathArquivoConfig;
        private System.Windows.Forms.TextBox PathAspNetRegiis;
        private System.Windows.Forms.FolderBrowserDialog buscadorDePastaAspNetRegiis;
        private System.Windows.Forms.FolderBrowserDialog buscadorDePastaArquivoConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Replace;
        private System.Windows.Forms.CheckBox Descriptografar;
        private System.Windows.Forms.CheckBox Criptografar;
        private System.Windows.Forms.GroupBox replaceBox;
        private System.Windows.Forms.TextBox valorAtual;
        private System.Windows.Forms.Label valorAtualLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label novoValorLabel;
        private System.Windows.Forms.DataGridView replaceGrid;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.TextBox novoValor;
        private System.Windows.Forms.Button botaoRemoverGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValorAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNovoValor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colunaCheckbox;
    }
}

