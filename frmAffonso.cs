using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace frmTesteGitForms
{
    public partial class frmAffonso : Form
    {
        public frmAffonso()
        {
            InitializeComponent();
        }
        void Arredondar(Control c, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(c.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(c.Width - raio, c.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, c.Height - raio, raio, raio, 90, 90);

            path.CloseAllFigures();
            c.Region = new Region(path);
        }
        private void frmAffonso_Load(object sender, EventArgs e)
        {
            Arredondar(btnVerso, btnVerso.Height);
            Arredondar(btnFrente, btnFrente.Height);
            Arredondar(btnVerificar, btnVerso.Height);
            Arredondar(btnCancelar, btnFrente.Height);
        }



        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string numeroCartao = txtNumero.Text;
            string cvv = txtCVV.Text;
            string validade = txtValidade.Text;

            lblRespostaCVV.Text = cvv;
            lblRespostaNum.Text = numeroCartao;
            lblRespostaVal.Text = validade;

            MessageBox.Show("Cartão cadastrado com sucesso!");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblRespostaVal.Text = string.Empty;
            lblRespostaNum.Text= string.Empty;
            lblRespostaCVV.Text= string.Empty;
        }

        private void picFrente_Click(object sender, EventArgs e)
        {

        }

        
        void SelecionarFrente()
        {
            btnFrente.BackColor = Color.MediumPurple;
            btnVerso.BackColor = Color.White;

        }

        void SelecionarVerso()
        {
            btnVerso.BackColor = Color.MediumPurple;
            btnFrente.BackColor = Color.White;

        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            lblRespostaNum.Visible = true;
            picFrente.Visible = true;

            lblRespostaCVV.Visible = false;
            lblRespostaVal.Visible = false;
            picVerso.Visible = false;

            SelecionarFrente();

        }

        private void btnVerso_Click(object sender, EventArgs e)
        {
            lblRespostaNum.Visible = false;
            picFrente.Visible = false;

            lblRespostaCVV.Visible = true;
            lblRespostaVal.Visible = true;
            picVerso.Visible = true;

            SelecionarVerso();
        }
    }
}
