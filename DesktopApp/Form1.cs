using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void labelPathAspNetRegiis_Click(object sender, EventArgs e)
        {
            getPathAspNetReggis();
        }
        private void PathAspNetRegiis_Click(object sender, EventArgs e)
        {
            getPathAspNetReggis();
        }
        private void getPathAspNetReggis()
        {
            var resposta = buscadorDePastaAspNetRegiis.ShowDialog();
            if (DialogResult.OK == resposta)
                PathAspNetRegiis.Text = buscadorDePastaAspNetRegiis.SelectedPath;
        }
        private void labelPathArquivoConfig_Click(object sender, EventArgs e)
        {
            getPathArquivoConfig();
        }
        private void PathArquivoConfig_Click(object sender, EventArgs e)
        {
            getPathArquivoConfig();   
        }
        private void getPathArquivoConfig()
        {
            var resposta = buscadorDePastaArquivoConfig.ShowDialog();
            if (DialogResult.OK == resposta)
                PathArquivoConfig.Text = buscadorDePastaArquivoConfig.SelectedPath;
        }

        private void buscadorDePastaAspNetRegiis_HelpRequest(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Replace_CheckedChanged(object sender, EventArgs e)
        {
            replaceBox.Visible = Replace.Checked;
            replaceGrid.Rows.Clear();
        }

        private void novoValorLabel_Click(object sender, EventArgs e)
        {
            novoValor.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            replaceGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(valorAtual.Text)) 
            {
                MessageBox.Show(this, "Informe: Valor Atual");
            }
            else
            {
                replaceGrid.Rows.Add(new object[] { valorAtual.Text, novoValor.Text, false });
                valorAtual.Text = novoValor.Text = "";
            }
        }

        private void valorAtualLabel_Click(object sender, EventArgs e)
        {
            valorAtual.Focus();
        }

        private void replaceBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
