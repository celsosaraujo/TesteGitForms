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

        

        private void cmbPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarStatus_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || cmbPatente.SelectedIndex == -1 || cmbSituacao.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Atenção!");
                return;
            }

            string nome = txtNome.Text.Trim();
            if (nome.Split(' ').Length < 2)
            {
                MessageBox.Show("Digite nome e sobrenome.", "Nome incompleto");
                txtNome.Focus();
                return;
            }
            string patente = cmbPatente.SelectedItem?.ToString() ?? string.Empty;
            string situacao = cmbSituacao.SelectedItem?.ToString() ?? string.Empty;

            MessageBox.Show($"Soldado: {nome}\nPatente: {patente}\nSituação: {situacao}", "Status Confirmado");
        }

       
    }
}
