namespace frmTesteGitForms
{

    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void celsoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuCelso_Click(object sender, EventArgs e)
        {
            frmCelso tela = new frmCelso();
            tela.ShowDialog();
        }

        private void mnuThiago_Click(object sender, EventArgs e)
        {
            frmThiago tela = new frmThiago();
            tela.ShowDialog();
        }

        private void gustavoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            using (frmGustavo frmGustavo = new frmGustavo())
            {
                frmGustavo.ShowDialog();
            }
            this.ShowDialog();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnuluis_Click(object sender, EventArgs e)
        {
            frmluis tela = new frmluis();
            tela.ShowDialog();
        }

        private void diegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiego frmDiego = new FrmDiego();
            frmDiego.ShowDialog();
            
        }

        private void affonsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAffonso tela = new frmAffonso();
            tela.ShowDialog();
        }

        private void mniPedro_Click(object sender, EventArgs e)
        {
            frmPedroMartins frmPedroMartins = new frmPedroMartins();
            frmPedroMartins.ShowDialog();

        }

        private void hannaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMHanna frmHanna = new FRMHanna();
            frmHanna.ShowDialog();
        }

        private void suelyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuely frmSuely = new frmSuely();
            frmSuely.ShowDialog();

        }

        private void mniElias_Click(object sender, EventArgs e)
        {
            FRMFElias batalha = new FRMFElias();
            batalha.Owner = this;
            batalha.Show();
            this.Hide();
        }

        private void PauloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaulo frmPaulo = new frmPaulo();
            frmPaulo.ShowDialog();
        }

       
    }
}