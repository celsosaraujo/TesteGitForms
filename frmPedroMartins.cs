using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace frmTesteGitForms
{
    public partial class frmPedroMartins : Form
    {

        public frmPedroMartins()
        {
            InitializeComponent();
            InicializarFormulario();
        }
        private void InicializarFormulario()
        {
            ConfigurarComboBoxes();
            LimparFormulario();
        }

        private void ConfigurarComboBoxes()
        {
            cbFilme.Items.Clear();
            cbFilme.Items.AddRange(new string[]
            {
                "Cartaz 1",
                "Cartaz 2",
                "Cartaz 3"
            });

            cbFilme.DropDownStyle = ComboBoxStyle.DropDownList;

            cbHorario.Items.Clear();
            cbHorario.Items.AddRange(new string[]
            {
                "14:00",
                "16:30",
                "19:00",
                "21:30"
            });
            cbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AtualizarFilme()
        {
            if (cbFilme.SelectedIndex == -1)
                return;

            string pasta = @"C:\Projetos\TesteGitForms\Cartazes";
            string arquivo = "";

            switch (cbFilme.Text)
            {
                case "Cartaz 1":
                    arquivo = "Cartaz1.png";
                    lblGenero.Text = "Ação";
                    lblTituloFilme.Text = "Jujutsu Kaisen: Execução";
                    break;

                case "Cartaz 2":
                    arquivo = "Cartaz2.png";
                    lblGenero.Text = "Drama";
                    lblTituloFilme.Text = "Homem-Aranha: Através do Aranhaverso";

                    break;

                case "Cartaz 3":
                    arquivo = "Cartaz3.png";
                    lblGenero.Text = "Ficção Científica";
                    lblTituloFilme.Text = "Avatar: Fogo e Cinzas";

                    break;
            }

            string caminho = Path.Combine(pasta, arquivo);

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Não achei a imagem:\n" + caminho);
                return;
            }

            picCartaz.Image?.Dispose();
            picCartaz.Image = Image.FromFile(caminho);
        }

        private decimal ObterValorIngresso()
        {
            if (rb2D.Checked) return 20m;
            if (rb3D.Checked) return 25m;
            if (rbIMAX.Checked) return 30m;
            return 0m;
        }

        private void AtualizarTotal()
        {
            decimal total = ObterValorIngresso() * numQtd.Value;
            lblTotal.Text = $"Total: R$ {total:F2}";
        }

        private bool FormularioValido()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                return false;

            if (cbFilme.SelectedIndex == -1)
                return false;

            if (cbHorario.SelectedIndex == -1)
                return false;

            if (ObterValorIngresso() == 0)
                return false;

            return true;
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEmail.Clear();

            cbFilme.SelectedIndex = -1;
            cbHorario.SelectedIndex = -1;

            rb2D.Checked = false;
            rb3D.Checked = false;
            rbIMAX.Checked = false;

            numQtd.Value = 1;

            lblGenerofixo.Text = "";
            lblTotal.Text = "Total: R$ 0,00";

            picCartaz.Image = null;
        }

        private void MostrarResumo()
        {
            MessageBox.Show(
                $"Nome: {txtNome.Text}\n" +
                $"Filme: {cbFilme.Text}\n" +
                $"Gênero: {lblGenerofixo.Text}\n" +
                $"Horário: {cbHorario.Text}\n" +
                $"Ingressos: {numQtd.Value}\n" +
                $"{lblTotal.Text}",
                "Resumo da Sessão",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void cbFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarFilme();
        }

        private void rb2D_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void rb3D_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void rbIMAX_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void numQtd_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show(
                    "Preencha todos os campos obrigatórios.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            MostrarResumo();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPedroMartins_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lblGenerofixo_Click(object sender, EventArgs e)
        {

        }
    }
}
