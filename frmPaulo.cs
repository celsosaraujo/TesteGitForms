using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTesteGitForms
{
    public partial class frmPaulo : Form
    {
        public frmPaulo()
        {
            InitializeComponent();
            cmbSituacao.Items.Clear();
            cmbSituacao.Items.Add("Em serviço");
            cmbSituacao.Items.Add("Em treinamento");
            cmbSituacao.Items.Add("De folga");

            cmbPatente.Items.Clear();
            cmbPatente.Items.Add("Soldado");
            cmbPatente.Items.Add("Cabo");
            cmbPatente.Items.Add("Sargento");
        }

        private void mnuPaulo_Click(object sender, EventArgs e)
        {
            frmPaulo tela = new frmPaulo();
            tela.ShowDialog();
        }

        private void cmbPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPatente.SelectedIndex = 0;
        }


        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSituacao.SelectedIndex = 0;
        }

        private void btnConfirmarStatus_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cmbPatente.SelectedIndex == -1 || cmbSituacao.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Atenção!");
                return;
            }

            string nome = txtNome.Text;
            string patente = cmbPatente.SelectedItem?.ToString() ?? string.Empty;
            string situacao = cmbSituacao.SelectedItem?.ToString() ?? string.Empty;

            MessageBox.Show($"Soldado: {nome}\nPatente: {patente}\nSituação: {situacao}", "Status Confirmado");
        }

       
    }
}
