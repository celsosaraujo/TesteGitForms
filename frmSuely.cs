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
    public partial class frmSuely : Form
    {
        public frmSuely()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();

            rdbMuitoRuim.Checked = false;
            rdbRuim.Checked = false;
            rdbRegular.Checked = false;
            rdbBom.Checked = false;
            rdbExcelente.Checked = false;

            chkProfessores.Checked = false;
            chkConteudo.Checked = false;
            chkMaterial.Checked = false;
            chkAmbiente.Checked = false;
            chkOutros.Checked = false;

            txtNome.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, informe seu nome.");
                txtNome.Focus();
                return;
            }

            string nota = "";

            if (rdbMuitoRuim.Checked) nota = "Muito Ruim";
            else if (rdbRuim.Checked) nota = "Ruim";
            else if (rdbRegular.Checked) nota = "Regular";
            else if (rdbBom.Checked) nota = "Bom";
            else if (rdbExcelente.Checked) nota = "Excelente";

            if (nota == "")
            {
                MessageBox.Show("Selecione uma nota.");
                return;
            }

            List<string> pontos = new List<string>();

            if (chkProfessores.Checked) pontos.Add("Professores");
            if (chkConteudo.Checked) pontos.Add("Conteúdo");
            if (chkMaterial.Checked) pontos.Add("Material");
            if (chkAmbiente.Checked) pontos.Add("Ambiente");
            if (chkOutros.Checked) pontos.Add("Outros");

            string pontosTexto = pontos.Count > 0
                ? string.Join(", ", pontos)
                : "Nenhum informado";

            MessageBox.Show(
                $"Nome: {txtNome.Text}\nNota: {nota}\nPontos: {pontosTexto}",
                "Pesquisa enviada com sucesso!!"
            );

            btnLimpar.PerformClick();
        }
    }
}
