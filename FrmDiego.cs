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
    public partial class FrmDiego : Form
    {
        public FrmDiego()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtExperiencia.Text) ||
                cmbDisponibilidade.SelectedIndex == -1 ||
                (!rdbInstrutor.Checked &&
                 !rdbCoordenadorCurso.Checked &&
                 !rdbTecnicoInformatica.Checked &&
                 !rdbAssistenteAdministrativo.Checked))
            {
                MessageBox.Show("Preencha todos os campos antes de enviar!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return; // BLOQUEIA O CADASTRO
            }
            // Mensagem
            MessageBox.Show("Vaga de emprego cadastrada com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Limpar TextBox
            txtNome.Clear();
            txtExperiencia.Clear();

            // Limpar ComboBox
            cmbDisponibilidade.SelectedIndex = -1;

            // Desmarcar RadioButtons (Cargo)
            rdbInstrutor.Checked = false;
            rdbCoordenadorCurso.Checked = false;
            rdbTecnicoInformatica.Checked = false;
            rdbAssistenteAdministrativo.Checked = false;

            
            txtNome.Focus();
        }
    }
}
