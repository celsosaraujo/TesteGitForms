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
    public partial class frmGustavo : Form
    {
        public frmGustavo()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            double soma = (num1 = Convert.ToDouble(txtNum1.Text)) + (num2 = Convert.ToDouble(txtNum2.Text));

            txtResultado.Text = soma.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            double sub = (num1 = Convert.ToDouble(txtNum1.Text)) - (num2 = Convert.ToDouble(txtNum2.Text));

            txtResultado.Text = sub.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            double mult = (num1 = Convert.ToDouble(txtNum1.Text)) * (num2 = Convert.ToDouble(txtNum2.Text));

            txtResultado.Text = mult.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            double divisao = (num1 = Convert.ToDouble(txtNum1.Text)) / (num2 = Convert.ToDouble(txtNum2.Text));

            txtResultado.Text = divisao.ToString("F2");
        }
    }
}
