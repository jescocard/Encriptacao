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
            labelPathAspNetRegiis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPathAspNetRegiis
            // 
            labelPathAspNetRegiis.AutoSize = true;
            labelPathAspNetRegiis.Location = new System.Drawing.Point(13, 30);
            labelPathAspNetRegiis.Name = "labelPathAspNetRegiis";
            labelPathAspNetRegiis.Size = new System.Drawing.Size(121, 16);
            labelPathAspNetRegiis.TabIndex = 0;
            labelPathAspNetRegiis.Text = "PathAspNetRegiis:";
            labelPathAspNetRegiis.Click += new System.EventHandler(this.labelPathAspNetRegiis_Click);
            // 
            // labelPathArquivoConfig
            // 
            this.labelPathArquivoConfig.AutoSize = true;
            this.labelPathArquivoConfig.Location = new System.Drawing.Point(13, 61);
            this.labelPathArquivoConfig.Name = "labelPathArquivoConfig";
            this.labelPathArquivoConfig.Size = new System.Drawing.Size(121, 16);
            this.labelPathArquivoConfig.TabIndex = 1;
            this.labelPathArquivoConfig.Text = "PathArquivoConfig:";
            this.labelPathArquivoConfig.Click += new System.EventHandler(this.labelPathArquivoConfig_Click);
            // 
            // PathArquivoConfig
            // 
            this.PathArquivoConfig.Location = new System.Drawing.Point(141, 61);
            this.PathArquivoConfig.Name = "PathArquivoConfig";
            this.PathArquivoConfig.ReadOnly = true;
            this.PathArquivoConfig.Size = new System.Drawing.Size(647, 22);
            this.PathArquivoConfig.TabIndex = 2;
            this.PathArquivoConfig.Click += new System.EventHandler(this.PathArquivoConfig_Click);
            // 
            // PathAspNetRegiis
            // 
            this.PathAspNetRegiis.Location = new System.Drawing.Point(141, 30);
            this.PathAspNetRegiis.Name = "PathAspNetRegiis";
            this.PathAspNetRegiis.ReadOnly = true;
            this.PathAspNetRegiis.Size = new System.Drawing.Size(647, 22);
            this.PathAspNetRegiis.TabIndex = 3;
            this.PathAspNetRegiis.Click += new System.EventHandler(this.PathAspNetRegiis_Click);
            // 
            // buscadorDePastaAspNetRegiis
            // 
            this.buscadorDePastaAspNetRegiis.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.buscadorDePastaAspNetRegiis.ShowNewFolderButton = false;
            this.buscadorDePastaAspNetRegiis.HelpRequest += new System.EventHandler(this.buscadorDePastaAspNetRegiis_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PathAspNetRegiis);
            this.Controls.Add(this.PathArquivoConfig);
            this.Controls.Add(this.labelPathArquivoConfig);
            this.Controls.Add(labelPathAspNetRegiis);
            this.Name = "Form1";
            this.Text = "Encriptação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPathArquivoConfig;
        private System.Windows.Forms.TextBox PathArquivoConfig;
        private System.Windows.Forms.TextBox PathAspNetRegiis;
        private System.Windows.Forms.FolderBrowserDialog buscadorDePastaAspNetRegiis;
        private System.Windows.Forms.FolderBrowserDialog buscadorDePastaArquivoConfig;
    }
}

