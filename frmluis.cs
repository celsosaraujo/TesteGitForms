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
    public partial class frmluis : Form
    {

        Random rnd = new Random();

        string[] perguntas = {
    "O que fica mais molhado quanto mais seca?",
    "O que tem pernas mas não anda?",
    "O que sobe mas nunca desce?",
    "O que quanto mais se tira, maior fica?"
};

        string[] respostas = {
    "toalha",
    "mesa",
    "idade",
    "buraco"
};

        int perguntaAtual;

        public frmluis()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;


        }
        //
        

        private void frmluis_Load(object sender, EventArgs e)
        {
            int hora = DateTime.Now.Hour;

            if (hora < 12)
                lblMenssagem.Text = "🌅 Bom dia, seja bem-vindo!";
            else if (hora < 18)
                lblMenssagem.Text = "🌤 Boa tarde, seja bem-vindo!";
            else
                lblMenssagem.Text = "🌙 Boa noite, seja bem-vindo!";
        }

        private void lblMenssagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = dtNascimento.Value.Day;
            int mes = dtNascimento.Value.Month;
            string signo = "";

            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
                signo = "Áries";
            else if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
                signo = "Touro";
            else if ((dia >= 21 && mes == 5) || (dia <= 20 && mes == 6))
                signo = "Gêmeos";
            else if ((dia >= 21 && mes == 6) || (dia <= 22 && mes == 7))
                signo = "Câncer";
            else if ((dia >= 23 && mes == 7) || (dia <= 22 && mes == 8))
                signo = "Leão";
            else if ((dia >= 23 && mes == 8) || (dia <= 22 && mes == 9))
                signo = "Virgem";
            else if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
                signo = "Libra";
            else if ((dia >= 23 && mes == 10) || (dia <= 21 && mes == 11))
                signo = "Escorpião";
            else if ((dia >= 22 && mes == 11) || (dia <= 21 && mes == 12))
                signo = "Sagitário";
            else if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
                signo = "Capricórnio";
            else if ((dia >= 21 && mes == 1) || (dia <= 18 && mes == 2))
                signo = "Aquário";
            else
                signo = "Peixes";

            lblResultado.Text = signo;

        }

        private void dtNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }





        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnNovaPergunta_Click(object sender, EventArgs e)
        {
            perguntaAtual = rnd.Next(perguntas.Length);
            lblPergunta.Text = perguntas[perguntaAtual];
            txtResposta.Text = "";
            lblResultadoPuzzle.Text = "";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtResposta.Text.ToLower().Trim() == respostas[perguntaAtual])
                lblResultadoPuzzle.Text = "✅ Acertou!";
            else
                lblResultadoPuzzle.Text = "❌ Errou";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}
