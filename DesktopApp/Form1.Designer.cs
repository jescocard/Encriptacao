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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PathArquivoConfig = new System.Windows.Forms.TextBox();
            this.PathAspNetRegiis = new System.Windows.Forms.TextBox();
            this.buscadorDePasta = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PathAspNetRegiis:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PathArquivoConfig:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PathArquivoConfig
            // 
            this.PathArquivoConfig.Location = new System.Drawing.Point(141, 61);
            this.PathArquivoConfig.Name = "PathArquivoConfig";
            this.PathArquivoConfig.ReadOnly = true;
            this.PathArquivoConfig.Size = new System.Drawing.Size(647, 22);
            this.PathArquivoConfig.TabIndex = 2;
            // 
            // PathAspNetRegiis
            // 
            this.PathAspNetRegiis.Location = new System.Drawing.Point(141, 30);
            this.PathAspNetRegiis.Name = "PathAspNetRegiis";
            this.PathAspNetRegiis.ReadOnly = true;
            this.PathAspNetRegiis.Size = new System.Drawing.Size(647, 22);
            this.PathAspNetRegiis.TabIndex = 3;
            // 
            // buscadorDePasta
            // 
            this.buscadorDePasta.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.buscadorDePasta.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PathAspNetRegiis);
            this.Controls.Add(this.PathArquivoConfig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encriptação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PathArquivoConfig;
        private System.Windows.Forms.TextBox PathAspNetRegiis;
        private System.Windows.Forms.FolderBrowserDialog buscadorDePasta;
    }
}

