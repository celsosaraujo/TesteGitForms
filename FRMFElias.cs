using System;
using System.Drawing;
using System.Windows.Forms;

namespace frmTesteGitForms
{
    public partial class FRMFElias : Form
    {
        Random rng = new Random();

        int ataqueBulbasaur = 15;
        bool batalhaAtiva = true;

        public FRMFElias()
        {
            InitializeComponent();
        }

        private void FRMFElias_Load(object sender, EventArgs e)
        {
            AtualizarCorHP(barVidaBulbasaur);
            AtualizarCorHP(barVidaCharmander);

            btnNovaBatalha.Enabled = false; // só libera ao ganhar/perder
        }

        // CONTROLE DE BATALHA
        void EncerrarBatalha()
        {
            batalhaAtiva = false;

            btnTackle.Enabled = false;
            btnEmber.Enabled = false;
            btnGrowl.Enabled = false;

            btnNovaBatalha.Enabled = true; // libera reset
        }

        void NovaBatalha()
        {
            batalhaAtiva = true;

            ataqueBulbasaur = 15;

            barVidaBulbasaur.Value = barVidaBulbasaur.Maximum;
            barVidaCharmander.Value = barVidaCharmander.Maximum;

            AtualizarCorHP(barVidaBulbasaur);
            AtualizarCorHP(barVidaCharmander);

            btnTackle.Enabled = true;
            btnEmber.Enabled = true;
            btnGrowl.Enabled = true;

            btnNovaBatalha.Enabled = false; // trava de novo

            rtbLog.Text = "Um BULBASAUR selvagem apareceu!";
        }

        // HP COLORIDO
        void AtualizarCorHP(ProgressBar barra)
        {
            int porcentagem = (barra.Value * 100) / barra.Maximum;

            if (porcentagem > 50)
                barra.ForeColor = Color.Green;
            else if (porcentagem > 20)
                barra.ForeColor = Color.Gold;
            else
                barra.ForeColor = Color.Red;
        }

        // TACKLE
        private void btnAtaque1_Click(object sender, EventArgs e)
        {
            if (!batalhaAtiva)
                return;

            int danoJogador = rng.Next(10, 21);

            if (barVidaBulbasaur.Value - danoJogador <= 0)
            {
                barVidaBulbasaur.Value = 0;
                AtualizarCorHP(barVidaBulbasaur);

                rtbLog.Text = "CHARMANDER usou TACKLE!\nVocê venceu o Pokémon selvagem!";
                EncerrarBatalha();
            }
            else
            {
                barVidaBulbasaur.Value -= danoJogador;
                AtualizarCorHP(barVidaBulbasaur);

                rtbLog.Text = $"CHARMANDER usou TACKLE e causou {danoJogador} de dano!";
                TurnoInimigo();
            }
        }

        // EMBER
        private void btnAtaque2_Click(object sender, EventArgs e)
        {
            if (!batalhaAtiva)
                return;

            int danoBase = rng.Next(10, 19);
            int danoFinal = danoBase * 2; // super efetivo

            if (barVidaBulbasaur.Value - danoFinal <= 0)
            {
                barVidaBulbasaur.Value = 0;
                AtualizarCorHP(barVidaBulbasaur);

                rtbLog.Text = "CHARMANDER usou EMBER!\nÉ super efetivo!\nVocê venceu o Pokémon selvagem!";
                EncerrarBatalha();
            }
            else
            {
                barVidaBulbasaur.Value -= danoFinal;
                AtualizarCorHP(barVidaBulbasaur);

                rtbLog.Text = $"CHARMANDER usou EMBER!\nÉ super efetivo!\nCausou {danoFinal} de dano!";
                TurnoInimigo();
            }
        }

        // GROWL
        private void btnGrowl_Click(object sender, EventArgs e)
        {
            if (!batalhaAtiva)
                return;

            ataqueBulbasaur -= 3;
            if (ataqueBulbasaur < 5)
                ataqueBulbasaur = 5;

            rtbLog.Text = "CHARMANDER usou GROWL!\nO ataque do BULBASAUR diminuiu!";
            TurnoInimigo();
        }

        // TURNO DO INIMIGO
        private void TurnoInimigo()
        {
            if (!batalhaAtiva || barVidaBulbasaur.Value <= 0)
                return;

            int danoInimigo = rng.Next(5, ataqueBulbasaur + 1);

            if (barVidaCharmander.Value - danoInimigo <= 0)
            {
                barVidaCharmander.Value = 0;
                AtualizarCorHP(barVidaCharmander);

                rtbLog.AppendText("\nCHARMANDER foi derrotado...");
                EncerrarBatalha();
            }
            else
            {
                barVidaCharmander.Value -= danoInimigo;
                AtualizarCorHP(barVidaCharmander);

                rtbLog.AppendText($"\nO BULBASAUR contra-atacou e tirou {danoInimigo} de HP!");
            }
        }

        // NOVA BATALHA
        private void btnNovaBatalha_Click_1(object sender, EventArgs e)
        {
            if (batalhaAtiva)
                return;

            NovaBatalha();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
