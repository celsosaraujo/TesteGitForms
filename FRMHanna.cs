using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing.Drawing2D;

namespace frmTesteGitForms
{
    public partial class FRMHanna : Form
    {
        public FRMHanna()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 35; // quanto arredonda

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnFinalizar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnFinalizar.Width - radius, btnFinalizar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnFinalizar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btnFinalizar.Region = new Region(path);
        }
        


        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            string N = txtNumero.Text;

            if (N.Length > 0)
            {
                char ultimo = N[N.Length - 1];

                if (char.IsLetter(ultimo) || char.IsWhiteSpace(ultimo))
                {
                    txtNumero.Text = N.Remove(N.Length - 1);
                    txtNumero.SelectionStart = txtNumero.Text.Length;

                    MessageBox.Show("Não é permitido digitar Letras.");
                }
            }
            VerificarCampos();
            txtcardNumero.Text = txtNumero.Text;
        }

        private void txtCVV_TextChanged(object sender, EventArgs e)
        {
            string cvv = txtCVV.Text;

            if (cvv.Length > 0)
            {
                char ultimo = cvv[cvv.Length - 1];

                if (char.IsLetter(ultimo) || char.IsWhiteSpace(ultimo))
                {
                    txtCVV.Text = cvv.Remove(cvv.Length - 1);
                    txtCVV.SelectionStart = txtCVV.Text.Length;

                    MessageBox.Show("Não é permitido digitar Letras.");
                }
            }
            VerificarCampos();
            txtcardCVV.Text = txtCVV.Text;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string t = txtNome.Text;

            if (t.Length > 0)
            {
                char ultimo = t[t.Length - 1];

                if (char.IsDigit(ultimo))
                {
                    txtNome.Text = t.Remove(t.Length - 1);
                    txtNome.SelectionStart = txtNome.Text.Length;

                    MessageBox.Show("Não é permitido digitar números.");
                }
            }
            VerificarCampos();
            txtcardNome.Text = txtNome.Text;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cartão Finalizado com Sucesso");
            MessageBox.Show("HaCkEd hAcKeD HaCkEd hAcKeD");
            MessageBox.Show("HaCkEd hAcKeD HaCkEd hAcKeD");
            MessageBox.Show("HaCkEd hAcKeD HaCkEd hAcKeD");
            MessageBox.Show("HaCkEd hAcKeD HaCkEd hAcKeD");
            MessageBox.Show("HaCkEd hAcKeD HaCkEd hAcKeD");
            MessageBox.Show("Obrigado Pelos Dados");
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
        }
        private void VerificarCampos()
        {
            if (!string.IsNullOrWhiteSpace(txtNumero.Text) &&
                !string.IsNullOrWhiteSpace(txtCVV.Text) &&
                !string.IsNullOrWhiteSpace(txtNome.Text))
            {
                btnFinalizar.Enabled = true;
            }
            else
            {
                btnFinalizar.Enabled = false;
            }
        }
    }
}
